using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;

namespace WPF
{
    public class TestCAD
    {
        [CommandMethod("testcad")]
        public void MainTest()
        {
            Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage("成功打开");
            var window = new MainWindow();
            Application.ShowModelessWindow(window);
        }
    }
}