using System;
using System.Collections.Generic;
using System.Text;
using CYJ.DingDing.Dto.Dto.Base;
using CYJ.DingDing.Dto.Enum;

namespace CYJ.DingDing.Dto.Dto
{
    //public class ResultPackage
    //{
    //    /// <summary>
    //    /// 错误码
    //    /// </summary>
    //    public ErrCodeEnum ErrCode { get; set; } = ErrCodeEnum.Unknown;

    //    /// <summary>
    //    /// 错误消息
    //    /// </summary>
    //    public string ErrMsg { get; set; }

    //    /// <summary>
    //    /// 结果的json形式
    //    /// </summary>
    //    public String Json { get; set; }

    //    public bool IsOK()
    //    {
    //        return ErrCode == ErrCodeEnum.OK;
    //    }

    //    public override string ToString()
    //    {
    //        String info = $"{nameof(ErrCode)}:{ErrCode},{nameof(ErrMsg)}:{ErrMsg}";

    //        return info;
    //    }
    //}

    public class SendMessageResult : DingTalkResponse
    {
        public string Receiver { get; set; }
    }
}
