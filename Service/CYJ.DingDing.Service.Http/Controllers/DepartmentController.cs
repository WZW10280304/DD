using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Infrastructure.Config;
using CYJ.DingDing.Sdks.DingDingSdk;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CYJ.DingDing.Service.Http.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        // GET: api/Departments
        [HttpGet]
        public DepartmentListResponse Get(string token)
        {
            string apiurl = FormatApiUrlWithToken(Urls.DepartmentList, token);
            var result = Analyze.Get<DepartmentListResponse>(apiurl);
            return result;
        }

        public String FormatApiUrlWithToken(String url, string token)
        {
            string apiurl = $"{url}?{Keys.access_token}={token}";
            return apiurl;
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="toUser">目标用户</param>
        /// <param name="toParty">目标部门.当toParty和toUser同时指定时，以toParty来发送。</param>
        /// <param name="content">消息文本</param>
        /// <returns></returns>
        private SendMessageResult SendTextMsg(string toUser, string toParty, string content, string token)
        {
            var txtmsg = new
            {
                touser = toUser,
                toparty = toParty,
                msgtype = "",//MsgType.text.ToString(),
                agentid = "",//ConfigHelper.FetchAgentID(),
                text = new
                {
                    content = content
                }
            };
            string apiurl = FormatApiUrlWithToken(Urls.message_send, token);
            string json = JsonConvert.SerializeObject(txtmsg);
            var result = Analyze.Post<SendMessageResult>(apiurl, json);
            return result;
        }

    }
}
