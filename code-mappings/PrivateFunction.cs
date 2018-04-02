using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class PrivateFunction : Framework.SmartContract
    {
        // Constructor method
        public static void NeoSolPrivateFunction()
        {
            Test();
        }

        public static object Main(string operation, params object[] args)
        {
            if (Runtime.Trigger == TriggerType.Verification)
            {
                /*
                if (Owner.Length == 20)
                {
                    // if param Owner is script hash
                    return Runtime.CheckWitness(Owner);
                }
                else if (Owner.Length == 33)
                {
                    // if param Owner is public key
                    byte[] signature = operation.AsByteArray();
                    return VerifySignature(signature, Owner);
                }
                */
            }
            else if (Runtime.Trigger == TriggerType.Application)
            {
                if (operation == "_")
                {
                    NeoSolPrivateFunction();
                    return true;
                }
            }
            return false;
        }

        private static void Test()
        {
        }
    }
}
