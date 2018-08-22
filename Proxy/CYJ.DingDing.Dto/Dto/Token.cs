using System;
using CYJ.DingDing.Dto.Dto.Base;
using CYJ.Utils.Extension.DateTimeExtension;

namespace CYJ.DingDing.Dto.Dto
{
    public class AccessTokenRequest
    {
        public string CorpId { get; set; }

        public string CorpSecret { get; set; }
    }

    /// <summary>
    /// "{\"expires_in\":7200,\"errmsg\":\"ok\",\"access_token\":\"7419ee867eb23a86a66f584a6e6d02eb\",\"errcode\":0}"
    /// </summary>
    public class AccessTokenResponse : DingTalkResponse
    {
        /// <summary>
        /// 获取到的凭证
        /// </summary>
        public string Access_token { get; set; }

        /// <summary>
        /// 票据的过期时间
        /// </summary>
        public int Expires_in { get; set; } = 0;

        /// <summary>
        /// 票据的开始时间
        /// </summary>
        public long Begin { get; set; } = DateTime.Now.GetUnixTimestamp();
    }

}
