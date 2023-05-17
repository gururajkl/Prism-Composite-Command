﻿using CompositeCommandModule;
using Prism.Ioc;
using Prism.Modularity;
using PrismCompositeCommand.Views;
using System.Windows;

namespace PrismCompositeCommand
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<CompositeCmdModule>();
        }
    }
}
