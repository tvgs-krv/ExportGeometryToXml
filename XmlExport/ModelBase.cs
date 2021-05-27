using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace XmlExport
{
    public class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged == null)
                return;
            propertyChanged((object)this, new PropertyChangedEventArgs(propertyName));
        }
    }


    public class RelayCommandWithoutParameter : ICommand
    {
        private readonly Action _execute;
        private readonly Func<object, bool> _canExecute;
        public string CommandName { get; }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
        public RelayCommandWithoutParameter(Action execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public RelayCommandWithoutParameter(Action execute,string commandName,Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
            CommandName = commandName;
        }
        public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);
        public void Execute(object parameter) => _execute();
    }

    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _execute;
        private readonly Func<object, bool> _canExecute;
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
        public RelayCommand(Action<T> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter) => _canExecute == null || this._canExecute(parameter);
        public void Execute(object parameter) => _execute((T) parameter);
    }

    public class AnotherCommandImplementation : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public AnotherCommandImplementation(Action<object> execute) : this(execute, null)
        {
        }

        public AnotherCommandImplementation(Action<object> execute, Func<object, bool> canExecute)
        {
            if (execute == null) throw new ArgumentNullException(nameof(execute));

            _execute = execute;
            _canExecute = canExecute ?? (x => true);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
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

        public void Refresh()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }


}
