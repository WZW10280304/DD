using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CYJ.DingDing.Api.IApiService;
using CYJ.DingDing.Dto.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CYJ.DingDing.Service.Http.Controllers
{
    /// <summary>
    /// 用户管理
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController
    {
        private readonly IUserApiService _userApiService;

        public UsersController(IUserApiService userApiService)
        {
            _userApiService = userApiService;
        }

        /// <summary>
        /// 获取部门成员（详情）
        /// </summary>
        /// <param name="departmentId">获取的部门id</param>
        /// <param name="offset">支持分页查询，与size参数同时设置时才生效，此参数代表偏移量</param>
        /// <param name="size">支持分页查询，与offset参数同时设置时才生效，此参数代表分页大小，最大100</param>
        /// <param name="order"> 支持分页查询，部门成员的排序规则，默认不传是按自定义排序；
        /// entry_asc代表按照进入部门的时间升序，
        /// entry_desc代表按照进入部门的时间降序，
        /// modify_asc代表按照部门信息修改时间升序，
        /// modify_desc代表按照部门信息修改时间降序，
        /// custom代表用户定义(未定义时按照拼音)排序</param>
        /// <returns>成员详情列表</returns>
        // GET: api/Users
        [HttpGet]
        public UserListResponse GetList(long departmentId, long offset, int size, string order)
        {
            var request = new UserListRequest()
            {
                ACCESS_TOKEN = Request.Query["access_token"],
                DepartmentId = departmentId,
                Offset = offset,
                Size = size,
                Order = order
            };

            return _userApiService.GetList(request);
        }

        /// <summary>
        /// 获取用户详情
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>用户详细信息</returns>
        // GET: api/Users/5
        [HttpGet("{id}")]
        public UserDetailResponse Get(int id)
        {
            return _userApiService.GetModel(id);
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="request">用户信息</param>
        /// <returns></returns>
        // POST: api/Users
        [HttpPost]
        public UserCreateResponse Post(UserCreateRequest request)
        {
            return _userApiService.Create(request);
        }

        /// <summary>
        ///修改用户
        /// </summary>
        /// <param name="request">用户信息</param>
        // PUT: api/Users/5
        [HttpPut("{id}")]
        public UserUpdateResponse Put(UserUpdateRequest request)
        {
            return _userApiService.Update(request);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">用户Id</param>
        /// <returns></returns>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public UserDeleteResponse Delete(int id)
        {
            return _userApiService.Delete(id);
        }
    }
}
