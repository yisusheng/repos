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

namespace TapAndShowPoint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            Point pt = e.GetPosition(this);

            Ellipse ellipse = new()
            {
                Width = 3,
                Height = 3,
                Fill = this.Foreground
            };

            Canvas.SetLeft(ellipse, pt.X);
            Canvas.SetTop(ellipse, pt.Y);
            canvas.Children.Add(ellipse);

            TextBlock textBlock = new()
            {
                Text = String.Format("({0})", pt),
                FontSize = 24
            };

            Canvas.SetLeft(textBlock, pt.X);
            Canvas.SetTop(textBlock, pt.Y);
            canvas.Children.Add(textBlock);

            e.Handled = true;
            base.OnMouseLeftButtonUp(e);
        }
    }
}