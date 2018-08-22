using CYJ.DingDing.Dto.Dto;

namespace CYJ.DingDing.Application.IAppService
{
    public interface ITokenAppService
    {
        AccessTokenResponse GetToken(AccessTokenRequest request);
    }
}