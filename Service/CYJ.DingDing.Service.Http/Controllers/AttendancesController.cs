using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Dto.Enum;
using CYJ.DingDing.Infrastructure.Exception;
using CYJ.DingDing.Infrastructure.Treasury;
using CYJ.DingDing.Sdks.DingDingSdk;
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CYJ.DingDing.Service.Http.Controllers
{
    /// <summary>
    /// 考勤管理
    /// </summary>
    public class AttendancesController : BaseController
    {
        ///// <summary>
        ///// 按天查询企业考勤排班全量信息，使用分页功能
        ///// </summary>
        ///// <param name="workDate">排班时间，只取年月日部分</param>
        ///// <param name="offset">偏移位置</param>
        ///// <param name="size">分页大小，最大200</param>
        ///// <returns></returns>
        //// GET: api/Attendances
        //[HttpGet]
        //public SmartworkAttendsListscheduleResponse.DingOpenResultDomain Get(DateTime? workDate, long? offset, long? size)
        //{
        //    IDingTalkClient client = new DefaultDingTalkClient("https://eco.taobao.com/router/rest");
        //    SmartworkAttendsListscheduleRequest req = new SmartworkAttendsListscheduleRequest();
        //    req.WorkDate = workDate;
        //    req.Offset = offset;
        //    req.Size = size;
        //    SmartworkAttendsListscheduleResponse rsp = client.Execute(req, RequestHelper.GetAccessToken());

        //    return rsp.Result;
        //}

        /// <summary>
        /// 获得签到数据
        /// （目前最多获取1000人以内的签到数据，如果所传部门ID及其子部门下的user超过1000）
        /// </summary>
        /// <param name="department_id">部门id（1 表示根部门）</param>
        /// <param name="start_time">开始时间，精确到毫秒，注意字段的位数 例：1520956800000</param>
        /// <param name="end_time">结束时间，精确到毫秒，注意字段的位数 例：1520956800000（默认为当前时间）</param>
        /// <param name="offset">支持分页查询，与size 参数同时设置时才生效，此参数代表偏移量，从0 开始</param>
        /// <param name="size">支持分页查询，与offset 参数同时设置时才生效，此参数代表分页大小，最大100</param>
        /// <param name="order">排序，asc 为正序，desc 为倒序</param>
        // POST: api/Attendances
        [HttpGet]
        [Route("Record")]
        public AttendanceRecordsResponse GetRecord(string department_id, long start_time, long end_time, long offset, int size, string order)
        {
            var apiurl = string.Format(Urls.AttendanceRecord, RequestHelper.GetAccessToken(),
                department_id, start_time, end_time, offset, size, order);

            var rtn = RequestHelper.Get<AttendanceRecordsResponse>(apiurl);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }

        /// <summary>
        /// 获取考勤打卡数据
        /// （即使员工在这期间打了多次，该接口也只会返回两条记录，包括上午的打卡结果和下午的打卡结果）
        /// </summary>
        /// <param name="workDateFrom">查询考勤打卡记录的起始工作日 yyyy-MM-dd hh:mm:ss</param>
        /// <param name="workDateTo">查询考勤打卡记录的结束工作日 yyyy-MM-dd hh:mm:ss</param>
        /// <param name="userIdList">员工在企业内的UserID列表，企业用来唯一标识用户的字段</param>
        /// <param name="offset">表示获取考勤数据的起始点，第一次传0，如果还有多余数据，下次获取传的offset值为之前的offset+limit</param>
        /// <param name="limit">表示获取考勤数据的条数，最大不能超过50条</param>
        /// <returns></returns>
        // GET: api/Attendances/5
        [HttpGet]
        [Route("List")]
        public AttendanceListResponse GetList(string workDateFrom, string workDateTo, List<string> userIdList, long offset, long limit)
        {
            var apiurl = string.Format(Urls.AttendanceList, RequestHelper.GetAccessToken());

            var request = new OapiAttendanceListRequest
            {
                WorkDateFrom = workDateFrom,
                WorkDateTo = workDateTo,
                UserIdList = userIdList,
                Offset = offset,
                Limit = limit
            };

            //var rtn = RequestHelper.Post<OapiAttendanceListResponse>(apiurl, request);
            //if (!String.Equals(rtn.ErrCode, ErrCodeEnum.OK.ToString(), StringComparison.CurrentCultureIgnoreCase))
            var rtn = RequestHelper.Post<AttendanceListResponse>(apiurl, request);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }
    }
}
