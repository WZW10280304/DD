using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;

namespace CYJ.Base.Infrastructure.Ioc
{
    public static class AquainumContainer
    {
        public static IContainer Container = null;
        public static ContainerBuilder Builder = null;

        /// <summary>
        /// 注册普通类型（在未Builder之前调用）
        /// </summary>
        /// <typeparam name="TImplementer"></typeparam>
        /// <typeparam name="TInterface"></typeparam>
        /// <param name="lifetimeScope"></param>

        public static void Register<TImplementer, TInterface>(EnumLifetimeScope lifetimeScope = EnumLifetimeScope.InstancePerDependency) where TImplementer : TInterface
        {
            var result = Builder.RegisterType<TImplementer>().As<TInterface>();
            switch (lifetimeScope)
            {
                case EnumLifetimeScope.InstancePerDependency: result.InstancePerDependency(); break;
                case EnumLifetimeScope.InstancePerLifetimeScope: result.InstancePerLifetimeScope(); break;
                case EnumLifetimeScope.SingleInstance: result.SingleInstance(); break;
            }
        }

        /// <summary>
        /// 注册普通类型（在未Builder之前调用）
        /// </summary>
        /// <param name="implementer"></param>
        /// <param name="interface"></param>
        /// <param name="lifetimeScope"></param>
        public static void Register(Type implementer, Type @interface, EnumLifetimeScope lifetimeScope = EnumLifetimeScope.InstancePerDependency)
        {
            var result = Builder.RegisterType(implementer).As(@interface);
            switch (lifetimeScope)
            {
                case EnumLifetimeScope.InstancePerDependency: result.InstancePerDependency(); break;
                case EnumLifetimeScope.InstancePerLifetimeScope: result.InstancePerLifetimeScope(); break;
                case EnumLifetimeScope.SingleInstance: result.SingleInstance(); break;
            }
        }

        /// <summary>
        /// 注册泛型（在未Builder之前调用）
        /// </summary>
        /// <param name="implementer"></param>
        /// <param name="interface"></param>
        /// <param name="lifetimeScope"></param>
        public static void RegisterGeneric(Type implementer, Type @interface, EnumLifetimeScope lifetimeScope = EnumLifetimeScope.InstancePerDependency)
        {
            var result = Builder.RegisterGeneric(implementer).As(@interface);
            switch (lifetimeScope)
            {
                case EnumLifetimeScope.InstancePerDependency: result.InstancePerDependency(); break;
                case EnumLifetimeScope.InstancePerLifetimeScope: result.InstancePerLifetimeScope(); break;
                case EnumLifetimeScope.SingleInstance: result.SingleInstance(); break;
            }
        }

        /// <summary>
        /// 注册类型（在未Builder之前调用）
        /// </summary>
        /// <param name="type"></param>
        /// <param name="lifetimeScope"></param>
        public static void RegisterType(Type type, EnumLifetimeScope lifetimeScope = EnumLifetimeScope.InstancePerDependency)
        {
            var result = Builder.RegisterType(typeof(Type));
            switch (lifetimeScope)
            {
                case EnumLifetimeScope.InstancePerDependency: result.InstancePerDependency(); break;
                case EnumLifetimeScope.InstancePerLifetimeScope: result.InstancePerLifetimeScope(); break;
                case EnumLifetimeScope.SingleInstance: result.SingleInstance(); break;
            }
        }

        /// <summary>
        /// 反转
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resolveType"></param>
        /// <returns></returns>
        public static T Resolve<T>(Type resolveType) where T : class
        {
            var result = Container.Resolve(resolveType);
            return result as T;
        }

        /// <summary>
        /// 反转
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object Resolve(Type type)
        {
            var result = Container.Resolve(type);
            return result;
        }

        /// <summary>
        /// 反转
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        /// <summary>
        /// 反转
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parms"></param>
        /// <returns></returns>
        public static T Resolve<T>(Dictionary<string, object> parms)
        {
            if (parms == null || parms.Count < 1)
            {
                throw new ArgumentException("参数不能为空");
            }
            var namedParameters = parms.Select(m => new NamedParameter(m.Key.Trim(), m.Value)).ToList();
            var t = Container.Resolve<T>(namedParameters);
            return t;
        }

        public static T Resolve<T>(string name, object value)
        {
            var t = Container.Resolve<T>(new NamedParameter(name.Trim(), value));
            return t;
        }

        /// <summary>
        /// 获取所有实现
        /// </summary>
        /// <typeparam name="T">接口或基类类型</typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ResolveAll<T>()
        {
            return Container.Resolve<IEnumerable<T>>();
        }

        /// <summary>
        /// 根据配置Key获取指定的实现
        /// </summary>
        /// <typeparam name="T">接口或基类类型</typeparam>
        /// <param name="name">别名</param>
        /// <returns></returns>
        public static T ResolveByName<T>(string name)
        {
            return Container.ResolveKeyed<T>(name.Trim());
        }
    }
}