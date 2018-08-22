using System;
using System.Collections.Generic;
using System.Text;
using CYJ.DingDing.Dto.Dto.Base;
using CYJ.DingDing.Dto.Enum;

namespace CYJ.DingDing.Dto.Dto
{
    /// <summary>
    /// 创建部门对象
    /// </summary>
    public class DepartmentCreateRequest : BaseRequest
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 父部门id，根部门为1
        /// </summary>
        public string Parentid { get; set; }

        /// <summary>
        ///  在父部门中的次序值
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// 是否同步创建一个关联此部门的企业群, true表示是, false表示不是
        /// </summary>
        public bool CreateDeptGroup { get; set; }

        /// <summary>
        ///  是否隐藏部门, true表示隐藏, false表示显示
        /// </summary>
        public bool DeptHiding { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他部门列表，如果部门隐藏，则此值生效，取值为其他的部门id组成的的字符串，使用|符号进行分割
        /// </summary>
        public string DeptPermits { get; set; }

        /// <summary>
        /// 可以查看指定隐藏部门的其他人员列表，如果部门隐藏，则此值生效，取值为其他的人员userid组成的的字符串，使用|符号进行分割
        /// </summary>
        public string UserPermits { get; set; }

        /// <summary>
        /// 是否本部门的员工仅可见员工自己, 为true时，本部门员工默认只能看到员工自己
        /// </summary>
        public bool OuterDept { get; set; }

        /// <summary>
        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见部门，值为部门id组成的的字符串，使用|符号进行分割
        /// </summary>
        public string OuterPermitDepts { get; set; }

        /// <summary>
        /// 本部门的员工仅可见员工自己为true时，可以配置额外可见人员，值为userid组成的的字符串，使用| 符号进行分割
        /// </summary>
        public string OuterPermitUsers { get; set; }

        /// <summary>
        /// 部门标识字段，开发者可用该字段来唯一标识一个部门，并与钉钉外部通讯录里的部门做映射
        /// </summary>
        public string SourceIdentifier { get; set; }
    }

    /// <summary>
    /// 修改部门对象
    /// </summary>
    public class DepartmentUpdateRequest : DepartmentCreateRequest
    {
        /// <summary>
        /// 当群已经创建后，是否有新人加入部门会自动加入该群, true表示是, false表示不是
        /// </summary>
        public bool AutoAddUser { get; set; }

        /// <summary>
        /// 部门的主管列表,取值为由主管的userid组成的字符串，不同的userid使用|符号进行分割
        /// </summary>
        public string DeptManagerUseridList { get; set; }

        /// <summary>
        /// 企业群群主
        /// </summary>
        public string OrgDeptOwner { get; set; }
    }

    /// <summary>
    /// 请求部门列表对象
    /// </summary>
    public class DepartmentListRequest : BaseRequest
    {
        /// <summary>
        /// 是否递归部门的全部子部门，ISV微应用固定传递false。
        /// </summary>
        public bool FetchChild { get; set; }

        /// <summary>
        /// 父部门id(如果不传，默认部门为根部门，根部门ID为1)
        /// </summary>
        public string ParentId { get; set; }
    }

    /// <summary>
    /// 创建部门结果
    /// </summary>
    public class DepartmentCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 部门id
        /// </summary>
        public long Id { get; set; }
    }

    /// <summary>
    /// 修改部门结果
    /// </summary>
    public class DepartmentUpdateResponse : DingTalkResponse
    {
        /// <summary>
        /// 部门id
        /// </summary>
        public long Id { get; set; }
    }

    /// <summary>
    /// 删除部门结果
    /// </summary>
    public class DepartmentDeleteResponse : DingTalkResponse
    {

    }

    /// <summary>
    /// 部门列表结果
    /// </summary>
    public class DepartmentListResponse : DingTalkResponse
    {
        /// <summary>
        /// 部门信息列表
        /// </summary>
        public List<DepartmentResponse> Department { get; set; }
    }

    /// <summary>
    /// 部门信息
    /// </summary>
    public class DepartmentResponse : DingTalkResponse
    {
        /// <summary>
        /// 部门id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 父部门id，根部门为1
        /// </summary>
        public string Parentid { get; set; }

        /// <summary>
        /// 是否同步创建一个关联此部门的企业群, true表示是, false表示不是
        /// </summary>
        public bool CreateDeptGroup { get; set; }

        /// <summary>
        /// 当群已经创建后，是否有新人加入部门会自动加入该群, true表示是, false表示不是
        /// </summary>
        public bool AutoAddUser { get; set; }
    }

    /// <summary>
    /// 部门详情
    /// </summary>
    public class DepartmentDetailResponse : DepartmentUpdateRequest
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public ErrCodeEnum ErrCode { get; set; } = ErrCodeEnum.Unknown;

        /// <summary>
        /// 错误消息
        /// </summary>
        public string ErrMsg { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        public long Id { get; set; }
    }
}
