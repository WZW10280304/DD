using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.chat.update
    /// </summary>
    public class OapiChatUpdateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiChatUpdateResponse>
    {
        /// <summary>
        /// 添加外部联系人成员列表
        /// </summary>
        public List<string> AddExtidlist { get; set; }

        /// <summary>
        /// 添加成员列表
        /// </summary>
        public List<string> AddUseridlist { get; set; }

        /// <summary>
        /// 群会话id
        /// </summary>
        public string Chatid { get; set; }

        /// <summary>
        /// 删除外部联系人成员列表
        /// </summary>
        public List<string> DelExtidlist { get; set; }

        /// <summary>
        /// 删除成员列表
        /// </summary>
        public List<string> DelUseridlist { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 群主的userId
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// 群主类型，emp：企业员工，ext：外部联系人
        /// </summary>
        public string OwnerType { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.chat.update";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("add_extidlist", TopUtils.ObjectToJson(this.AddExtidlist));
            parameters.Add("add_useridlist", TopUtils.ObjectToJson(this.AddUseridlist));
            parameters.Add("chatid", this.Chatid);
            parameters.Add("del_extidlist", TopUtils.ObjectToJson(this.DelExtidlist));
            parameters.Add("del_useridlist", TopUtils.ObjectToJson(this.DelUseridlist));
            parameters.Add("name", this.Name);
            parameters.Add("owner", this.Owner);
            parameters.Add("ownerType", this.OwnerType);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateMaxListSize("add_extidlist", this.AddExtidlist, 20);
            RequestValidator.ValidateMaxListSize("add_useridlist", this.AddUseridlist, 20);
            RequestValidator.ValidateMaxListSize("del_extidlist", this.DelExtidlist, 20);
            RequestValidator.ValidateMaxListSize("del_useridlist", this.DelUseridlist, 20);
        }

        #endregion
    }
}
