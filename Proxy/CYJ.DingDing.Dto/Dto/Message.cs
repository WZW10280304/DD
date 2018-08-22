using CYJ.DingDing.Dto.Dto.Base;

namespace CYJ.DingDing.Dto.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class MessageSendResponse : DingTalkResponse
    {
        /// <summary>
        /// 无效的userid
        /// </summary>
        public string InvalidUser { get; set; }

        /// <summary>
        /// 无效的部门id
        /// </summary>
        public string InvalidParty { get; set; }

        /// <summary>
        /// 因发送消息过于频繁或超量而被流控过滤后实际未发送的userid。未被限流的接收者仍会被成功发送。限流规则包括：1、给同一用户发相同内容消息一天仅允许一次；2、如果是ISV接入方式，给同一用户发消息一天不得超过50次；如果是企业接入方式，此上限为500。
        /// </summary>
        public string ForbiddenUserId { get; set; }

        /// <summary>
        /// 标识企业消息的id，字符串，最长128个字符
        /// </summary>
        public string MessageId { get; set; }

    }

    /// <summary>
    /// 发送消息
    /// </summary>
    public class MessageSendRequest
    {
        /// <summary>
        /// 员工id列表（消息接收者，多个接收者用|分隔）
        /// 示例：“user1|user2|user3”
        /// </summary>
        public string ToUser { get; set; }

        /// <summary>
        /// 部门id列表，多个接收者用|分隔。touser或者toparty 二者有一个必填，不支持递归发送，如果需要给部门下面子部门发送消息则需要查询出子部门id
        /// </summary>
        public string ToParty { get; set; }

        /// <summary>
        /// 企业应用id，这个值代表以哪个应用的名义发送消息
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// 消息类型
        /// （目前支持text、image、voice、file、link、OA、markdown消息类型）
        /// </summary>
        public string MsgType { get; set; }

        /// <summary>
        /// 文本消息内容
        /// </summary>
        public Text Text { get; set; }
    }

    /// <summary>
    /// text消息
    /// </summary>
    public class Text
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        public string Content { get; set; }
    }
}