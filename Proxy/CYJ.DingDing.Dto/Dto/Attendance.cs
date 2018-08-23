using System.Collections.Generic;
using System.Xml.Serialization;
using CYJ.DingDing.Dto.Dto.Base;

namespace CYJ.DingDing.Dto.Dto
{

    /// <summary>
    /// OapiAttendanceListResponse.
    /// </summary>
    public class AttendanceListResponse : DingTalkResponse
    {
        /// <summary>
        /// hasMore
        /// </summary>
        public bool HasMore { get; set; }

        /// <summary>
        /// recordresult
        /// </summary>
        public List<RecordResultDomain> Recordresult { get; set; }

        /// <summary>
        /// RecordresultDomain Data Structure.
        /// </summary>

        public class RecordResultDomain
        {
            /// <summary>
            /// approveId
            /// </summary>
            public long ApproveId { get; set; }

            /// <summary>
            /// baseCheckTime
            /// </summary>
            public string BaseCheckTime { get; set; }

            /// <summary>
            /// checkType
            /// </summary>
            [XmlElement("checkType")]
            public string CheckType { get; set; }

            /// <summary>
            /// groupId
            /// </summary>
            public long GroupId { get; set; }

            /// <summary>
            /// id
            /// </summary>
            public long Id { get; set; }

            /// <summary>
            /// locationResult
            /// </summary>
            public string LocationResult { get; set; }

            /// <summary>
            /// planId
            /// </summary>
            public long PlanId { get; set; }

            /// <summary>
            /// procInstId
            /// </summary>
            public string ProcInstId { get; set; }

            /// <summary>
            /// recordId
            /// </summary>
            public long RecordId { get; set; }

            /// <summary>
            /// sourceType
            /// </summary>
            public string SourceType { get; set; }

            /// <summary>
            /// timeResult
            /// </summary>
            public string TimeResult { get; set; }

            /// <summary>
            /// userCheckTime
            /// </summary>
            public string UserCheckTime { get; set; }

            /// <summary>
            /// userId
            /// </summary>
            public string UserId { get; set; }

            /// <summary>
            /// workDate
            /// </summary>
            public string WorkDate { get; set; }
        }

    }

    /// <summary>
    /// 签到数据
    /// </summary>
    public class AttendanceRecordsResponse : DingTalkResponse
    {
        public List<AttendanceRecord> Data { get; set; }
    }

    /// <summary>
    /// 签到数据
    /// </summary>
    public class AttendanceRecord
    {
        /// <summary>
        /// 成员名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 员工唯一标识ID（不可修改）
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 头像url
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 签到时间
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// 签到地址
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// 签到详细地址
        /// </summary>
        public string DetailPlace { get; set; }

        /// <summary>
        /// 签到备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 签到照片url列表
        /// </summary>
        public string ImageList { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude { get; set; }
    }
}