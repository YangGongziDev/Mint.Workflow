using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Mint.Workflow.Common.Exception {
	
    public class CommonExceptionFilter : IExceptionFilter {
	    
        /// <summary>
        /// 通用异常包装
        /// </summary>
        /// <param name="context"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void OnException(ExceptionContext context) {

            // 1.获取异常信息
            System.Exception exception = context.Exception;

            if (exception is CommonException common) {
                // 1.2.通用异常结果包装
                CommonExceptionResult commonExceptionResult = new CommonExceptionResult();
                commonExceptionResult.Code = common.Code;
                commonExceptionResult.Message = common.Message;
                commonExceptionResult.Trace = common.StackTrace;
                // 1.3.设置通用异常返回结果
                context.Result = new JsonResult(commonExceptionResult);
            } else  {
                // 2.异常包装
                CommonException commonException = new CommonException();
                commonException.Code = "-1";
                commonException.Message = exception.Message;
                commonException.Trace = exception.StackTrace;
                // 2.1.设置异常结果
                context.Exception = commonException;

                // 2.2.通用异常结果包装
                CommonExceptionResult commonExceptionResult = new CommonExceptionResult();
                commonExceptionResult.Code = commonException.Code;
                commonExceptionResult.Message = commonException.Message;
                commonExceptionResult.Trace = commonException.Trace;
                // 2.3.设置通用异常返回结果
                context.Result = new JsonResult(commonExceptionResult);
            }
        }
    }
}
