using System;
using CYJ.DingDing.Application.IAppService;
using CYJ.DingDing.Dto;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Dto.Enum;
using CYJ.DingDing.Infrastructure.Config;
using CYJ.DingDing.Infrastructure.Exception;
using CYJ.DingDing.Infrastructure.Treasury;
using CYJ.DingDing.Sdks;
using CYJ.DingDing.Sdks.DingDingSdk;
using Newtonsoft.Json;

namespace CYJ.DingDing.Application.AppService
{
    public class TokenAppService : ITokenAppService
    {
        private readonly IConfigHelper _configHelper;


        public TokenAppService(IConfigHelper configHelper)
        {
            _configHelper = configHelper;
        }

        public AccessTokenResponse GetToken(AccessTokenRequest request)
        {
            if (string.IsNullOrWhiteSpace(request?.CorpId) || string.IsNullOrWhiteSpace(request.CorpSecret))
            {
                throw new ApiException(ApiCodeEnum.NullReferenceException, "缺少必要的参数CorpId和CorpSecret");
            }

            var corpId = request.CorpId;
            var corpSecret = request.CorpSecret;
            var tokenUrl = Urls.GetToken;//"https://oapi.dingtalk.com/gettoken";
            var apiurl = string.Format(tokenUrl, corpId, corpSecret);

            var resultJson = RequestHelper.Get(apiurl);

            AccessTokenResponse tokenResult = JsonConvert.DeserializeObject<AccessTokenResponse>(resultJson);
            if (tokenResult.ErrCode == ErrCodeEnum.OK)
            {
                return tokenResult;
            }

            throw new ApiException(ApiCodeEnum.RequestTokenFailure, "请求Token失败" + tokenResult.ErrMsg);
        }
    }
}