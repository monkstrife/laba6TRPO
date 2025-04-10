using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace лаба6_ТРПО.Model
{
    public class Faculty: INotifyPropertyChanged
    {
        private int id;
        private string name;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Id"));
                }
            }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (name != value)
                {
                    name = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public Faculty(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
