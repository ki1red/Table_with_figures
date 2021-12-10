using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figures
{
    public partial class Window : Form
    {
        // Взаимодействие
        public void CreatingAToolboxForTheCircle()
        {

            label_points.Text = "Точка";
            label_points.Visible = true;
            textbox_points.Text = "";
            textbox_points.Visible = true;
            textbox_points.Size = new System.Drawing.Size(50, textbox_points.Size.Height);
            label_xy_in_input.Visible = true;

            label_color.Visible = true;
            textbox_color.Text = "";
            textbox_color.Visible = true;

            // Включение радиуса
            label_radius.Visible = true;
            textbox_radius.Text = "";
            textbox_radius.Visible = true;

            AddFigure.Visible = true;

        }

        // Взаимодействие
        public void CreatingAToolboxForTheQuadrilateral()
        {

            label_points.Text = "Точки";
            label_points.Visible = true;
            textbox_points.Text = "";
            textbox_points.Visible = true;
            textbox_points.Size = new System.Drawing.Size(150, textbox_points.Size.Height);
            label_xy_in_input.Visible = true;

            label_color.Visible = true;
            textbox_color.Text = "";
            textbox_color.Visible = true;

            // Отключение радиуса
            label_radius.Visible = false;
            textbox_radius.Text = "";
            textbox_radius.Visible = false;

            AddFigure.Visible = true;
        }

        // Создание и добавление фигуры в массив
        public void AddFigureCircle()
        {
            // Точка и радиус
            string[] p = textbox_points.Text.Split(' ');
            string r = textbox_radius.Text;

            Point point = new Point(double.Parse(p[0]), double.Parse(p[1]));
            // Цвет
            string[] c = textbox_color.Text.Split(' ');
            int[] col = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
                col[i] = int.Parse(c[i]);
            Color color = new Color(col[0], col[1], col[2], col[3]);

            // Круг
            Circle circle = new Circle(point, double.Parse(r), color);

            GeneralListFigures.AddFigure(circle);
        }

        // Создание и добавление фигуры в массив
        public void AddFigureQuadrilateral()
        {
            // Точки
            string[] p = textbox_points.Text.Split(' ');
            double[] x = new double[p.Length / 2];
            double[] y = new double[p.Length / 2];
            int j = -1, g = -1;

            for (int i = 1; i <= 8; i++)
            {
                // x
                if (i % 2 == 1)
                    x[++j] = double.Parse(p[i - 1]);
                // y
                if (i % 2 == 0)
                    y[++g] = double.Parse(p[i - 1]);
            }
            Point[] points = new Point[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                points[i] = new Point(x[i], y[i]);
            }

            // Цвет
            string[] c = textbox_color.Text.Split(' ');
            int[] col = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
                col[i] = int.Parse(c[i]);
            Color color = new Color(col[0], col[1], col[2], col[3]);

            // Четырёхугольник
            Quadrilateral kvadrat = new Quadrilateral(points, color);

            GeneralListFigures.AddFigure(kvadrat);
        }

        public void AddToTable()
        {
            int lengthVD = GeneralListFigures.GetListFigures().Length;

            string[] row = new string[4];

            if (Convert.ToString(GeneralListFigures.ChoiceFigure(lengthVD - 1).GetType()) == "figures.Circle")
            {
                row[0] = "Круг";
                string color = "";
                string point = "";
                string radius = "";

                // Строка параметров цвета
                int[] col = GeneralListFigures.ChoiceFigure(lengthVD - 1).GetColor();
                for (int i = 0; i < col.Length; i++)
                {
                    color += Convert.ToString(col[i]);
                    color += " ";
                }
                
                // Договор
                Circle a = GeneralListFigures.ChoiceFigure(lengthVD - 1) as Circle;

                // Строка параметров центра окружности
                point += Convert.ToString(a.GetCentre().GetX()) + " " + Convert.ToString(a.GetCentre().GetY());

                // Строка длины радиуса
                radius += Convert.ToString(a.GetRadius());

                row[1] = "Цвет: " + color + "; Центр: (" + point + "); Радиус: " + radius;

                row[2] = Convert.ToString(a.GetPerimeter());

                row[3] = Convert.ToString(a.GetSquare());


            }

            else if (Convert.ToString(GeneralListFigures.ChoiceFigure(lengthVD - 1).GetType()) == "figures.Quadrilateral")
            {
                row[0] = "Четырёхугольник";
                string color = "";
                string points = "";

                // Строка параметров цвета
                int[] col = GeneralListFigures.ChoiceFigure(lengthVD - 1).GetColor();
                for (int i = 0; i < col.Length; i++)
                {
                    color += Convert.ToString(col[i]);
                    color += " ";
                }

                // Договор
                Quadrilateral a = GeneralListFigures.ChoiceFigure(lengthVD - 1) as Quadrilateral;

                // Строка координат точек
                string[] p = new string[4];
                Point[] pVD = a.GetPoints();
                for (int i=0;i<p.Length;i++)
                {
                    p[i]= Convert.ToString("("+pVD[i].GetX()) + " " + Convert.ToString(pVD[i].GetY()+")");
                }
                points += p[0] + "," + p[1] + "," + p[2] + "," + p[3];


                row[1] = "Цвет: " + color + "; Tочки: " + points;

                row[2] = Convert.ToString(a.GetPerimeter());

                row[3] = Convert.ToString(a.GetSquare());

            }
            dataGridView.Rows.Add(row);
        }
    }
}
