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
    /// RoutingRecordWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RoutingRecordWindow : Window
    {
        public RoutingRecordWindow(Record record)
        {
            InitializeComponent();
            btnClose.Click += CloseWindow;
            btnCancel.Click += CloseWindow;
            txtRecordID.Text = record.RecordNo.ToString();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
