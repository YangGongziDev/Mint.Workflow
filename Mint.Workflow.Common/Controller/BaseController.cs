using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mint.Workflow.Common.Extentiions;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;

namespace Mint.Workflow.Common.Controller {

    // 通用控制器封装
    public class BaseController<T> : ControllerBase {

        protected  ILogger<T> _logger { get; }
        
        // 当前访问用户的LoginInfo登录信息
        public LoggedUserInfoVo _loginInfo => base.User.ToLoginInfo();

        public BaseController(ILogger<T> logger) {
            _logger = logger;
        }
    }
    //
    // /// <summary>
    // /// CommonController模块封装
    // /// </summary>
    // public static class ControllerServiceCollectionExceptions {
    //     
    //     /// <summary>
    //     /// 实现CommonController模块封装
    //     /// </summary>
    //     /// <param name="services"></param>
    //     /// <returns></returns>
    //     public static IServiceCollection AddCommonControllers(this IServiceCollection services) {
    //         services.AddControllers(option => {
    //             // 1.配置CommonResultFilter-统一返回结果
    //             option.Filters.Add<CommonResultFilter>();
    //             // 2.配置CommonExceptionFilter-统一异常处理
    //             option.Filters.Add<CommonExceptionFilter>();
    //         }).AddJsonOptions(option => {
    //             // 3.配置JsonSerializerOptions-忽略属性为null表示大驼峰,默认小驼峰
    //             option.JsonSerializerOptions.PropertyNamingPolicy = null;
    //         });
    //         return services;
    //     }
    // }

    // /// <summary>
    // /// ClaimsPrincipal拓展-用于获取用户信息
    // /// </summary>
    // /// <param name="claimsPrincipal"></param>
    // /// <returns></returns>
    // public static class GetLoginInfoByClaimsPrincipalExtentiions {
    //     //ClaimsPrincipal拓展-用于获取用户信息
    //     public static LoginInfo ToLoginInfo(this ClaimsPrincipal claimsPrincipal) {
    //         //1、创建LoginInfo
    //         LoginInfo loginInfo = new LoginInfo();
    //         List<Claim> source = claimsPrincipal.Claims.ToList();
    //         loginInfo.UserId = Int64.Parse(source.Single((Claim m) => m.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/sid").Value);
    //         loginInfo.UserName = source.Single((Claim m) => m.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").Value;
    //         if (source.SingleOrDefault((Claim m) => m.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri") != null) {
    //             loginInfo.HeadImg = source.Single((Claim m) => m.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri").Value;
    //         }
    //         // loginInfo.Sex = (UserSex)source.Single((Claim m) => m.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").Value.ToInt32();
    //         Claim claim = source.SingleOrDefault((Claim m) => m.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata");
    //         if (claim != null) {
    //             loginInfo.Other = JsonConvert.DeserializeObject(claim.Value);
    //         }
    //         return loginInfo;
    //     }
    // }
}
