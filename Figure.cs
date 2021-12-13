using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    [Serializable]
    public abstract class Figure
    {
        private Color color;

        // Конструктор с параметром
        public Figure(Color _color)
        {
            this.color = _color;
        }

        // Установить новый цвет
        public void SetNewColor(Color newColor)
        {
            color.SetNewOptions(newColor.GetRed(),newColor.GetGreen(),newColor.GetBlue(), newColor.GetTransparency());
        }

        // Получить массив параметров цвета
        public int[] GetColor()
        {
            int[] col = new int[] { color.GetRed(), color.GetGreen(), color.GetBlue(), color.GetTransparency() };
            return col;
        }

        // Узнать периметр
        public abstract double GetPerimeter();

        // Узнать площадь
        public abstract double GetSquare();

        // Новые координаты
        public abstract void MoveFigure(int x, int y);

        // Повернуть фигуру
        public abstract void Rotate(uint arg);

        // Изменить размер
        public abstract void EditSize(double arg);
    }
}
