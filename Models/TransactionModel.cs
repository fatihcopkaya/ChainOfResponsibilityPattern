using ChainOfResponsibilityPattern.Abstracts;

namespace ChainOfResponsibilityPattern.Models
{
    public class TransactionModel : ITransportObject
    {
        public Guid TransactionId { get; set; }
        public decimal Amount { get; set; }
        public Guid OrderId { get; set; }
        public int DealerId { get; set; }
        public int BankId { get; set; }
    }
}
