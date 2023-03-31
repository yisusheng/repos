using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StrippedDownHello
{
    public class App:Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            StrippedDownHello.App app = new StrippedDownHello.App();
            Window window = new Window();
            window.Show();
            app.Run();
        }
    }
}
