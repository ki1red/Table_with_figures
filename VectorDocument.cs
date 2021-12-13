using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
    [Serializable]
    public class VectorDocument
    {
        private Figure[] figures; 
        
        // Конструктор с параметрами
        public VectorDocument(Figure[] _figures)
        {
            int length = _figures.Length;

            Array.Resize(ref this.figures, length);

            for (int i = 0; i < length; i++)
            {
                this.figures[i] = _figures[i];
            }
        }

        // Конструктор по умолчанию
        public VectorDocument()
        {
            figures = new Figure[0];
        }

        // Перенести
        public void Move(int right, int left, int up, int down)
        {
            int x = right - left;
            int y = up - down;

            for (int i = 0; i < this.figures.Length;i++)
                this.figures[i].MoveFigure(x, y);
        }

        // Масштабировать
        public void Scale(int size)
        {
            for (int i = 0; i < this.figures.Length; i++)
                this.figures[i].EditSize(size);
        }

        // Повернуть
        public void Rotate(uint arg)
        {
            for (int i = 0; i < this.figures.Length; i++)
                this.figures[i].Rotate(arg);
        }

        // Добавить фигуру
        public void AddFigure(Figure figure)
        {
            Array.Resize(ref this.figures, this.figures.Length + 1);

            this.figures[this.figures.Length - 1] = figure;
        }

        // Удалить фигуру
        public void DeleteFigure(int index)
        {
            Figure[] copyFigures = new Figure[this.figures.Length - 1];

            //for (int i = 0; i < this.figures.Length; i++)
            //    Console.Write($"{this.figures[i]} ");
            //Console.WriteLine();

            // Копируем элементы до выбранного
            for (int i = 0; i < index; i++)
                copyFigures[i] = this.figures[i];

            // Копируем элементы после выбранного
            for (int i = index + 1; i < this.figures.Length; i++)
                copyFigures[i-1] = this.figures[i];

            // Меняем размер на новый и обновляем массив
            Array.Resize(ref this.figures, copyFigures.Length);
            for (int i = 0; i < this.figures.Length; i++)
                this.figures[i] = copyFigures[i];

            //for (int i = 0; i < this.figures.Length; i++)
            //    Console.Write($"{this.figures[i]} ");
            //Console.WriteLine();
        }

        // Выбрать фигуру
        public Figure ChoiceFigure(int index)
        {
            return figures[index];
        }

        // Получить список фигур
        public Figure[] GetListFigures()
        {
            return this.figures;
        }
    }
}
