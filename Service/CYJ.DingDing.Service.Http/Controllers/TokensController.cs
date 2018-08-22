using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CYJ.DingDing.Api.IApiService;
using CYJ.DingDing.Dto;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Infrastructure.Log;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CYJ.DingDing.Service.Http.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokensController : BaseController
    {
        private readonly ITokenApiService _tokenApiService;

        public TokensController(ITokenApiService tokenApiService)
        {
            _tokenApiService = tokenApiService;
        }

        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <param name="corpId">企业Id</param>
        /// <param name="corpSecret">企业应用的凭证密钥</param>
        /// <returns>Access_Token是企业访问钉钉开放平台全局接口的唯一凭证，即调用接口时需携带Access_Token。</returns>
        // GET api/values
        [HttpGet]
        public AccessTokenResponse Get(string corpId, string corpSecret)
        {
            return Post(new AccessTokenRequest
            {
                CorpId = corpId,
                CorpSecret = corpSecret
            });
        }

        private AccessTokenResponse Post(AccessTokenRequest request)
        {
            LogProxy.CommonLog(JsonConvert.SerializeObject(request));

            var rtn = _tokenApiService.GetToken(request);

            return rtn;
        }
    }
}