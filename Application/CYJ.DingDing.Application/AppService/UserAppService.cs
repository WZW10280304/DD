using CYJ.DingDing.Application.IAppService;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Dto.Enum;
using CYJ.DingDing.Infrastructure.Exception;
using CYJ.DingDing.Infrastructure.Treasury;
using CYJ.DingDing.Sdks.DingDingSdk;

namespace CYJ.DingDing.Application.AppService
{
    public class UserAppService : IUserAppService
    {
        public UserListResponse GetList(UserListRequest request)
        {
            var apiurl = string.Format(Urls.UserDetailList,
                request.ACCESS_TOKEN, request.DepartmentId, request.Offset, request.Size, request.Order);

            var rtn = RequestHelper.Get<UserListResponse>(apiurl);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }

        public UserDetailResponse GetModel(int id)
        {
            var apiurl = string.Format(Urls.UserDetailList, RequestHelper.GetAccessToken(), id);

            var rtn = RequestHelper.Get<UserDetailResponse>(apiurl);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }

        public UserCreateResponse Create(UserCreateRequest request)
        {
            var apiurl = string.Format(Urls.UserCreate, request.ACCESS_TOKEN);

            var rtn = RequestHelper.Post<UserCreateResponse>(apiurl, request);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }

        public UserUpdateResponse Update(UserUpdateRequest request)
        {
            var apiurl = string.Format(Urls.UserUpdate, request.ACCESS_TOKEN);

            var rtn = RequestHelper.Post<UserUpdateResponse>(apiurl, request);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }

        public UserDeleteResponse Delete(int id)
        {
            var apiurl = string.Format(Urls.UserDelete, RequestHelper.GetAccessToken(), id);

            var rtn = RequestHelper.Get<UserDeleteResponse>(apiurl);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }
    }
}