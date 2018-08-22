using CYJ.DingDing.Dto;
using CYJ.DingDing.Dto.Dto;

namespace CYJ.DingDing.Api.IApiService
{
    public interface ITokenApiService
    {
        AccessTokenResponse GetToken(AccessTokenRequest request);
    }
}