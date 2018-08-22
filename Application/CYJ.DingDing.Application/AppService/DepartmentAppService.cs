using System.Net;
using System.Net.Http;
using CYJ.DingDing.Application.IAppService;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Dto.Dto.Base;
using CYJ.DingDing.Dto.Enum;
using CYJ.DingDing.Infrastructure.Exception;
using CYJ.DingDing.Infrastructure.Treasury;
using CYJ.DingDing.Sdks.DingDingSdk;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace CYJ.DingDing.Application.AppService
{
    public class DepartmentAppService : IDepartmentAppService
    {
        public DepartmentCreateResponse Create(DepartmentCreateRequest request)
        {
            var apiurl = string.Format(Urls.DepartmentCreate, request.ACCESS_TOKEN);

            var rtn = RequestHelper.Post<DepartmentCreateResponse>(apiurl, request);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }

        public DepartmentUpdateResponse Update(int id, DepartmentUpdateRequest request)
        {
            var apiurl = string.Format(Urls.DepartmentUpdate, request.ACCESS_TOKEN);

            var rtn = RequestHelper.Post<DepartmentUpdateResponse>(apiurl, request);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }

        public DepartmentDeleteResponse Delete(long id)
        {
            var accessToken = RequestHelper.GetAccessToken();
            var apiurl = string.Format(Urls.DepartmentDelete, accessToken, id);

            var rtn = RequestHelper.Get<DepartmentDeleteResponse>(apiurl);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }

        public DepartmentDetailResponse GetModel(long id)
        {
            if (id <= 0)
            {
                throw new ApiException(ApiCodeEnum.InvalidId, "无效的Id");
            }

            var accessToken = RequestHelper.GetAccessToken();
            var tokenUrl = Urls.DepartmentGet;
            var apiurl = string.Format(tokenUrl, accessToken, id);

            var resultJson = RequestHelper.Get(apiurl);

            var rtn = JsonConvert.DeserializeObject<DepartmentDetailResponse>(resultJson);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }

        public DepartmentListResponse GetList(DepartmentListRequest request)
        {
            var tokenUrl = Urls.DepartmentList;
            var apiurl = string.Format(tokenUrl, request.ACCESS_TOKEN, request.FetchChild, request.ParentId);

            var resultJson = RequestHelper.Get(apiurl);

            var rtn = JsonConvert.DeserializeObject<DepartmentListResponse>(resultJson);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }
    }
}