using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figures
{
    public partial class Window : Form
    {
        VectorDocument GeneralListFigures;

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            GeneralListFigures = new VectorDocument();
        }

        
        // Выбрать тип фигуры для создания
        private void ListFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListFigures.SelectedIndex == 0)
                CreatingAToolboxForTheCircle();

            else if (ListFigures.SelectedIndex == 1)
                CreatingAToolboxForTheQuadrilateral();
        }
        
        // Добавить фигуру в таблицу
        private void AddFigure_Click(object sender, EventArgs e)
        {
            if (ListFigures.Text == "Круг")
                AddFigureCircle();
            else if (ListFigures.Text == "Четырёхугольник")
                AddFigureQuadrilateral();
        }
    }
}
