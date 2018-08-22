using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Dto.Enum;
using CYJ.DingDing.Infrastructure.Exception;
using CYJ.DingDing.Infrastructure.Treasury;
using CYJ.DingDing.Sdks.DingDingSdk;
using DingTalk.Api.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CYJ.DingDing.Service.Http.Controllers
{
    /// <summary>
    /// 消息管理
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : BaseController
    {
        /// <summary>
        /// 企业通知消息主要用来做企业通知，主要是以企业名义通知到个人，例如审批通知、任务通知、工作项通知等
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public MessageSendResponse Notice(MessageSendRequest request)
        {
            var apiurl = string.Format(Urls.MessageSend, RequestHelper.GetAccessToken());

            var rtn = RequestHelper.Post<MessageSendResponse>(apiurl, request);
            if (rtn.ErrCode != ErrCodeEnum.OK)
            {
                throw new ApiException(ApiCodeEnum.Error, rtn.ErrMsg);
            }

            return rtn;
        }
    }
}
