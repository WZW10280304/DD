using CYJ.DingDing.Api.IApiService;
using CYJ.DingDing.Application.IAppService;
using CYJ.DingDing.Dto;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Infrastructure.Log;
using Newtonsoft.Json;

namespace CYJ.DingDing.Api.ApiService
{
    public class TokenApiService : ITokenApiService
    {
        private readonly ITokenAppService _tokenAppService;

        public TokenApiService(ITokenAppService tokenAppService)
        {
            _tokenAppService = tokenAppService;
        }

        public AccessTokenResponse GetToken(AccessTokenRequest request)
        {
            return _tokenAppService.GetToken(request);
        }
    }
}
