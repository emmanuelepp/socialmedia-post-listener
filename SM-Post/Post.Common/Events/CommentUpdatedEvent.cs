using CQRS.Core.Events;

namespace Post.Common.Events
{
    public class CommentUpdatedEvent : BaseEvent
    {
        public CommentUpdatedEvent() : base(nameof(CommentUpdatedEvent))
        {
        }
        public Guid CommentId { get; set; }
        public string Comment { get; set; } = String.Empty;
        public string UserName { get; set; } = String.Empty;
        public DateTime EditDate { get; set; }
    }
}