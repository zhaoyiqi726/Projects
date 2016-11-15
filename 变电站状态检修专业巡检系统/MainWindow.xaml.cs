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
using mshtml;
using System.Security.Permissions;

namespace 变电站状态检修专业巡检系统
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeDepartment();
            InitializeWebBrowser();

            btnClose.Click += (s, e) => 
            {
                if (MessageBoxResult.OK == MessageBox.Show("确定要退出本系统？", "退出消息", MessageBoxButton.OKCancel))
                {
                    Close();
                }
            };
        }

        private void InitializeDepartment()
        {
            tvDepartments.ItemsSource = DepartmentUtility.BindDepartment(
                DepartmentUtility.GetDepartments().OrderBy(i => i.ParentDepartmentID).ToList());
        }

        private void InitializeWebBrowser()
        {
            wbMap.Navigate(new Uri(Environment.CurrentDirectory + "/Map/BMap.html", UriKind.RelativeOrAbsolute));
            var help = new ObjectForScriptingHelper(this);
            wbMap.ObjectForScripting = help;
        }

        private void Login(object sender, MouseButtonEventArgs e)
        {
            new LoginWindow((sender as TextBlock).Text).ShowDialog();
        }
    }
}
