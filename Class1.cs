using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace calculator_1054
{
    public class Class1
    {
        private string _result;
        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
            }
        }

        private string _formula;
        public string Formula
        {
            get { return _formula; }
            set
            {
                _formula = value;
            }
        }

        private string temp = "";

        public (string, string) Typing(string parameter)
        {
            if (parameter == "Backspace")
            {
                if (temp.Length != 0)
                {
                    temp = temp.Substring(0, temp.Length - 1);
                    return (temp, "");
                }
                else 
                {
                    return ("", "");
                }
            }
            else if (parameter == "=")
            {
                return (temp, Res());
            }
            else if (parameter == "C")
            {
                temp = "";
                return (temp, temp);
            }
            else
            {
                temp += parameter;
                return (temp, Result);
            }
        }

        private string Res()
        {
            DataTable table = new DataTable();
            return table.Compute(temp, string.Empty).ToString();
        }
    }
}
