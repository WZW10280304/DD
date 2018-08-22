using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Top.Api.Util
{
    /// <summary>
    /// SPI请求校验结果。
    /// </summary>
    public class CheckResult
    {
        public bool Success { get; set; }

        public string Body { get; set; }
    }

}
