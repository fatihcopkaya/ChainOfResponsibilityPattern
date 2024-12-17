using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class BankAdapterControlHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            var transactionModel = (TransactionModel)transportObject;
            Console.WriteLine("The bank through which the transaction will pass has been determined");
            return NextChain(transactionModel);
        }
    }
}
