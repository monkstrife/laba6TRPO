using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using лаба6_ТРПО.Model;

namespace лаба6_ТРПО.ViewModel
{
    public class AllViewModel
    {
        private ObservableCollection<BaseClass> students;
        private ObservableCollection<BaseClass> groups;
        private ObservableCollection<BaseClass> facultys;
        private ObservableCollection<BaseClass> baseClasses;
        private BaseClass? selectedItem;
        public int i;

        #region ДАННЫЕ ДЛЯ ПРЕДСТАВЛЕНИЯ
        public ObservableCollection<BaseClass> Students
        {
            get
            {
                return students;
            }
            set { students = value; }
        }

        public ObservableCollection<BaseClass> Groups
        {
            get
            {
                return groups;
            }
            set { groups = value; }
        }

        public ObservableCollection<BaseClass> Facultys
        {
            get
            {
                return facultys;
            }
            set { facultys = value; }
        }

        public ObservableCollection<BaseClass> BaseClasses
        {
            get
            {
                return baseClasses;
            }
            set { baseClasses = value; }
        }

        public BaseClass? SelectedItem
        {
            get { return selectedItem; } set { SelectedItem = value; }
            }
        
        #endregion

        private BaseCommand addCommand;
        public BaseCommand AddCommand
        {
            get
            {
                if(addCommand != null)
                {
                    return addCommand;
                }
                else
                {
                    Action<object> Execute = o =>
                    {
                        MainWindow window = (MainWindow)System.Windows.Application.Current.MainWindow;
                        if ((string)window.Resources["CurrentTab"] == "Студенты")
                        {
                            BaseClass student = new BaseClass("", 1, 1);
                            Students.Add(student);
                            BaseClasses.Add(student);
                        }
                        if ((string)window.Resources["CurrentTab"] == "Группы")
                        {
                            BaseClass group = new BaseClass("", 1, 1);
                            Groups.Add(group);
                            BaseClasses.Add(group);
                        }
                        if ((string)window.Resources["CurrentTab"] == "Факультеты")
                        {
                            BaseClass faculty = new BaseClass("Приинф", 1, 4);
                            Facultys.Add(faculty);
                            BaseClasses.Add(faculty);
                        }
                    };
                    Func<object, bool> CanExecute = o => Students.Count() < 7;
                    addCommand = new BaseCommand(Execute, CanExecute);
                    return addCommand;
                }
            }
        }

        private BaseCommand remCommand;
        public BaseCommand RemCommand
        {
            get
            {
                if (remCommand != null)
                {
                    return remCommand;
                }
                else
                {
                    MainWindow window = (MainWindow)System.Windows.Application.Current.MainWindow;
                    Action<object> Execute = o =>
                    {
                        var Allitem = window.lBox;
                        var selItem = (BaseClass)Allitem.SelectedItem;
                        if ((string)window.Resources["CurrentTab"] == "Студенты")
                            Students.Remove(selItem);
                        if ((string)window.Resources["CurrentTab"] == "Группы")
                            Groups.Remove(selItem);
                        if ((string)window.Resources["CurrentTab"] == "Факультеты")
                            Facultys.Remove(selItem);
                        BaseClasses.Remove(selItem);
                    };
                    Func<object, bool> CanExecute = o => BaseClasses.Count() > 0;
                    addCommand = new BaseCommand(Execute, CanExecute);
                    return addCommand;
                }
            }
        }

        private BaseCommand refreshTableCommand;

        public BaseCommand RefreshTableCommand
        {
            get
            {
                if (refreshTableCommand != null)
                {
                    return refreshTableCommand;
                }
                else
                {
                    Action<object> Execute = o =>
                    {
                        // ((MainWindow)System.Windows.Application.Current.MainWindow).c1.Text == "asd"
                        MainWindow window = (MainWindow)System.Windows.Application.Current.MainWindow;
                        if (o.ToString() == "Студенты")
                        {
                            window.Resources["column1"] = "Имя";
                            window.Resources["column2"] = "Группа";
                            window.Resources["column3"] = "Факультет";
                            window.Resources["column4"] = "";
                            window.c1.Text = (string)window.Resources["column1"];
                            window.c2.Text = (string)window.Resources["column2"];
                            window.c3.Text = (string)window.Resources["column3"];
                            window.c4.Text = (string)window.Resources["column4"];

                            BaseClasses.Clear();
                            for (int i = 0; i < Students.Count; i++)
                            {
                                BaseClasses.Add(Students[i]);
                            }
                        }
                        if (o.ToString() == "Группы")
                        {
                            window.Resources["column1"] = "Староста";
                            window.Resources["column2"] = "Номер группы";
                            window.Resources["column3"] = "Курс";
                            window.Resources["column4"] = "";
                            window.c1.Text = (string)window.Resources["column1"];
                            window.c2.Text = (string)window.Resources["column2"];
                            window.c3.Text = (string)window.Resources["column3"];
                            window.c4.Text = (string)window.Resources["column4"];

                            BaseClasses.Clear();
                            for (int i = 0; i < Groups.Count; i++)
                            {
                                BaseClasses.Add(Groups[i]);
                            }
                        }
                        if (o.ToString() == "Факультеты")
                        {
                            window.Resources["column1"] = "Название";
                            window.Resources["column2"] = "Номер факультета";
                            window.Resources["column3"] = "Время учебы";
                            window.Resources["column4"] = "";
                            window.c1.Text = (string)window.Resources["column1"];
                            window.c2.Text = (string)window.Resources["column2"];
                            window.c3.Text = (string)window.Resources["column3"];
                            window.c4.Text = (string)window.Resources["column4"];

                            BaseClasses.Clear();
                            for (int i = 0; i < Facultys.Count; i++)
                            {
                                BaseClasses.Add(Facultys[i]);
                            }
                        }
                        window.Resources["CurrentTab"] = o.ToString();
                    };
                    Func<object, bool> CanExecute = o => true;
                    refreshTableCommand = new BaseCommand(Execute, CanExecute);
                    
                    return refreshTableCommand;
                }
            }
        }

        public AllViewModel()
        {
            students = new ObservableCollection<BaseClass>();
            groups = new ObservableCollection<BaseClass>();
            facultys = new ObservableCollection<BaseClass>();
            baseClasses = new ObservableCollection<BaseClass>();
            i = 0;
        }
    }
}
