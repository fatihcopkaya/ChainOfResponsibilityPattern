using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class CommissionControlHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            var transactionModel = (TransactionModel)transportObject;

            Console.WriteLine("Commission check has been completed");
            return NextChain(transactionModel);
        }
    }
}
