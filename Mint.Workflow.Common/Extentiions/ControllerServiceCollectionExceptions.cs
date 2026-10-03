using Microsoft.Extensions.DependencyInjection;
using Mint.Workflow.Common.Exception;
using Mint.Workflow.Common.Result;
using Mint.Workflow.Entity.Dtos;
using Mint.Workflow.Entity.Vos;

namespace Mint.Workflow.Common.Extentiions;

/// <summary>
/// CommonController模块封装
/// </summary>
public static class ControllerServiceCollectionExceptions {
	
	/// <summary>
	/// 实现CommonController模块封装
	/// </summary>
	/// <param name="services"></param>
	/// <returns></returns>
	public static IServiceCollection AddCommonControllers(this IServiceCollection services) {
		services.AddControllers(option => {
			// 1.配置CommonResultFilter-统一返回结果
			option.Filters.Add<CommonResultFilter>();
			// 2.配置CommonExceptionFilter-统一异常处理
			option.Filters.Add<CommonExceptionFilter>();
		}).AddJsonOptions(option => {
			// 3.配置JsonSerializerOptions-忽略属性为null表示大驼峰,默认小驼峰
			option.JsonSerializerOptions.PropertyNamingPolicy = null;
		});
		return services;
	}
	
}