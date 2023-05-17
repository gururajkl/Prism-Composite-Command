﻿using CompositeCommands.Core.Abstractions;
using Prism.Mvvm;

namespace PrismCompositeCommand.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Composite Command Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private IApplicationCommand applicationCommand;
        public IApplicationCommand ApplicationCommand
        {
            get { return applicationCommand; }
            set { SetProperty(ref applicationCommand, value); }
        }

        public MainWindowViewModel(IApplicationCommand applicationCommand)
        {
            ApplicationCommand = applicationCommand;
        }
    }
}
