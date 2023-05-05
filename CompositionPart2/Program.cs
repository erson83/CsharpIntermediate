namespace Composition

{


    class Program

    {

        static void Main(string[] args)
        {
            var storeMsg = new StoreErrMsg();
            var businessRuleExceptionMsg = new BusinessRuleExceptionMsg(storeMsg);

            businessRuleExceptionMsg.TriggerStoreErrMsg();

        }


    }




}