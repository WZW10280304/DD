using System;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.service.get_agent
    /// </summary>
    public class OapiServiceGetAgentRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiServiceGetAgentResponse>
    {
        /// <summary>
        /// agentid
        /// </summary>
        public string Agentid { get; set; }

        /// <summary>
        /// auth_corpid
        /// </summary>
        public string AuthCorpid { get; set; }

        /// <summary>
        /// permanent_code
        /// </summary>
        public string PermanentCode { get; set; }

        /// <summary>
        /// suite_key
        /// </summary>
        public string SuiteKey { get; set; }

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.service.get_agent";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agentid", this.Agentid);
            parameters.Add("auth_corpid", this.AuthCorpid);
            parameters.Add("permanent_code", this.PermanentCode);
            parameters.Add("suite_key", this.SuiteKey);
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
