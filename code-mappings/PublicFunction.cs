using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class PublicFunction : Framework.SmartContract
    {
        // Constructor method
        public static void NeoSolPublicFunction()
        {
            Test();
        }

        public static object Main(string operation, params object[] args)
        {
            if (Runtime.Trigger == TriggerType.Verification)
            {
            }
            else if (Runtime.Trigger == TriggerType.Application)
            {
                if (operation == "_")
                {
                    NeoSolPublicFunction();
                    return true;
                }
            }
            return false;
        }

        public static void Test()
        {
        }
    }
}
