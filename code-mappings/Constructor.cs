using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class Constructor : Framework.SmartContract
    {
        // Constructor method
        public static void NeoSolConstructor() 
        {
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
                    NeoSolConstructor();
                    return true;
                }
            }
            return false;
        }
    }
}
