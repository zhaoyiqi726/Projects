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
    /// RoutingWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RoutingPlanWindow : Window
    {
        public RoutingPlanWindow(User currentUser)
        {
            InitializeComponent();

            btnClose.Click += (s, e) => 
            {
                Close();
            };

            btnRoute.Click += (s, e) =>
            {
                new RoutingRecordWindow(RecordUtility.GetRecord((dgRoutingPlan.SelectedItem as Plan).PlanID), true).ShowDialog();
            };

            btnSpecial.Click += (s, e) =>
            {
                new RoutingSpecialRecordWindow(RecordUtility.GetRecord((dgRoutingPlan.SelectedItem as Plan).PlanID), true).ShowDialog();
            };

            dgRoutingPlan.ItemsSource = PlanUtility.GetPlans();
        }
    }
}
