using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AppWPF.ViewModels.Commands
{
    public class ExecuteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            ClickAction?.Invoke();
        }

        // delegate action
        private Action _clickAction;
        public Action ClickAction { get => _clickAction; set => _clickAction = value; }

        // constructor attach delegate action
        public ExecuteCommand(Action execute)
        {
            ClickAction = execute;
        }
    }
}
