using CQRS.Core.Events;

namespace CQRS.Core.Events
{
    public class PostCreatedEvent : BaseEvent
    {
        public PostCreatedEvent() : base(nameof(PostCreatedEvent))
        {

        }

        public string Author { get; set; } = String.Empty;
        public string Message { get; set; } = String.Empty;
        public DateTime DatePosted { get; set; }
    }
}