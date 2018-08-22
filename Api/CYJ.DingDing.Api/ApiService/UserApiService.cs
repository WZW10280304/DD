using CYJ.DingDing.Api.IApiService;
using CYJ.DingDing.Application.IAppService;
using CYJ.DingDing.Dto.Dto;

namespace CYJ.DingDing.Api.ApiService
{
    public class UserApiService : IUserApiService
    {
        private readonly IUserAppService userAppService;

        public UserApiService(IUserAppService userAppService)
        {
            this.userAppService = userAppService;
        }

        public UserListResponse GetList(UserListRequest request)
        {
            return userAppService.GetList(request);
        }

        public UserDetailResponse GetModel(int id)
        {
            return userAppService.GetModel(id);
        }

        public UserCreateResponse Create(UserCreateRequest request)
        {
            return userAppService.Create(request);
        }

        public UserUpdateResponse Update(UserUpdateRequest request)
        {
            return userAppService.Update(request);
        }

        public UserDeleteResponse Delete(int id)
        {
            return userAppService.Delete(id);
        }
    }
}