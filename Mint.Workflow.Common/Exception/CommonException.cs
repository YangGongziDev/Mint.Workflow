using System;
namespace Mint.Workflow.Common.Exception {
    public class CommonException : System.Exception {
        
        public CommonException() {
            Code = 500.ToString();
        }
        
        public CommonException(string? message) : base(message) {
            Code = 500.ToString();
            Message = message;
        }
        
        public CommonException(string code, string message, string trace) {
            Code = code;
            Message = message;
            Trace = trace;
        }
        
        /// <summary>
        /// 异常编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 异常信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 异常原因
        /// </summary>
        public string Trace { get; set; }
        
    }
}
