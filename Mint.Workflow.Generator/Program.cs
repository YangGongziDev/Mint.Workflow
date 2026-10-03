using Scriban.Runtime;

namespace Mint.Workflow.Generator {
    internal class Program {
        static void Main(string[] args) {
            // 运行代码生成器
            CodeGenerator codeGenerator = new CodeGenerator();
            codeGenerator.GenerateCode();
        }
    }
}
