using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба6_ТРПО.Model
{
    public class Group : INotifyPropertyChanged
    {
        private int id;
        private int course;

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

        public int Course
        {
            get { return course; }
            set 
            {
                if (course != value)
                {
                    course = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Course"));
                }
            }
        }

        public Group(int id, int course)
        {
            this.id = id;
            this.course = course;
        }
    }
}
