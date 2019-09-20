namespace DDDClass.DomainEvents
{
    public interface IEventDispatcher
    {
        void Dispatche<T>(params T[] events) where T : IEvent;
    }
}
