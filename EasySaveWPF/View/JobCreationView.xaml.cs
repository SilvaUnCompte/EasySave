﻿using System;
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

namespace EasySave.View
{
    public partial class JobCreationView : UserControl
    {
        MainWindow.DUpdateViewJobList updateViewJobListDelegate;
        public JobCreationView() { InitializeComponent(); }
        public JobCreationView(MainWindow.DUpdateViewJobList updateViewJobListDelegate)
        {
            InitializeComponent();
            this.updateViewJobListDelegate = updateViewJobListDelegate;
        }

        private void jobCreation_priority_checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
