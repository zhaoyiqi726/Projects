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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;

namespace 变电站状态检修专业巡检系统
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeDepartment();
            btnClose.Click += (s, e) => { this.Close(); };
        }

        private void InitializeDepartment()
        {
            tvDepartments.ItemsSource = DepartmentUtility.BindDepartment(
                DepartmentUtility.GetDepartments().OrderBy(i => i.ParentDepartmentID).ToList());
        }

        private void Login(object sender, MouseButtonEventArgs e)
        {
            new LoginWindow((sender as TextBlock).Text).Show();
        }
    }
}
