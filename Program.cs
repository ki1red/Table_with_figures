using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figures
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
            /*Color col = new Color(255,255,255,255);
            Point one = new Point(2, 10);
            Point two = new Point(10, 8);
            Point three = new Point(8, 0);
            Point four = new Point(0, 2);
            Point five = new Point(2, 10);
            Point six = new Point(10, 8);
            Point seven = new Point(8, 0);
            Point eight = new Point(0, 2);
            Point[] list1 = new Point[] { one, two, three, four };
            Point[] list2 = new Point[] { five, six, seven, eight };
            
            Quadrilateral a = new Quadrilateral(list1, col);
            Quadrilateral b = new Quadrilateral(list2, col);
            Circle c = new Circle(three, 3, col);
            Console.WriteLine(a.GetSquare());
            VectorDocument doc = new VectorDocument();
            doc.AddFigure(a);
            doc.AddFigure(b);
            doc.AddFigure(c);

            
            
            doc.DeleteFigure(0);*/
        }
    }
}
