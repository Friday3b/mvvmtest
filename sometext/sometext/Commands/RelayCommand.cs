using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace sometext.Commands
{
    public class RelayCommand : ICommand
    {
        //fields
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecuteAction;
        //constructor
        public RelayCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = null;
        }


        //events

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        //methods
        public bool CanExecute(object parameter) => _canExecuteAction == null ? true : _canExecuteAction(parameter);




        public void Execute(object parameter) => _executeAction(parameter);

    }
}
