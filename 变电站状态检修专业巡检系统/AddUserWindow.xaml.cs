using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace 变电站状态检修专业巡检系统
{
    /// <summary>
    /// AddUserWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow(bool isLeader, Action<List<string>> setUsers, string existsNames)
        {
            InitializeComponent();

            btnOK.Click += (s, e) => 
            {
                var names = new List<string>();
                foreach (CheckBox checkbox in stack.Children.OfType<CheckBox>())
                {
                    if (true == checkbox.IsChecked)
                    {
                        names.Add(checkbox.Content.ToString());
                    }
                }
                setUsers(names);
                Close();
            };

            foreach (var user in LoginUtility.GetUsers(isLeader))
            {
                CheckBox checkbox = new CheckBox()
                {
                    Content = user,
                    FontSize = 20,
                    Margin = new Thickness(5),
                    Height = 30
                };
                stack.Children.Add(checkbox);
            }

            if (string.Empty != existsNames)
            {
                foreach (var checkbox in stack.Children.OfType<CheckBox>())
                {
                    foreach (var existsName in existsNames.Split(';'))
                    {
                        if (existsName == checkbox.Content.ToString())
                        {
                            checkbox.IsChecked = true;
                        }
                    }
                }
            }
        }
    }
}
