using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HelloCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //TextBlock txtblk = new TextBlock();
            //txtblk.Text = "Hello,WPF!";
            //txtblk.FontFamily = new System.Windows.Media.FontFamily("Times New Roman");
            //txtblk.FontSize = 96;
            //txtblk.Foreground = new SolidColorBrush(Colors.Yellow);
            //txtblk.HorizontalAlignment = HorizontalAlignment.Center;
            //txtblk.VerticalAlignment = VerticalAlignment.Center;

            //txtblk.FontStyle = FontStyles.Italic;

            TextBlock txtblk = new TextBlock
            {
                Text = "Hello,WPF!",
                FontFamily = new FontFamily("Times New Roman"),
                FontSize = 96,
                FontStyle = FontStyles.Italic,
                Foreground = new SolidColorBrush(Colors.Yellow),
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            contentGrid.Children.Add(txtblk);
        }
    }
}
