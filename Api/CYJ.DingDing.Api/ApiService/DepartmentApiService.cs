using CYJ.DingDing.Api.IApiService;
using CYJ.DingDing.Application.IAppService;
using CYJ.DingDing.Dto.Dto;

namespace CYJ.DingDing.Api.ApiService
{
    public class DepartmentApiService : IDepartmentApiService
    {
        private readonly IDepartmentAppService _departmentAppService;

        public DepartmentApiService(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }

        public DepartmentCreateResponse Create(DepartmentCreateRequest request)
        {
            return _departmentAppService.Create(request);
        }

        public DepartmentUpdateResponse Update(int id, DepartmentUpdateRequest request)
        {
            return _departmentAppService.Update(id, request);
        }

        public DepartmentDeleteResponse Delete(long id)
        {
            return _departmentAppService.Delete(id);
        }

        public DepartmentDetailResponse GetModel(long id)
        {
            return _departmentAppService.GetModel(id);
        }

        public DepartmentListResponse GetList(DepartmentListRequest request)
        {
            return _departmentAppService.GetList(request);
        }
    }
}