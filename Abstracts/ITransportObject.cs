namespace ChainOfResponsibilityPattern.Abstracts
{
    public interface ITransportObject
    {
        public decimal Amount { get; set; }
        public Guid OrderId { get; set; }
    }
}

