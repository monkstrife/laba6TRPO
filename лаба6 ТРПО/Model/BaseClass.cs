using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба6_ТРПО.Model
{
    public class BaseClass : INotifyPropertyChanged
    {
        private string col1;
        private int col2;
        private int col3;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Col1
        {
            get { return col1; }
            set
            {
                if (col1 != value)
                {
                    col1 = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Col1"));
                }
            }
        }

        public int Col2
        {
            get { return col2; }
            set
            {
                if (col2 != value)
                {
                    col2 = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Col2"));
                }
            }
        }

        public int Col3
        {
            get { return col3; }
            set
            {
                if (col3 != value)
                {
                    col3 = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Col3"));
                }
            }
        }
        

        public BaseClass(string col1, int col2, int col3)
        {
            this.col1 = col1;
            this.col2 = col2;
            this.col3 = col3;
        }
    }
}
