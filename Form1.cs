using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        
        // Список типов фигур
        private void ListFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListFigures.SelectedIndex == 0)
                CreatingAToolboxForTheCircle();

            else if (ListFigures.SelectedIndex == 1)
                CreatingAToolboxForTheQuadrilateral();
        }
        
        // Кнопка "Добавить"
        private void AddFigure_Click(object sender, EventArgs e)
        {
            // Если не ввели данные
            if (ListFigures.Text == "Круг")
                if (textbox_points.Text == "" || textbox_color.Text == "" || textbox_radius.Text == "")
                    return;

            if (ListFigures.Text == "Четырёхугольник")
                if (textbox_points.Text == "" || textbox_color.Text == "")
                    return;

            // Добавляем нужную фигуру
            if (ListFigures.Text == "Круг")
                AddFigureCircle();
            else if (ListFigures.Text == "Четырёхугольник")
                AddFigureQuadrilateral();

            // Чистим строки ввода
            textbox_points.Text = "";
            textbox_color.Text = "";
            textbox_radius.Text = "";

            AddToTable();

            if (GeneralListFigures.GetListFigures().Length > 0) button_saveAndOpen.Text = "Сохранить";
        }

        // Кнопка "Повернуть"
        private void rotateFigures_Click(object sender, EventArgs e)
        {
            uint deg = 0;

            if (list_deg.SelectedIndex == 0)
                deg = 90;
            else if (list_deg.SelectedIndex == 1)
                deg = 180;
            else if (list_deg.SelectedIndex == 2)
                deg = 270;

            GeneralListFigures.Rotate(deg);
            UpdateTable();
        }

        // Кнопка "Масштабировать"
        private void scaleFigures_Click(object sender, EventArgs e)
        {
            int newsize = 1;

            string[] s = textbox_scale.Text.Split(' ');
            if(s.Length!=0)newsize = int.Parse(s[0]);

            GeneralListFigures.Scale(newsize);
            UpdateTable();
        }

        // Кнопка "Удалить"
        private void deleteFigure_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 1) return;

            int selectedRowCount = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 0)
            {
                dataGridView.Rows.RemoveAt(0);
                GeneralListFigures.DeleteFigure(0);
                return;
            }
            dataGridView.Rows.RemoveAt(selectedRowCount+1);
            GeneralListFigures.DeleteFigure(selectedRowCount+1);
            deleteFigure.Visible = false;
        }

        // Выбор ячейки в таблице фигур
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteFigure.Visible = true;
        }

        // Кнопка "Открыть"/"Сохранить"
        private void button_saveAndOpen_Click(object sender, EventArgs e)
        {
            string nameFile = textbox_nameFile.Text + ".bin";

            var customerJson = new BinaryFormatter();

            if (button_saveAndOpen.Text == "Сохранить")
            {
                using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
                {
                    customerJson.Serialize(file, GeneralListFigures);
                }
            }
            else if (button_saveAndOpen.Text == "Открыть")
            {
                using (var file = new FileStream(nameFile, FileMode.OpenOrCreate))
                {
                    var newList = customerJson.Deserialize(file) as VectorDocument;

                    GeneralListFigures = newList;
                    
                }
                Unpacking();
                button_saveAndOpen.Text = "Сохранить";
            }
        }

        // Кнопка "Переместить"
        private void button_move_Click(object sender, EventArgs e)
        {
            string[] m = textbox_move.Text.Split(' ');
            if (m.Length < 4) return;
            int[] move = new int[] { int.Parse(m[0]), int.Parse(m[1]), int.Parse(m[2]), int.Parse(m[3])};
            GeneralListFigures.Move(move[0], move[1], move[2], move[3]);

            UpdateTable();
        }
    }
}
