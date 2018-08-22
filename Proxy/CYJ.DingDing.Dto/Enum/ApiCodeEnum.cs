using System.ComponentModel;

namespace CYJ.DingDing.Dto.Enum
{
    public enum ApiCodeEnum
    {
        [Description("系统错误")]
        Error = 0,

        [Description("对象不能为空")]
        NullReferenceException,

        [Description("请求Token失败")]
        RequestTokenFailure,

        [Description("无效的Id")]
        InvalidId,
    }
}