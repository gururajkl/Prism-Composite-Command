using Prism.Commands;

namespace CompositeCommands.Core.Abstractions
{
    public interface IApplicationCommand
    {
        CompositeCommand SaveAllCommand { get; }
    }
}
