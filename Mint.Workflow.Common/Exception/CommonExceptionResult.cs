namespace Mint.Workflow.Common.Exception {
    public class CommonExceptionResult {
	    
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
