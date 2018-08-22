using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CYJ.DingDing.Dto.Enum;
using CYJ.DingDing.Infrastructure.Exception;
using CYJ.DingDing.Infrastructure.Treasury;
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CYJ.DingDing.Service.Http.Controllers
{
    /// <summary>
    /// 审批流
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProcesssController : BaseController
    {
        /// <summary>
        /// 分页获取该审批流对应的审批实例
        /// </summary>
        /// <param name="process_code">流程模板唯一标识，可在oa后台编辑审批表单部分查询</param>
        /// <param name="start_time">审批实例开始时间，毫秒级</param>
        /// <param name="end_time">审批实例结束时间，毫秒级，默认取当前值</param>
        /// <param name="size">分页参数，每页大小，最多传10</param>
        /// <param name="cursor">分页查询的游标，最开始传0，后续传返回参数中的next_cursor值</param>
        /// <param name="userid_list">发起人用户id列表</param>
        /// <returns></returns>
        // GET: api/Processs
        [HttpGet]
        public SmartworkBpmsProcessinstanceListResponse.PageResultDomain Get(string process_code, long start_time, long end_time, long size, long cursor, string userid_list)
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://eco.taobao.com/router/rest");
            SmartworkBpmsProcessinstanceListRequest req = new SmartworkBpmsProcessinstanceListRequest();
            req.ProcessCode = process_code;
            req.StartTime = start_time;
            req.EndTime = end_time;
            req.Size = size;
            req.Cursor = cursor;
            req.UseridList = userid_list;
            SmartworkBpmsProcessinstanceListResponse rsp = client.Execute(req, RequestHelper.GetAccessToken());

            if (!rsp.Result.Success)
            {
                throw new ApiException(ApiCodeEnum.Error, rsp.Result.ErrorMsg);
            }

            return rsp.Result.Result;
        }

        /// <summary>
        /// 获取单个审批实例详情
        /// </summary>
        /// <param name="id">审批实例id</param>
        /// <returns></returns>
        // GET: api/Processs/5
        [HttpGet("{id}")]
        public SmartworkBpmsProcessinstanceGetResponse.ProcessInstanceTopVoDomain Get(string id)
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://eco.taobao.com/router/rest");
            SmartworkBpmsProcessinstanceGetRequest req = new SmartworkBpmsProcessinstanceGetRequest();
            req.ProcessInstanceId = id;
            SmartworkBpmsProcessinstanceGetResponse rsp = client.Execute(req, RequestHelper.GetAccessToken());

            if (!rsp.Result.Success)
            {
                throw new ApiException(ApiCodeEnum.Error, rsp.Result.ErrorMsg);
            }

            return rsp.Result.ProcessInstance;
        }

        /// <summary>
        /// 获取待我审批数量
        /// </summary>
        /// <param name="userid">用户id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("PendingCount")]
        public long GetPendingCount(string userid)
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/process/gettodonum");
            OapiProcessGettodonumRequest req = new OapiProcessGettodonumRequest();
            req.Userid = userid;
            OapiProcessGettodonumResponse rsp = client.Execute(req, RequestHelper.GetAccessToken());

            if (rsp.Errcode != 0)
            {
                throw new ApiException(ApiCodeEnum.Error, rsp.ErrMsg);
            }

            return rsp.Count;
        }

        /// <summary>
        /// 发起审批实例
        /// </summary>
        /// <param name="request"></param>
        /// <returns>审批实例id</returns>
        // POST: api/Processs
        [HttpPost]
        public string Post(SmartworkBpmsProcessinstanceCreateRequest request)
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://eco.taobao.com/router/rest");
            SmartworkBpmsProcessinstanceCreateRequest req = new SmartworkBpmsProcessinstanceCreateRequest();
            req.AgentId = request.AgentId;
            req.ProcessCode = request.ProcessCode;
            req.OriginatorUserId = request.OriginatorUserId;
            req.DeptId = request.DeptId;
            req.Approvers = request.Approvers;
            req.CcList = request.CcList;
            req.CcPosition = request.CcPosition;
            List<SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain> list2 = new List<SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain>();

            var tmp =
                JsonConvert.DeserializeObject<List<OapiProcessinstanceCreateRequest.FormComponentValueVoDomain>>(request
                    .FormComponentValues);
            tmp?.ForEach(i =>
            {
                list2.Add(new SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain
                {
                    Name = i.Name,
                    Value = i.Value,
                    ExtValue = i.ExtValue
                });
            });

            req.FormComponentValues_ = list2;
            SmartworkBpmsProcessinstanceCreateResponse rsp = client.Execute(req, RequestHelper.GetAccessToken());

            if (!rsp.Result.IsSuccess)
            {
                throw new ApiException(ApiCodeEnum.Error, rsp.Result.ErrorMsg);
            }

            return rsp.Result.ProcessInstanceId;
        }

        /// <summary>
        /// 更新审批流
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        // PUT: api/Processs/5
        [HttpPut]
        public bool Put(SmartworkBpmsProcessSyncRequest request)
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://eco.taobao.com/router/rest");
            SmartworkBpmsProcessSyncRequest req = new SmartworkBpmsProcessSyncRequest();
            req.AgentId = request.AgentId;
            req.SrcProcessCode = request.SrcProcessCode;
            req.TargetProcessCode = request.TargetProcessCode;
            req.BizCategoryId = request.BizCategoryId;
            req.ProcessName = request.ProcessName;
            SmartworkBpmsProcessSyncResponse rsp = client.Execute(req, RequestHelper.GetAccessToken());

            if (!rsp.Result.Success)
            {
                throw new ApiException(ApiCodeEnum.Error, rsp.Result.ErrorMsg);
            }

            return rsp.Result.Success;
        }

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
