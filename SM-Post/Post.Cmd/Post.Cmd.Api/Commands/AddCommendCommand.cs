using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class AddCommendCommand : BaseCommand
    {
        public string Comment { get; set; } = String.Empty;
        public string UserName { get; set; } = String.Empty;
    }

}