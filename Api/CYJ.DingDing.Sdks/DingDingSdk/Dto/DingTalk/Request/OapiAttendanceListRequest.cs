using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.attendance.list
    /// </summary>
    public class OapiAttendanceListRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiAttendanceListResponse>
    {
        /// <summary>
        /// 表示获取考勤数据的条数，最大不能超过50条
        /// </summary>
        public Nullable<long> Limit { get; set; }

        /// <summary>
        /// 表示获取考勤数据的起始点，第一次传0，如果还有多余数据，下次获取传的offset值为之前的offset+limit
        /// </summary>
        public Nullable<long> Offset { get; set; }

        /// <summary>
        /// ["员工UserId列表"], 必填，与offset和limit配合使用，不传表示分页获取全员的数据
        /// </summary>
        public List<string> UserIdList { get; set; }

        /// <summary>
        /// 查询考勤打卡记录的起始工作日 yyyy-MM-dd hh:mm:ss
        /// </summary>
        public string WorkDateFrom { get; set; }

        /// <summary>
        /// 查询考勤打卡记录的结束工作日 yyyy-MM-dd hh:mm:ss
        /// </summary>
        public string WorkDateTo { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.attendance.list";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("limit", this.Limit);
            parameters.Add("offset", this.Offset);
            parameters.Add("userIdList", TopUtils.ObjectToJson(this.UserIdList));
            parameters.Add("workDateFrom", this.WorkDateFrom);
            parameters.Add("workDateTo", this.WorkDateTo);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
        }

        #endregion
    }
}
