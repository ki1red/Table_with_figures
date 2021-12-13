using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    [Serializable]
    public class Point
    {
        
        private double x;
        private double y;

        // Конструктор с параметрами
        public Point(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        // Изменение координат
        public void SetNewSite(double newX, double newY)
        {
            this.x = newX;
            this.y = newY;
        }

        // Установить X
        public void SetX(double x)
        {
            this.x = x;
        }

        // Установить Y
        public void SetY(double y)
        {
            this.y = y;
        }

        // Узнать X
        public double GetX()
        {
            return this.x;
        }

        // Узнать Y
        public double GetY()
        {
            return this.y;
        }

        /*public static Point operator= (Point b)
        {
            return (new Point(b.GetX(),b.GetY()));
        }*/
    }
}
