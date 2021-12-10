using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Circle : Figure
    {
        private Point centre;
        private double radius;

        // Конструктор с параметрами
        public Circle(Point _centre, double _radius, Color _color) : base(_color)
        {
            this.centre = _centre;
            this.radius = _radius;
            if (_radius <= 0) this.radius = 1;
        }

        // Установить новый радиус
        public bool SetNewRadius(double newRadius)
        {
            if (newRadius <= 0) 
                return false;

            this.radius = newRadius;
            return true;
        }

        // Установить новый центр
        private void SetNewCentre(Point newCentre)
        {
            this.centre.SetNewSite(newCentre.GetX(), newCentre.GetY());
        }

        // Изменить размер круга
        public override void EditSize(double arg)
        {
            SetNewRadius(radius * arg);
        }

        public override void Rotate(uint arg)
        {}

        // Изменить координаты
        public override void MoveFigure(int x, int y)
        {
            //Point newCoordinates = new Point(x, y);
            //SetNewCentre(newCoordinates);

            centre.SetNewSite(centre.GetX()+x,centre.GetY()+y);
        }

        // Узнать периметр
        public override double GetPerimeter()
        {
            return (2 * this.radius * Math.PI);
        }

        // Узнать площадь
        public override double GetSquare()
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        // Узнать точку-центр
        public Point GetCentre()
        {
            return this.centre;
        }

        // Узнать радиус
        public double GetRadius()
        {
            return this.radius;
        }
    }
}
