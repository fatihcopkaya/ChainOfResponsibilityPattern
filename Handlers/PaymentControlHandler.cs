using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers
{
    public class PaymentControlHandler : BaseHandler
    {
        public override ITransportObject Handle(ITransportObject transportObject)
        {
            var transactionModel = (TransactionModel)transportObject;
            Console.WriteLine("Payment has been made");
            return transactionModel;
        }
    }
}
