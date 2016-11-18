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
    /// RoutingSpecialRecordWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RoutingSpecialRecordWindow : Window
    {
        public RoutingSpecialRecordWindow(Record record, bool openFromRoutingWindow = false)
        {
            InitializeComponent();
            btnClose.Click += CloseWindow;
            btnCancel.Click += CloseWindow;
            btnSave.Click += (s, e) =>
            {
                record.Weather = txtWeather.Text;
                record.Temperature = txtTemperature.Text;
                record.Remark = txtRemark.Text;
                record.Leader = txtLeader.Text;
                record.UserName = txtRouter.Text;

                if (openFromRoutingWindow)
                {
                    new RoutingWindow("沙德格", record).Show();
                }

                Close();
            };

            txtRecordNo.Text = record.RecordNo;
            txtDateTime.Text = record.CreateTime.ToString("yyyy-MM-dd");
            txtRoutingPlan.Text = record.PlanName;
            txtWeather.Text = record.Weather;
            txtRouter.Text = record.UserName;
            txtLeader.Text = record.Leader;

            btnRouter.Click += (s, e) =>
            {
                string names = txtRouter.Text;
                txtRouter.Text = string.Empty;
                new AddUserWindow(false, SetRouters, names).ShowDialog();
            };

            btnLeader.Click += (s, e) =>
            {
                string names = txtLeader.Text;
                txtLeader.Text = string.Empty;
                new AddUserWindow(true, SetLeaders, names).ShowDialog();
            };
        }


        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void SetRouters(List<string> names)
        {
            foreach (string name in names)
            {
                txtRouter.Text += $"{name};";
            }
        }

        public void SetLeaders(List<string> names)
        {
            foreach (string name in names)
            {
                txtLeader.Text += $"{name};";
            }
        }
    }
}
