using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using CYJ.DingDing.Dto.Dto.Base;

namespace CYJ.DingDing.Dto.Dto
{
    public class ProcessListResponse : DingTalkResponse
    {
        /// <summary>
        /// result
        /// </summary>
        public DingOpenResultDomain Result { get; set; }

        /// <summary>
        /// DingOpenResultDomain Data Structure.
        /// </summary>

        public class DingOpenResultDomain
        {
            /// <summary>
            /// result
            /// </summary>
            public PageResultDomain Result { get; set; }
        }


        /// <summary>
        /// FormComponentValueVoDomain Data Structure.
        /// </summary>
        public class FormComponentValueVoDomain
        {
            /// <summary>
            /// 表单标签名
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// 表单标签值
            /// </summary>
            public string Value { get; set; }
        }

        /// <summary>
        /// ProcessInstanceTopVoDomain Data Structure.
        /// </summary>

        public class ProcessInstanceTopVoDomain
        {
            /// <summary>
            /// 审批人列表
            /// </summary>
            public List<string> ApproverUseridList { get; set; }

            /// <summary>
            /// 流程实例业务编号
            /// </summary>
            public string BusinessId { get; set; }

            /// <summary>
            /// 抄送人列表
            /// </summary>
            public List<string> CcUseridList { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            public string CreateTime { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            public string FinishTime { get; set; }

            /// <summary>
            /// 审批表单变量组
            /// </summary>
            public List<FormComponentValueVoDomain> FormComponentValues { get; set; }

            /// <summary>
            /// 发起人部门id
            /// </summary>
            public string OriginatorDeptId { get; set; }

            /// <summary>
            /// 发起人userid
            /// </summary>
            public string OriginatorUserid { get; set; }

            /// <summary>
            /// 审批实例id
            /// </summary>
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// 审批结果，分为agree和refuse
            /// </summary>
            public string ProcessInstanceResult { get; set; }

            /// <summary>
            /// 审批状态，分为NEW（刚创建）|RUNNING（运行中）|TERMINATED（被终止）|COMPLETED（完成）|CANCELED（取消）
            /// </summary>
            public string Status { get; set; }

            /// <summary>
            /// 标题
            /// </summary>
            public string Title { get; set; }
        }

        /// <summary>
        /// PageResultDomain Data Structure.
        /// </summary>

        public class PageResultDomain
        {
            /// <summary>
            /// list
            /// </summary>
            public List<ProcessInstanceTopVoDomain> List { get; set; }

            /// <summary>
            /// 表示下次查询的游标，当返回结果没有该字段时表示没有更多数据了
            /// </summary>
            public long NextCursor { get; set; }
        }

    }
}