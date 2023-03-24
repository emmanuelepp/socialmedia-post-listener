using CQRS.Core.Events;

namespace Post.Common.Events
{
    public class PostLikedevent : BaseEvent
    {
        public PostLikedevent() : base(nameof(PostCreatedEvent))
        {
        }
    }

}