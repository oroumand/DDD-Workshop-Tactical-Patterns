using System.Collections.Generic;

namespace DDDClass.DomainEvents
{
    public class BaseEntity
    {
        private readonly List<IEvent> _events = new List<IEvent>();
        public IEnumerable<IEvent> Events
        {
            get
            {
                return _events;
            }
        }

        protected void AddEvent(IEvent @event)
        {
            _events.Add(@event);
        }
        protected void ClearEvents()
        {
            _events.Clear();
        }
    }
}
