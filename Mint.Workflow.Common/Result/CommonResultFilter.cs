using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Mint.Workflow.Common.Result {

    /// <summary>
    /// 通用结果返回
    /// </summary>
    public class CommonResultFilter : IAsyncResultFilter {

        /// <summary>
        /// 拦截结果
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next) {
            
            // 1.获取Action结果
            IActionResult actionResult = context.Result;
            // 返回结果包装类型
            CommonResult commonResult = new CommonResult();

            //2.判断Action结果类型是否为 ObjectResult
            if (actionResult is ObjectResult objectResult) {

                //2.1.获取结果值
                object result = objectResult.Value;

                // 2.3获取结果值类型
                if(result is CommonResult common) {
                    commonResult.Code = common.Code;
                    commonResult.Message = common.Message;
                    commonResult.Data = common.Data;
                } else {
                    //2.2.2.包装返回结果
                    commonResult.Code = 200;
                    commonResult.Message = "成功";
                    commonResult.Data = result;
                }
            }

            // 3.判断Action结果类型是否为EmptyResult
            if (actionResult is EmptyResult emptyResult) {
                commonResult.Code = 201;
                commonResult.Message = "无结果";
                commonResult.Data = "";
            }

            // 3.判断Action结果类型是否为JsonResult
            if (actionResult is JsonResult jsonResult) {
                commonResult.Code = 200;
                commonResult.Message = "成功";
                commonResult.Data = jsonResult.Value;
            }

            // 4.判断Action结果类型是否为StatusCodeResult
            if (actionResult is StatusCodeResult statusCodeResult) {
                commonResult.Code = 200;
                commonResult.Message = "成功";
                commonResult.Data = statusCodeResult.StatusCode;
            }

            // 重置返回结果
            context.Result = new JsonResult(commonResult);

            // 下一个过滤器执行
            await next();
        }
    }
}
