using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow(string name)
        {
            InitializeComponent();

            txtState.Text = name;
            cobUser.ItemsSource = CommonUtility.GetLocalUserName();

            btnLogin.Click += (s, e) => 
            {
                if (cobUser.Text == string.Empty || txtPassword.Text == string.Empty)
                {
                    return;
                }
                if (LoginUtility.CheckPassword(cobUser.Text, txtPassword.Text))
                {
                    CommonUtility.SaveUserName(cobUser.Text.Trim());
                    User currentUser = LoginUtility.GetUser(cobUser.Text.Trim());
                    Close();
                    new RoutingPlanWindow(currentUser).ShowDialog();
                }
            };

            btnExit.Click += (s, e) =>
            {
                Close();
            };
        }
    }
}
