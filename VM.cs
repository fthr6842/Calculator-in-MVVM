using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO.Packaging;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace calculator_1054
{
    public class VM: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private Class1 _textbox = new Class1();
        
        public string Result
        {
            get { return _textbox.Result; }
            set
            {
                _textbox.Result = value;
                RaisePropertyChanged("Result");
            }
        }

        public string Formula
        {
            get { return _textbox.Formula; }
            set
            {
                _textbox.Formula = value;
                RaisePropertyChanged("Formula");
            }
        }

        public ICommand One { get; }
        public ICommand Two { get; }
        public ICommand Three { get; }
        public ICommand Four { get; }
        public ICommand Five { get; }
        public ICommand Six { get; }
        public ICommand Seven { get; }
        public ICommand Eight { get; }
        public ICommand Nine { get; }
        public ICommand Zero { get; }
        public ICommand Equal { get; }
        public ICommand Divide { get; }
        public ICommand Multiply { get; }
        public ICommand Minus { get; }
        public ICommand Plus { get; }
        public ICommand Backspace { get; }
        public ICommand Clean { get; }
        public ICommand Dot { get; }
        public ICommand Power { get; }
        public ICommand Percent { get; }
        public ICommand BrLeft { get; }
        public ICommand BrRight { get; }

        public VM()
        {
            One = new RelayCommand<string>(typing);
            Two = new RelayCommand<string>(typing);
            Three = new RelayCommand<string>(typing);
            Four = new RelayCommand<string>(typing);
            Five = new RelayCommand<string>(typing);
            Six = new RelayCommand<string>(typing);
            Seven = new RelayCommand<string>(typing);
            Eight = new RelayCommand<string>(typing);
            Nine = new RelayCommand<string>(typing);
            Zero = new RelayCommand<string>(typing);
            Equal = new RelayCommand<string>(typing);
            Divide = new RelayCommand<string>(typing);
            Multiply = new RelayCommand<string>(typing);
            Minus = new RelayCommand<string>(typing);
            Plus = new RelayCommand<string>(typing);
            Backspace = new RelayCommand<string>(typing);
            Clean = new RelayCommand<string>(typing);
            Dot = new RelayCommand<string>(typing);
            Power = new RelayCommand<string>(typing);
            Percent = new RelayCommand<string>(typing);
            BrLeft = new RelayCommand<string>(typing);
            BrRight = new RelayCommand<string>(typing);
        }

        private void typing(string parameter)
        {
            var temp = _textbox.Typing(parameter);
            Formula = temp.Item1;
            Result = temp.Item2;
        }
    }
}
