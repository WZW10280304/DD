using System;

namespace CYJ.DingDing.Sdks.DingDingSdk
{
    public class ConstVars
    {
        /// <summary>
        /// 缓存的JS票据的KEY
        /// </summary>
        public const string CACHE_JS_TICKET_KEY = "CACHE_JS_TICKET_KEY";

        /// <summary>
        /// 缓存时间
        /// </summary>
        public const int CACHE_TIME = 5000;
    }

    /// <summary>
    /// Url的Key
    /// </summary>
    public sealed class Keys
    {
        public const string corpid = "corpid";

        public const string corpsecret = "corpsecret";

        public const string department_id = "department_id";

        public const string userid = "userid";

        public const string chatid = "chatid";

        public const string access_token = "access_token";

        public const string jsapi_ticket = "jsapi_ticket";

        public const string noncestr = "noncestr";

        public const string timestamp = "timestamp";

        public const string url = "url";
    }

    /// <summary>
    /// SDK使用的URL
    /// </summary>
    public sealed class Urls
    {
        /// <summary>
        /// 获取访问票据
        /// </summary>
        public const string GetToken = "https://oapi.dingtalk.com/gettoken?corpid={0}&corpsecret={1}";  //"https://oapi.dingtalk.com/gettoken";

        #region 部门

        /// <summary>
        /// 获取部门列表
        /// </summary>
        public const string DepartmentList = "https://oapi.dingtalk.com/department/list?access_token={0}&fetch_child={1}&id={2}";

        /// <summary>
        /// 获取部门详情
        /// </summary>
        public const string DepartmentGet = "https://oapi.dingtalk.com/department/get?access_token={0}&id={1}";

        public const string DepartmentCreate = "https://oapi.dingtalk.com/department/create?access_token={0}";

        public const string DepartmentUpdate = "https://oapi.dingtalk.com/department/update?access_token={0}";

        public const string DepartmentDelete = "https://oapi.dingtalk.com/department/delete?access_token={0}&id={1}";

        #endregion

        #region  用户

        public const string UserDetailList = "https://oapi.dingtalk.com/user/list?access_token={0}&department_id={1}&offset={2}&size={3}&order={4}";

        public const string UserGet = "https://oapi.dingtalk.com/user/get?access_token={0}&userid={1}";

        public const string UserCreate = "https://oapi.dingtalk.com/user/create?access_token={0}";

        public const string UserUpdate = "https://oapi.dingtalk.com/user/update?access_token={0}";

        public const string UserDelete = "https://oapi.dingtalk.com/user/delete?access_token={0}&id={1}";

        #endregion

        #region  考勤

        /// <summary>
        /// 考勤打卡数据
        /// 该接口仅限企业接入使用，用于返回企业内员工的实际打卡结果。比如，企业给一个员工设定的排班是上午9点和下午6点各打一次卡，即使员工在这期间打了多次，该接口也只会返回两条记录，包括上午的打卡结果和下午的打卡结果
        /// POST
        /// </summary>
        public const string AttendanceList = "https://oapi.dingtalk.com/attendance/list?access_token={0}";

        /// <summary>
        /// 获得签到数据
        /// 1、目前最多获取1000人以内的签到数据，如果所传部门ID及其子部门下的user超过1000，会报错
        /// 说明：开始时间和结束时间的间隔不能大于45 天
        /// GET
        /// </summary>
        public const string AttendanceRecord =
            "https://oapi.dingtalk.com/checkin/record?access_token={0}&" +
            "department_id={1}&start_time={2}&end_time={3}&offset={4}&size={5}&order={6}";

        #endregion

        #region  审批流



        #endregion

        #region  消息

        /// <summary>
        /// 发送消息
        /// </summary>
        public const string MessageSend = "https://oapi.dingtalk.com/message/send?access_token={0}";

        #endregion

        /// <summary>
        /// 创建会话
        /// </summary>
        public const string chat_create = "https://oapi.dingtalk.com/chat/create";
        /// <summary>
        /// 获取会话信息
        /// </summary>
        public const string chat_get = "https://oapi.dingtalk.com/chat/get";
        /// <summary>
        /// 发送会话消息
        /// </summary>
        public const string chat_send = "https://oapi.dingtalk.com/chat/send";
        /// <summary>
        /// 更新会话信息
        /// </summary>
        public const string chat_update = "https://oapi.dingtalk.com/chat/update";

        /// <summary>
        /// 用户列表
        /// </summary>
        public const string user_list = "https://oapi.dingtalk.com/user/list";
        /// <summary>
        /// 用户详情
        /// </summary>
        public const string user_get = "https://oapi.dingtalk.com/user/get";

        /// <summary>
        /// 获取JSAPI的票据
        /// </summary>
        public const string get_jsapi_ticket = "https://oapi.dingtalk.com/get_jsapi_ticket";

    }

}
