using System;
using System.Collections.Generic;
using System.Text;
using CYJ.DingDing.Dto.Dto;

namespace CYJ.DingDing.Application.IAppService
{
    public interface IDepartmentAppService
    {
        DepartmentCreateResponse Create(DepartmentCreateRequest request);

        DepartmentUpdateResponse Update(int id, DepartmentUpdateRequest request);

        DepartmentDeleteResponse Delete(long id);

        DepartmentDetailResponse GetModel(long id);

        DepartmentListResponse GetList(DepartmentListRequest request);
    }
}
