using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CYJ.DingDing.Dto;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Dto.Enum;
using CYJ.DingDing.Infrastructure.Config;
using CYJ.DingDing.Sdks.DingDingSdk;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CYJ.DingDing.Service.Http.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        ///// <summary>
        ///// 创建静态字段，保证全局一致
        ///// </summary>
        //public static AccessToken AccessToken = new AccessToken();

        //#region UpdateAccessToken
        ///// <summary>
        /////更新票据
        ///// </summary>
        ///// <param name="forced">true:强制更新.false:按缓存是否到期来更新</param>
        //public static void UpdateAccessToken(bool forced = false)
        //{
        //    //ConstVars.CACHE_TIME是缓存时间(常量，也可放到配置文件中)，这样在有效期内则直接从缓存中获取票据，不需要再向服务器中获取。
        //    if (!forced && AccessToken.Begin.AddSeconds(ConstVars.CACHE_TIME) >= DateTime.Now)
        //    {//没有强制更新，并且没有超过缓存时间
        //        return;
        //    }

        //    string CorpID = ConfigHelper.FetchCorpID();
        //    string CorpSecret = ConfigHelper.FetchCorpSecret();
        //    string TokenUrl = Urls.gettoken;
        //    string apiurl = $"{TokenUrl}?{Keys.corpid}={CorpID}&{Keys.corpsecret}={CorpSecret}";

        //    WebRequest request = WebRequest.Create(@apiurl);
        //    request.Method = "GET";
        //    WebResponse response = request.GetResponse();
        //    Stream stream = response.GetResponseStream();
        //    Encoding encode = Encoding.UTF8;
        //    StreamReader reader = new StreamReader(stream, encode);
        //    string resultJson = reader.ReadToEnd();

        //    TokenResult tokenResult = JsonConvert.DeserializeObject<TokenResult>(resultJson);
        //    if (tokenResult.ErrCode == ErrCodeEnum.OK)
        //    {
        //        AccessToken.Value = tokenResult.Access_token;
        //        AccessToken.Begin = DateTime.Now;
        //    }
        //}
        //#endregion
    }

}
