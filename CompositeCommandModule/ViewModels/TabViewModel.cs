using CompositeCommands.Core.Abstractions;
using Prism.Commands;
using Prism.Mvvm;
using System;

namespace CompositeCommandModule.ViewModels
{
    public class TabViewModel : BindableBase
    {
        public TabViewModel(IApplicationCommand applicationCommand)
        {
            SaveCommand = new DelegateCommand(Execute).ObservesCanExecute(() => CanUpdate);
            applicationCommand.SaveAllCommand.RegisterCommand(SaveCommand);
        }

        private string? title;
        public string? Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private bool canUpdate;
        public bool CanUpdate
        {
            get { return canUpdate; }
            set { SetProperty(ref canUpdate, value); }
        }

        public DelegateCommand SaveCommand { get; private set; }

        public void Execute()
        {
            UpdatedText = $"Updated: {DateTime.Now}";
        }

        private string? updatedText;
        public string? UpdatedText
        {
            get { return updatedText; }
            set { SetProperty(ref updatedText, value); }
        }
    }
}
