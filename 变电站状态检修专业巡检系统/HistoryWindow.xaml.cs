﻿using Svg2Xaml;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// HistoryWindow.xaml 的交互逻辑
    /// </summary>
    public partial class HistoryWindow : Window
    {
        public HistoryWindow(string map)
        {
            InitializeComponent();

            btnClose.Click += (s, e) => 
            {
                Close();
            };

            using (FileStream fs = new FileStream($"SVG/{map}.svg", FileMode.Open, FileAccess.Read))
            {
                imgMap.Source = SvgReader.Load(fs);
            }
        }
    }
}
