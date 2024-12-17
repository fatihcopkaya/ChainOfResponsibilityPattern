using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class DealerControlHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            var transactionModel = (TransactionModel)transportObject;

            Console.WriteLine("Dealer check has been completed");
                return NextChain(transactionModel);
        }
    }
}
