using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    class Quadrilateral : Figure
    {
        private Point[] points;

        // Для расчёта длины от точки до точки
        private double PythagoreanTheorem(Point first, Point second)
        {
            double l;
            double a, b;

            a = Math.Abs(first.GetX() - second.GetX());
            b = Math.Abs(first.GetY() - second.GetY());

            l = Math.Sqrt( Math.Pow(a,2)+Math.Pow(b,2) );

            return l;
        }

        // Периметр треугольника
        /*private double GetPerimeterTriangle(Point first, Point second, Point third)
        {
            double a = PythagoreanTheorem(first, second);
            double b = PythagoreanTheorem(second, third);
            double c = PythagoreanTheorem(third, first);

            return (a + b + c);
        }*/

        // Конструктор с параметрами
        public Quadrilateral(Point[] _points, Color _color):base(_color)
        {
            int length = _points.Length;
            Array.Resize( ref this.points, 4);
            
            // Если не хватает точек
            if (length < 4)
            {
                this.points = new Point[] { new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0) };
                return;
            }
            for (int i = 0; i < 4; i++)
            {
                this.points[i] = _points[i];
            }
        }

        // 
        private bool SetNewPoints(Point[] newPoints)
        {
            int length = newPoints.Length;
            // Если не хватает точек
            if (length < 4)
                return false;

            for (int i = 0; i < 4; i++)
            {
                this.points[i] = newPoints[i];
            }

            return true;
        }

        // Изменить размер четырёхугольника
        public override void EditSize(double arg)
        {
            double dx, dy;

            for (int i=1; i < 4; i++)
	        {
                dx = points[i].GetX() - points[0].GetX();
                dy = points[i].GetY() - points[0].GetY();

                points[i].SetX((points[i].GetX() - dx) * arg + dx);
                points[i].SetY((points[i].GetY() - dy) * arg + dy);
            }
        }

        // Изменить координаты
        public override void MoveFigure(int x, int y)
        {
            for (int i = 1; i < points.Length; i++)
                points[i].SetNewSite(points[i].GetX()+x, points[i].GetY()+y);
        }

        // Повернуть фигуру
        public override void Rotate(uint arg)
        {
            double tmp = new double();
            switch (arg)
            {
                case 90:


                    for (int i=0; i < 4; i++)
		{
                        tmp = points[i].GetX();
                        points[i].SetY(0 - points[i].GetY());
                        points[i].SetY(tmp);
                    }

                    break;
                case 180:
                    for (int i=0; i < 4; i++)
		{
                        points[i].SetX(0 - points[i].GetX());
                        points[i].SetY( 0 - points[i].GetY());
                    }
                    break;
                case 270:
                    for (int i=0; i < 4; i++)
                        points[i].SetY(0 - points[i].GetY());
                    break;
                default:
                    Console.WriteLine("Неправильный аргумент. Повернуть можно только на 90, 180 или 270 градусов.");
                    break;
            }
        }

        // Узнать периметр
        public override double GetPerimeter()
        {
            double first, second, third, fourth;

            first = PythagoreanTheorem(points[0], points[1]);
            second = PythagoreanTheorem(points[1], points[2]);
            third = PythagoreanTheorem(points[2], points[3]);
            fourth = PythagoreanTheorem(points[3], points[0]);

            return (first+second+third+fourth);
        }

        // Узнать площадь
        /*public override double GetSquare()
        {
            double triangleFirst = GetPerimeterTriangle(points[0],points[1],points[2]) / 2;
            double a = PythagoreanTheorem(points[0], points[1]), 
                b = PythagoreanTheorem(points[1], points[2]), 
                c = PythagoreanTheorem(points[2], points[0]);

            double SFirst = Math.Sqrt(triangleFirst * (triangleFirst - a) * (triangleFirst - b) * (triangleFirst - c));

            double triangleSecond = GetPerimeterTriangle(points[2], points[3], points[0]) / 2;
            a = PythagoreanTheorem(points[2], points[3]);
            b = PythagoreanTheorem(points[3], points[0]); 
            c = PythagoreanTheorem(points[0], points[2]);

            double SSecond = Math.Sqrt(triangleSecond * (triangleSecond - a) * (triangleSecond - b) * (triangleSecond - c));

            return (SFirst+SSecond);
        }*/

        public override double GetSquare()
        {
            double half_perimeter = GetPerimeter() / 2;
            double area = 1;

            for (uint i=1; i < 5; i++)
	        {
                Console.WriteLine("made an iteration");
                area = area * (half_perimeter - Math.Sqrt(Math.Pow(points[i % 4].GetX() - points[(i - 1) % 4].GetX(), 2.0) + Math.Pow(points[i % 4].GetY() - points[(i - 1) % 4].GetY(), 2.0)));
            }
            return Math.Sqrt(area);
        }

        // Узнать набор точек
        public Point[] GetPoints()
        {
            return this.points;
        }


    }
}
