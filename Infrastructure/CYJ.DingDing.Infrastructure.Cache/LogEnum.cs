namespace CYJ.DingDing.Infrastructure.Cache
{
    /// <summary>
    /// 日志级别：Trace -》Debug-》 Information -》Warning-》 Error-》 Critical
    /// 开发人员可以根据日志级别将众多日志存储到不到的介质中，以供分析用户需求、定准程序错误等。
    /// </summary>
    public enum LogEnum
    {
        /// <summary>
        /// 这个级别只对开发人员调试有价值。这些消息可能包含敏感的应用程序数据，因此不应该在生产环境中启用。
        /// </summary>
        Trace = 0,

        /// <summary>
        /// 对于在开发和调试过程中具有短期可用性的信息。如果不是出现问题在生产环境一般不建议启用。
        /// </summary>
        Debug = 1,

        /// <summary>
        /// 用于跟踪应用程序，这些日志有长期的价值。
        /// </summary>
        Information = 2,

        /// <summary>
        /// 用于程序中的异常或意外事件。这些可能包括错误或其他不导致应用程序停止的条件，但是可能需要进行排查。
        /// </summary>
        Warning = 3,

        /// <summary>
        /// 对于不能处理的错误过异常。这些消息表明当前的活动或操作(例如当前的HTTP请求)失败，而不是应用程序范围的失败。
        /// </summary>
        Error = 4,

        /// <summary>
        /// 对于那些需要立即关注的失败。示例:磁盘空间中的数据丢失场景。
        /// </summary>
        Critical = 5
    }
}