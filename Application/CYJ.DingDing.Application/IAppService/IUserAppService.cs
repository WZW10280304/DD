using CYJ.DingDing.Dto.Dto;

namespace CYJ.DingDing.Application.IAppService
{
    public interface IUserAppService
    {
        UserListResponse GetList(UserListRequest request);

        UserDetailResponse GetModel(int id);

        UserCreateResponse Create(UserCreateRequest request);

        UserUpdateResponse Update(UserUpdateRequest request);

        UserDeleteResponse Delete(int id);
    }
}