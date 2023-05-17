using CompositeCommands.Core.Abstractions;
using Prism.Commands;

namespace CompositeCommands.Core.Commands
{
    public class ApplicationCommand : IApplicationCommand
    {
        public CompositeCommand SaveAllCommand { get; } = new CompositeCommand();
    }
}
