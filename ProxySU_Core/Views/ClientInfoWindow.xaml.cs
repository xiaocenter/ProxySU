﻿using ProxySU_Core.Models;
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

namespace ProxySU_Core.Views
{
    /// <summary>
    /// ClientInfoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ClientInfoWindow
    {
        Record Record { get; set; }
        public ClientInfoWindow(Record record)
        {
            InitializeComponent();
            this.Record = record;

            DataContext = this.Record;
        }
    }
}
