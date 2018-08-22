using System.Collections.Generic;
using CYJ.DingDing.Dto.Dto.Base;

namespace CYJ.DingDing.Dto.Dto
{
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