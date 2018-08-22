using System;
using CYJ.DingDing.Dto.Enum;

namespace CYJ.DingDing.Dto.Dto.Base
{
    public class DingTalkResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public ErrCodeEnum ErrCode { get; set; } = ErrCodeEnum.Unknown;

        /// <summary>
        /// 错误消息
        /// </summary>
        public string ErrMsg { get; set; }

        public bool IsOk()
        {
            return ErrCode == ErrCodeEnum.OK;
        }

        public override string ToString()
        {
            String info = $"{nameof(ErrCode)}:{ErrCode},{nameof(ErrMsg)}:{ErrMsg}";

            return info;
        }
    }

}