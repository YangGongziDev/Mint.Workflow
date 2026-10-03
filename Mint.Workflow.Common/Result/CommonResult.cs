namespace Mint.Workflow.Common.Result {
    
    /// <summary>
    /// 通用返回结果
    /// </summary>
    public class CommonResult {
	    
        // 返回结果状态码
        public int Code { get; set; }
        // 返回结果信息
        public string Message { get; set; }
        // 返回结果数据
        public dynamic Data { get; set; }
        
    }
}
