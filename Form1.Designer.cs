
namespace figures
{
    partial class Window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelUnderTable = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.fig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleBorder = new System.Windows.Forms.GroupBox();
            this.textbox_color = new System.Windows.Forms.TextBox();
            this.label_color = new System.Windows.Forms.Label();
            this.label_xy_in_input = new System.Windows.Forms.Label();
            this.textbox_points = new System.Windows.Forms.TextBox();
            this.label_points = new System.Windows.Forms.Label();
            this.textbox_radius = new System.Windows.Forms.TextBox();
            this.label_radius = new System.Windows.Forms.Label();
            this.AddFigure = new System.Windows.Forms.Button();
            this.ListFigures = new System.Windows.Forms.ListBox();
            this.label_choiceTypeFigure = new System.Windows.Forms.Label();
            this.deleteFigure = new System.Windows.Forms.Button();
            this.rotateFigures = new System.Windows.Forms.Button();
            this.scaleFigures = new System.Windows.Forms.Button();
            this.list_deg = new System.Windows.Forms.ListBox();
            this.textbox_scale = new System.Windows.Forms.TextBox();
            this.button_saveAndOpen = new System.Windows.Forms.Button();
            this.textbox_nameFile = new System.Windows.Forms.TextBox();
            this.textbox_move = new System.Windows.Forms.TextBox();
            this.button_move = new System.Windows.Forms.Button();
            this.PanelUnderTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.simpleBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelUnderTable
            // 
            this.PanelUnderTable.Controls.Add(this.dataGridView);
            this.PanelUnderTable.Location = new System.Drawing.Point(12, 42);
            this.PanelUnderTable.Name = "PanelUnderTable";
            this.PanelUnderTable.Size = new System.Drawing.Size(886, 261);
            this.PanelUnderTable.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeight = 50;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fig,
            this.prop,
            this.per,
            this.squ});
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 21;
            this.dataGridView.Size = new System.Drawing.Size(880, 255);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // fig
            // 
            this.fig.FillWeight = 91.59882F;
            this.fig.HeaderText = "Фигура";
            this.fig.Name = "fig";
            this.fig.ReadOnly = true;
            // 
            // prop
            // 
            this.prop.FillWeight = 169.9667F;
            this.prop.HeaderText = "Параметры";
            this.prop.Name = "prop";
            this.prop.ReadOnly = true;
            // 
            // per
            // 
            this.per.FillWeight = 77.52076F;
            this.per.HeaderText = "Периметр";
            this.per.Name = "per";
            this.per.ReadOnly = true;
            // 
            // squ
            // 
            this.squ.FillWeight = 60.9137F;
            this.squ.HeaderText = "Площадь";
            this.squ.Name = "squ";
            this.squ.ReadOnly = true;
            // 
            // simpleBorder
            // 
            this.simpleBorder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.simpleBorder.Controls.Add(this.textbox_color);
            this.simpleBorder.Controls.Add(this.label_color);
            this.simpleBorder.Controls.Add(this.label_xy_in_input);
            this.simpleBorder.Controls.Add(this.textbox_points);
            this.simpleBorder.Controls.Add(this.label_points);
            this.simpleBorder.Controls.Add(this.textbox_radius);
            this.simpleBorder.Controls.Add(this.label_radius);
            this.simpleBorder.Controls.Add(this.AddFigure);
            this.simpleBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleBorder.Location = new System.Drawing.Point(565, 324);
            this.simpleBorder.Name = "simpleBorder";
            this.simpleBorder.Size = new System.Drawing.Size(333, 118);
            this.simpleBorder.TabIndex = 7;
            this.simpleBorder.TabStop = false;
            this.simpleBorder.Text = "Создание";
            // 
            // textbox_color
            // 
            this.textbox_color.Location = new System.Drawing.Point(88, 85);
            this.textbox_color.Name = "textbox_color";
            this.textbox_color.Size = new System.Drawing.Size(100, 22);
            this.textbox_color.TabIndex = 17;
            this.textbox_color.Visible = false;
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Location = new System.Drawing.Point(112, 66);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(40, 16);
            this.label_color.TabIndex = 16;
            this.label_color.Text = "Цвет";
            this.label_color.Visible = false;
            // 
            // label_xy_in_input
            // 
            this.label_xy_in_input.AutoSize = true;
            this.label_xy_in_input.Location = new System.Drawing.Point(7, 37);
            this.label_xy_in_input.Name = "label_xy_in_input";
            this.label_xy_in_input.Size = new System.Drawing.Size(34, 16);
            this.label_xy_in_input.TabIndex = 15;
            this.label_xy_in_input.Text = "x y =";
            this.label_xy_in_input.Visible = false;
            // 
            // textbox_points
            // 
            this.textbox_points.Location = new System.Drawing.Point(47, 37);
            this.textbox_points.Name = "textbox_points";
            this.textbox_points.Size = new System.Drawing.Size(51, 22);
            this.textbox_points.TabIndex = 14;
            this.textbox_points.Visible = false;
            // 
            // label_points
            // 
            this.label_points.AutoSize = true;
            this.label_points.Location = new System.Drawing.Point(50, 18);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(48, 16);
            this.label_points.TabIndex = 13;
            this.label_points.Text = "Точки";
            this.label_points.Visible = false;
            // 
            // textbox_radius
            // 
            this.textbox_radius.Location = new System.Drawing.Point(256, 37);
            this.textbox_radius.Name = "textbox_radius";
            this.textbox_radius.Size = new System.Drawing.Size(52, 22);
            this.textbox_radius.TabIndex = 12;
            this.textbox_radius.Visible = false;
            // 
            // label_radius
            // 
            this.label_radius.AutoSize = true;
            this.label_radius.Location = new System.Drawing.Point(253, 18);
            this.label_radius.Name = "label_radius";
            this.label_radius.Size = new System.Drawing.Size(56, 16);
            this.label_radius.TabIndex = 11;
            this.label_radius.Text = "Радиус";
            this.label_radius.Visible = false;
            // 
            // AddFigure
            // 
            this.AddFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFigure.Location = new System.Drawing.Point(234, 78);
            this.AddFigure.Name = "AddFigure";
            this.AddFigure.Size = new System.Drawing.Size(93, 34);
            this.AddFigure.TabIndex = 10;
            this.AddFigure.Text = "Добавить";
            this.AddFigure.UseVisualStyleBackColor = true;
            this.AddFigure.Visible = false;
            this.AddFigure.Click += new System.EventHandler(this.AddFigure_Click);
            // 
            // ListFigures
            // 
            this.ListFigures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListFigures.FormattingEnabled = true;
            this.ListFigures.ItemHeight = 20;
            this.ListFigures.Items.AddRange(new object[] {
            "Круг",
            "Четырёхугольник"});
            this.ListFigures.Location = new System.Drawing.Point(34, 359);
            this.ListFigures.Name = "ListFigures";
            this.ListFigures.Size = new System.Drawing.Size(167, 24);
            this.ListFigures.TabIndex = 8;
            this.ListFigures.SelectedIndexChanged += new System.EventHandler(this.ListFigures_SelectedIndexChanged);
            // 
            // label_choiceTypeFigure
            // 
            this.label_choiceTypeFigure.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_choiceTypeFigure.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_choiceTypeFigure.Location = new System.Drawing.Point(30, 324);
            this.label_choiceTypeFigure.Name = "label_choiceTypeFigure";
            this.label_choiceTypeFigure.Size = new System.Drawing.Size(161, 23);
            this.label_choiceTypeFigure.TabIndex = 9;
            this.label_choiceTypeFigure.Text = "Выберите тип";
            this.label_choiceTypeFigure.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // deleteFigure
            // 
            this.deleteFigure.Location = new System.Drawing.Point(34, 413);
            this.deleteFigure.Name = "deleteFigure";
            this.deleteFigure.Size = new System.Drawing.Size(75, 23);
            this.deleteFigure.TabIndex = 10;
            this.deleteFigure.Text = "Удалить";
            this.deleteFigure.UseVisualStyleBackColor = true;
            this.deleteFigure.Visible = false;
            this.deleteFigure.Click += new System.EventHandler(this.deleteFigure_Click);
            // 
            // rotateFigures
            // 
            this.rotateFigures.Location = new System.Drawing.Point(404, 325);
            this.rotateFigures.Name = "rotateFigures";
            this.rotateFigures.Size = new System.Drawing.Size(83, 28);
            this.rotateFigures.TabIndex = 11;
            this.rotateFigures.Text = "Повернуть";
            this.rotateFigures.UseVisualStyleBackColor = true;
            this.rotateFigures.Click += new System.EventHandler(this.rotateFigures_Click);
            // 
            // scaleFigures
            // 
            this.scaleFigures.Location = new System.Drawing.Point(404, 375);
            this.scaleFigures.Name = "scaleFigures";
            this.scaleFigures.Size = new System.Drawing.Size(104, 27);
            this.scaleFigures.TabIndex = 12;
            this.scaleFigures.Text = "Масштабировать";
            this.scaleFigures.UseVisualStyleBackColor = true;
            this.scaleFigures.Click += new System.EventHandler(this.scaleFigures_Click);
            // 
            // list_deg
            // 
            this.list_deg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_deg.FormattingEnabled = true;
            this.list_deg.ItemHeight = 20;
            this.list_deg.Items.AddRange(new object[] {
            "90",
            "180",
            "270"});
            this.list_deg.Location = new System.Drawing.Point(330, 325);
            this.list_deg.Name = "list_deg";
            this.list_deg.Size = new System.Drawing.Size(57, 24);
            this.list_deg.TabIndex = 13;
            // 
            // textbox_scale
            // 
            this.textbox_scale.Location = new System.Drawing.Point(335, 379);
            this.textbox_scale.Name = "textbox_scale";
            this.textbox_scale.Size = new System.Drawing.Size(51, 20);
            this.textbox_scale.TabIndex = 18;
            // 
            // button_saveAndOpen
            // 
            this.button_saveAndOpen.Location = new System.Drawing.Point(34, 9);
            this.button_saveAndOpen.Name = "button_saveAndOpen";
            this.button_saveAndOpen.Size = new System.Drawing.Size(75, 23);
            this.button_saveAndOpen.TabIndex = 19;
            this.button_saveAndOpen.Text = "Открыть";
            this.button_saveAndOpen.UseVisualStyleBackColor = true;
            this.button_saveAndOpen.Click += new System.EventHandler(this.button_saveAndOpen_Click);
            // 
            // textbox_nameFile
            // 
            this.textbox_nameFile.Location = new System.Drawing.Point(115, 12);
            this.textbox_nameFile.Name = "textbox_nameFile";
            this.textbox_nameFile.Size = new System.Drawing.Size(100, 20);
            this.textbox_nameFile.TabIndex = 20;
            // 
            // textbox_move
            // 
            this.textbox_move.Location = new System.Drawing.Point(294, 420);
            this.textbox_move.Name = "textbox_move";
            this.textbox_move.Size = new System.Drawing.Size(92, 20);
            this.textbox_move.TabIndex = 22;
            // 
            // button_move
            // 
            this.button_move.Location = new System.Drawing.Point(404, 415);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(104, 27);
            this.button_move.TabIndex = 21;
            this.button_move.Text = "Переместить";
            this.button_move.UseVisualStyleBackColor = true;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.textbox_move);
            this.Controls.Add(this.button_move);
            this.Controls.Add(this.textbox_nameFile);
            this.Controls.Add(this.button_saveAndOpen);
            this.Controls.Add(this.textbox_scale);
            this.Controls.Add(this.list_deg);
            this.Controls.Add(this.scaleFigures);
            this.Controls.Add(this.rotateFigures);
            this.Controls.Add(this.deleteFigure);
            this.Controls.Add(this.ListFigures);
            this.Controls.Add(this.label_choiceTypeFigure);
            this.Controls.Add(this.simpleBorder);
            this.Controls.Add(this.PanelUnderTable);
            this.Name = "Window";
            this.Text = "Лабораторные 12-13";
            this.Load += new System.EventHandler(this.Window_Load);
            this.PanelUnderTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.simpleBorder.ResumeLayout(false);
            this.simpleBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelUnderTable;
        private System.Windows.Forms.GroupBox simpleBorder;
        private System.Windows.Forms.ListBox ListFigures;
        private System.Windows.Forms.Label label_choiceTypeFigure;
        private System.Windows.Forms.Button AddFigure;
        private System.Windows.Forms.TextBox textbox_radius;
        private System.Windows.Forms.Label label_radius;
        private System.Windows.Forms.Label label_xy_in_input;
        private System.Windows.Forms.TextBox textbox_points;
        private System.Windows.Forms.Label label_points;
        private System.Windows.Forms.TextBox textbox_color;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fig;
        private System.Windows.Forms.DataGridViewTextBoxColumn prop;
        private System.Windows.Forms.DataGridViewTextBoxColumn per;
        private System.Windows.Forms.DataGridViewTextBoxColumn squ;
        private System.Windows.Forms.Button deleteFigure;
        private System.Windows.Forms.Button rotateFigures;
        private System.Windows.Forms.Button scaleFigures;
        private System.Windows.Forms.ListBox list_deg;
        private System.Windows.Forms.TextBox textbox_scale;
        private System.Windows.Forms.Button button_saveAndOpen;
        private System.Windows.Forms.TextBox textbox_nameFile;
        private System.Windows.Forms.TextBox textbox_move;
        private System.Windows.Forms.Button button_move;
    }
}

