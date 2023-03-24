using CQRS.Core.Events;

namespace Post.Common.Events
{
    public class CommnetAddedEvent : BaseEvent
    {
        public CommnetAddedEvent() : base(nameof(CommnetAddedEvent))
        {
        }

        public Guid CommentId { get; set; }
        public string Comment { get; set; } = String.Empty;
        public string UserName { get; set; } = String.Empty;
        public DateTime CommentDate { get; set; }
    }
}