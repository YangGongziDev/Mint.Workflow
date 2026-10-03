namespace Mint.Workflow.Entity.Dtos;

/// <summary>
/// 用户登录Dto
/// 用于接收用户登录请求的参数
/// 包含用户名和密码等信息数
/// </summary>
public class UserLoginDto {
	
	public string UserName { get; set; } // 用户名
	public string Password { get; set; } // 密码

	public UserLoginDto(){ }
}