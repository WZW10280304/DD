using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CYJ.DingDing.Dto;
using CYJ.DingDing.Dto.Dto;
using CYJ.DingDing.Dto.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CYJ.DingDing.Service.Http.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<TokensController> _logger;
        /// <summary>
        /// 创建静态字段，保证全局一致
        /// </summary>
        public static AccessTokenResponse AccessToken = new AccessTokenResponse();

        public ValuesController(ILogger<TokensController> logger)
        {
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.LogInformation("你访问了首页");
            _logger.LogWarning("警告信息");
            _logger.LogError("错误信息");

            string CorpID = "dingb578e1d0be14c3f135c2f4657eb6378f";// ConfigHelper.FetchCorpID();
            string CorpSecret = "p_FeZ6xm3cnnDDdcvvbFbWc9uKyimvZjzmAAJ-csDkwE5oE7XeeHY-WLtLuvWbeM";// ConfigHelper.FetchCorpSecret();
            string TokenUrl = "https://oapi.dingtalk.com/gettoken";
            string apiurl = $"{TokenUrl}?corpid={CorpID}&corpsecret={CorpSecret}";

            WebRequest request = WebRequest.Create(@apiurl);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            Encoding encode = Encoding.UTF8;
            StreamReader reader = new StreamReader(stream, encode);
            string resultJson = reader.ReadToEnd();

            AccessTokenResponse tokenResult = JsonConvert.DeserializeObject<AccessTokenResponse>(resultJson);
            if (tokenResult.ErrCode == ErrCodeEnum.OK)
            {
            }

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}
