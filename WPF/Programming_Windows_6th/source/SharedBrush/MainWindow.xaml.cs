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

namespace SharedBrush
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //TextBlock txtblk = (this.Content as Grid).Children[1] as TextBlock;
            //LinearGradientBrush brush = txtblk.Foreground as LinearGradientBrush;
            //brush.StartPoint = new Point(0, 1);
            //brush.EndPoint = new Point(0, 0);
        }
    }
}
