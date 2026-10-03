using System.Security.Claims;
using JadeFramework.Core.Domain.Entities;
using Newtonsoft.Json;
using Mint.Workflow.Common.Controller;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;

namespace Mint.Workflow.Common.Extentiions;

/// <summary>
/// ClaimsPrincipal拓展-用于在controlle获取用户信息
/// </summary>
/// <param name="claimsPrincipal"></param>
/// <returns></returns>
public static class GetLoginInfoByClaimsPrincipalExtentiions {
	//ClaimsPrincipal拓展-用于在controlle获取用户信息
	public static LoggedUserInfoVo ToLoginInfo(this ClaimsPrincipal claimsPrincipal) {
		//1、创建LoginInfo
		LoggedUserInfoVo loginInfo = new LoggedUserInfoVo();
		List<Claim> source = claimsPrincipal.Claims.ToList();
		loginInfo.UserId = Int64.Parse(source.Single((Claim m) => m.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid").Value);
		loginInfo.UserName = source.Single((Claim m) => m.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").Value;
		if (source.SingleOrDefault((Claim m) => m.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri") != null) {
			loginInfo.HeadImg = source.Single((Claim m) => m.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri").Value;
		}
		// loginInfo.Sex = (UserSex)source.Single((Claim m) => m.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").Value.ToInt32();
		Claim claim = source.SingleOrDefault((Claim m) => m.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata");
		if (claim != null) {
			loginInfo.Other = JsonConvert.DeserializeObject(claim.Value);
		}
		return loginInfo;
	}
}