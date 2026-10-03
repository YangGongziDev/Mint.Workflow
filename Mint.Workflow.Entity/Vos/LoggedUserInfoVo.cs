using JadeFramework.Core.Domain.Entities;

namespace Mint.Workflow.Entity.Vos;

/// <summary>
/// 系统用户(封装Cookie中的用户信息
/// </summary>
public class LoggedUserInfoVo {
	
	/// <summary>
	/// 用户ID
	/// </summary>
	public long UserId { get; set; }

	/// <summary>
	/// 用户名
	/// </summary>
	public string UserName { get; set; }

	/// <summary>
	/// 头像
	/// </summary>
	public string HeadImg { get; set; }

	/// <summary>
	/// 用户性别
	/// </summary>
	public UserSex? Sex { get; set; }

	/// <summary>
	/// 创建时间
	/// </summary>
	public long? CreateTime { get; set; }

	/// <summary>
	/// 其他信息
	/// </summary>
	public Object Other { get; set; }

	public LoggedUserInfoVo(){ }
}