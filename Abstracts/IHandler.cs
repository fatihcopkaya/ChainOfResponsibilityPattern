namespace ChainOfResponsibilityPattern.Abstracts
{
    public interface IHandler
    {
        ITransportObject Handle(ITransportObject transportObject);
        IHandler SetNext(IHandler handler);
    }
 
}
