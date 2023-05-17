using CompositeCommandModule;
using CompositeCommands.Core.Commands;
using Prism.Ioc;
using Prism.Modularity;
using PrismCompositeCommand.Views;
using System.Windows;

namespace PrismCompositeCommand
{
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IApplicationCommand, ApplicationCommand>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<CompositeCmdModule>();
        }
    }
}
