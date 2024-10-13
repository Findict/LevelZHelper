using System.Windows.Input;

namespace LevelZHelper
{
    internal class ActionCommand : ICommand
    {
        private readonly Action _action;

        public ActionCommand(Action action)
        {
            _action = action;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _action.Invoke();
        }
    }
}
