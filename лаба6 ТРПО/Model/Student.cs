using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба6_ТРПО.Model
{
    public class Student: INotifyPropertyChanged
    {
        private string name;
        private string lastname;
        private Group group;
        private Faculty faculty;

        public event PropertyChangedEventHandler? PropertyChanged;

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

        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Lastname"));
                }
            }
        }

        public Group Group
        {
            get { return group; }
            set
            {
                if (group != value)
                {
                    group = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Group"));
                }
            }
        }

        public Faculty Faculty
        {
            get { return faculty; }
            set
            {
                if (faculty != value)
                {
                    faculty = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Faculty"));
                }
            }
        }

        public Student(string name, string lastname, Group group, Faculty faculty)
        {
            this.name = name;
            this.lastname = lastname;
            this.group = group;
            this.faculty = faculty;
        }
    }
}
