using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CYJ.DingDing.Api.IApiService;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Infrastructure.Log;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CYJ.DingDing.Service.Http.Controllers
{
    /// <summary>
    /// 部门管理
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : BaseController
    {
        private readonly IDepartmentApiService _departmentApiService;

        public DepartmentsController(IDepartmentApiService departmentApiService)
        {
            _departmentApiService = departmentApiService;
        }

        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <param name="fetchChild">是否递归部门的全部子部门，ISV微应用固定传递false。</param>
        /// <param name="parentId">父部门id(如果不传，默认部门为根部门，根部门ID为1)</param>
        /// <returns>部门列表</returns>
        // GET: api/Departments
        [HttpGet]
        public DepartmentListResponse Get(bool fetchChild, string parentId)
        {
            var rtn = _departmentApiService.GetList(new DepartmentListRequest
            {
                FetchChild = fetchChild,
                ParentId = parentId
            });

            return rtn;
        }

        /// <summary>
        /// 获取部门详情
        /// </summary>
        /// <param name="id">部门id</param>
        /// <returns>部门详情</returns>
        // GET: api/Departments/5
        [HttpGet("{id}")]
        public DepartmentDetailResponse Get(int id)
        {
            var rtn = _departmentApiService.GetModel(id);

            return rtn;
        }

        /// <summary>
        /// 创建部门
        /// </summary>
        /// <param name="request">部门信息</param>
        /// <returns></returns>
        // POST: api/Departments
        [HttpPost]
        public DepartmentCreateResponse Post(DepartmentCreateRequest request)
        {
            var rtn = _departmentApiService.Create(request);

            return rtn;
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="id">部门id</param>
        /// <param name="request">部门信息</param>
        /// <returns></returns>
        // PUT: api/Departments/5
        [HttpPut("{id}")]
        public DepartmentUpdateResponse Put(int id, DepartmentUpdateRequest request)
        {
            var rtn = _departmentApiService.Update(id, request);

            return rtn;
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="id">部门id</param>
        /// <returns></returns>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public DepartmentDeleteResponse Delete(int id)
        {
            var rtn = _departmentApiService.Delete(id);

            return rtn;
        }

    }
}
