namespace CYJ.Base.Infrastructure.Ioc
{
    public enum EnumLifetimeScope
    {
        /// <summary>
        /// 每次都new一个对象
        /// </summary>
        InstancePerDependency = 0,

        /// <summary>
        /// 生命周期唯一
        /// </summary>
        InstancePerLifetimeScope = 1,

        /// <summary>
        /// 全局单例
        /// </summary>
        SingleInstance = 2,
    }
}