using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace CYJ.DingDing.Service.Http.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppsController : ControllerBase
    {
        static Logger Logger = LogManager.GetCurrentClassLogger();

        // GET: api/App
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Logger.Info("普通信息日志-----------");
            Logger.Debug("调试日志-----------");
            Logger.Error("错误日志-----------");
            Logger.Fatal("异常日志-----------");
            Logger.Warn("警告日志-----------");
            Logger.Trace("跟踪日志-----------");
            Logger.Log(NLog.LogLevel.Warn, "Log日志------------------");

            return new string[] { "value1", "value2" };
        }

        // GET: api/App/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/App
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/App/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
