using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace лаба6_ТРПО.ViewModel
{
    public class BaseCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExrcute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;}
        }

        public BaseCommand(Action<object> execute, Func<object, bool> canExrcute)
        {
            this.execute = execute;
            this.canExrcute = canExrcute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExrcute == null || this.canExrcute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
