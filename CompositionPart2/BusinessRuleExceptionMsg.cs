namespace Composition

{
    public class BusinessRuleExceptionMsg
    {
        private readonly StoreErrMsg _storeErrMsg;

        public BusinessRuleExceptionMsg(StoreErrMsg storeErrMsg)
        {
            this._storeErrMsg = storeErrMsg;
        }

        public void TriggerStoreErrMsg()
        {
            _storeErrMsg.ShowMsg("Business rule exception encountered.");
        }


    }




}