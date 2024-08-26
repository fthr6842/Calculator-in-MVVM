using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace calculator_1054
{
    internal class RelayCommand<T>: ICommand
    {

        string element = "";
        readonly Func<bool> _canExecute;
        readonly Action<T> _execute;
        public RelayCommand (Action<T> action, Func<bool> canExecute=null)
        {
            _execute = action ?? throw new ArgumentNullException(nameof(action));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object parameter)
        {
            if (parameter is T typedParameter)
            {
                _execute(typedParameter);
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                    CommandManager.RequerySuggested += value;
            }
            remove
            {
                    CommandManager.RequerySuggested -= value;
            }
        }
    }
}
