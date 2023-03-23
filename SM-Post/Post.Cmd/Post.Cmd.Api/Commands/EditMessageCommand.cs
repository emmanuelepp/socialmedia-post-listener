using CQRS.Core.Commands;

namespace Post.Cmd.Commands
{
    public class EditMessageCommand : BaseCommand
    {
        public string Message { get; set; } = String.Empty;
    }

}