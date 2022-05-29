using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModel
{
    public class BasicCalculatorViewMode : ViewModelBase
    {
        public BasicCalculatorViewMode()
        {
            Text ="ddd";
        }


        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                
                OnPropertyChanged("Text");
            }
        }
    }
}
