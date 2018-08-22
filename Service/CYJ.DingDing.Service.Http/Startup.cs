using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using CYJ.Base.Service.Http.Filters;
using CYJ.DingDing.Infrastructure.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace CYJ.DingDing.Service.Http
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var serviceXml = Path.Combine(Directory.GetCurrentDirectory(), @"Xml\CYJ.DingDing.Service.Http.xml");
            var dtoXml = Path.Combine(Directory.GetCurrentDirectory(), @"Xml\CYJ.DingDing.Dto.xml");
            var sdkXml = Path.Combine(Directory.GetCurrentDirectory(), @"Xml\CYJ.DingDing.Sdks.xml");
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                // 解决相同类名会报错的问题
                c.CustomSchemaIds(type => type.FullName);
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                if (System.IO.File.Exists(serviceXml)) { c.IncludeXmlComments(serviceXml, true); }
                if (System.IO.File.Exists(dtoXml)) { c.IncludeXmlComments(dtoXml, true); }
                if (System.IO.File.Exists(sdkXml)) { c.IncludeXmlComments(sdkXml, true); }
            });

            services.AddMvc(config => config.Filters.Add(new BaseActionFilterAttribute()));
            services.AddMvc(config => config.Filters.Add(new BaseExceptionFilterAttribute()));
            services.AddMvc(config => config.Filters.Add(new BaseAuthFilterAttribute()));

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddDirectoryBrowser();

            var builder = new ContainerBuilder();
            builder.Populate(services);

            builder.RegisterType<ConfigHelper>().As<IConfigHelper>();

            builder.RegisterAssemblyTypes(Assembly.Load("CYJ.DingDing.Api"))
                    .Where(m => !string.IsNullOrWhiteSpace(m.Namespace))
                    .Where(m => m.IsClass)
                    .Where(m => m.Namespace.Contains("ApiService"))
                    .Where(m => m.Name.EndsWith("ApiService"))
                    .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(Assembly.Load("CYJ.DingDing.Application"))
                .Where(m => !string.IsNullOrWhiteSpace(m.Namespace))
                .Where(m => m.IsClass)
                .Where(m => m.Namespace.Contains("AppService"))
                .Where(m => m.Name.EndsWith("AppService"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            var container = builder.Build();
            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //这样在控制台显示就不会出现乱码。
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            loggerFactory.AddConsole();
            //loggerFactory.AddNLog(); //添加NLog
            //app.AddNLogWeb();
            //loggerFactory.ConfigureNLog("nlog.config");//读取Nlog配置文件

            app.UseStaticFiles(); //注册wwwroot静态文件

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" }
                );
            });
        }
    }
}
