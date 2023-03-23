using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class NewPostCommand : BaseCommand
    {
        public string Author { get; set; } = String.Empty;
        public string Message { get; set; } = String.Empty;
    }

}