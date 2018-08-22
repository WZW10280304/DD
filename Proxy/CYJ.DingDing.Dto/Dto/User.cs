using System;
using System.Collections.Generic;
using System.Text;
using CYJ.DingDing.Dto.Dto.Base;
using CYJ.DingDing.Dto.Enum;

namespace CYJ.DingDing.Dto.Dto
{
    /// <summary>
    /// 创建用户对象
    /// </summary>
    public class UserCreateRequest : BaseRequest
    {
        /// <summary>
        /// 员工唯一标识ID（不可修改），企业内必须唯一。长度为1~64个字符，如果不传，服务器将自动生成一个userid
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 成员名称。长度为1~64个字符
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数组类型，数组里面值为整型，成员所属部门id列表；格式“ [1,2] ”
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 在对应的部门中的排序, Map结构的json字符串, key是部门的Id, value是人员在这个部门的排序值
        /// 示例：“ {1:10} ”
        /// </summary>
        public string OrderInDepts { get; set; }

        /// <summary>
        /// 职位信息。长度为0~64个字符
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 手机号码，企业内必须唯一，不可重复
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 分机号，长度为0~50个字符，企业内必须唯一，不可重复
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 办公地点，长度为0~50个字符
        /// </summary>
        public string WorkPlace { get; set; }

        /// <summary>
        /// 备注，长度为0~1000个字符
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 邮箱。长度为0~64个字符。企业内必须唯一，不可重复
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 员工的企业邮箱，员工的企业邮箱已开通，才能增加此字段， 否则会报错
        /// </summary>
        public string OrgEmail { get; set; }

        /// <summary>
        /// 员工工号。对应显示到OA后台和客户端个人资料的工号栏目。长度为0~64个字符
        /// </summary>
        public string Jobnumber { get; set; }

        /// <summary>
        /// 是否号码隐藏, true表示隐藏, false表示不隐藏。隐藏手机号后，手机号在个人资料页隐藏，但仍可对其发DING、发起钉钉免费商务电话。
        /// </summary>
        public bool IsHide { get; set; }

        /// <summary>
        /// 是否高管模式，true表示是，false表示不是。开启后，手机号码对所有员工隐藏。普通员工无法对其发DING、发起钉钉免费商务电话。高管之间不受影响。
        /// </summary>
        public bool IsSenior { get; set; }

        /// <summary>
        /// 扩展属性，可以设置多种属性(但手机上最多只能显示10个扩展属性，具体显示哪些属性，请到OA管理后台->设置->通讯录信息设置和OA管理后台->设置->手机端显示信息设置)
        /// 格式：{"爱好":"旅游","年龄":"24"}
        /// </summary>
        public string Extattr { get; set; }

    }

    /// <summary>
    /// 修改用户对象
    /// </summary>
    public class UserUpdateRequest : UserCreateRequest
    {
    }

    /// <summary>
    /// 请求用户列表对象
    /// </summary>
    public class UserListRequest : BaseRequest
    {
        /// <summary>
        /// 获取的部门id
        /// </summary>
        public long DepartmentId { get; set; }

        /// <summary>
        /// 支持分页查询，与size参数同时设置时才生效，此参数代表偏移量
        /// </summary>
        public long Offset { get; set; }

        /// <summary>
        /// 支持分页查询，与offset参数同时设置时才生效，此参数代表分页大小，最大100
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 支持分页查询，部门成员的排序规则，默认不传是按自定义排序；
        /// entry_asc代表按照进入部门的时间升序，
        /// entry_desc代表按照进入部门的时间降序，
        /// modify_asc代表按照部门信息修改时间升序，
        /// modify_desc代表按照部门信息修改时间降序，
        /// custom代表用户定义(未定义时按照拼音)排序
        /// </summary>
        public string Order { get; set; }
    }

    /// <summary>
    /// 创建用户结果
    /// </summary>
    public class UserCreateResponse : DingTalkResponse
    {
        /// <summary>
        /// 员工唯一标识
        /// </summary>
        public string Userid { get; set; }
    }

    /// <summary>
    /// 修改用户结果
    /// </summary>
    public class UserUpdateResponse : DingTalkResponse
    {
    }

    /// <summary>
    /// 删除用户结果
    /// </summary>
    public class UserDeleteResponse : DingTalkResponse
    {

    }

    /// <summary>
    /// 用户列表结果
    /// </summary>
    public class UserListResponse : DingTalkResponse
    {
        /// <summary>
        /// 在分页查询时返回，代表是否还有下一页更多数据
        /// </summary>
        public bool HasMore { get; set; }
    }

    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserResponse : UserCreateRequest
    {
        /// <summary>
        /// 在当前isv全局范围内唯一标识一个用户的身份,用户无法修改
        /// </summary>
        public string Unionid { get; set; }

        /// <summary>
        /// 是否为企业的管理员, true表示是, false表示不是
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// 是否为企业的老板, true表示是, false表示不是（【设置负责人】：主管理员登陆钉钉手机客户端 -【通讯录】-【企业名后面的管理】-【企业通讯录】-【负责人设置】进行添加则可。）
        /// </summary>
        public bool IsBoss { get; set; }

        /// <summary>
        /// 是否是部门的主管, true表示是, false表示不是
        /// </summary>
        public bool IsLeader { get; set; }

        /// <summary>
        /// 是否已经激活, true表示已激活, false表示未激活
        /// </summary>
        public bool Active { get; set; }

    }

    /// <summary>
    /// 用户详情
    /// </summary>
    public class UserDetailResponse : UserUpdateRequest
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
        /// 在当前isv全局范围内唯一标识一个用户的身份,用户无法修改
        /// </summary>
        public string Unionid { get; set; }

        /// <summary>
        /// 在本 服务窗运营服务商 范围内,唯一标识关注者身份的id（不可修改）
        /// </summary>
        public string Openid { get; set; }

        /// <summary>
        /// 角色信息（ISV不可见），json数组格式
        /// </summary>
        public List<UserRole> Roles { get; set; }

        /// <summary>
        /// 是否已经激活, true表示已激活, false表示未激活
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// 是否为企业的管理员, true表示是, false表示不是
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// 在对应的部门中是否为主管, Map结构的json字符串, key是部门的Id, value是人员在这个部门中是否为主管, true表示是, false表示不是
        /// </summary>
        public string IsLeaderInDepts { get; set; }

        /// <summary>
        /// 是否为企业的老板, true表示是, false表示不是（【设置负责人】：主管理员登陆钉钉手机客户端 -【通讯录】-【企业名后面的管理】-【企业通讯录】-【负责人设置】进行添加则可。）
        /// </summary>
        public bool IsBoss { get; set; }

        /// <summary>
        /// 入职时间（时间戳）
        /// </summary>
        public long HiredDate { get; set; }

        /// <summary>
        /// 头像url
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 手机号码区号
        /// </summary>
        public string StateCode { get; set; }
    }

    /// <summary>
    /// 用户角色
    /// </summary>
    public class UserRole
    {
        /// <summary>
        /// 角色id（ISV不可见）
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 角色名称（ISV不可见）
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 角色分组名称（ISV不可见）
        /// </summary>
        public string GroupName { get; set; }
    }
}
