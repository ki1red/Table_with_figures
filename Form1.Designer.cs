
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
            this.TableFigures = new System.Windows.Forms.TableLayoutPanel();
            this.PanelUnderTable = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleBorder = new System.Windows.Forms.GroupBox();
            this.label_xy_in_input = new System.Windows.Forms.Label();
            this.textbox_points = new System.Windows.Forms.TextBox();
            this.label_points = new System.Windows.Forms.Label();
            this.textbox_radius = new System.Windows.Forms.TextBox();
            this.label_radius = new System.Windows.Forms.Label();
            this.AddFigure = new System.Windows.Forms.Button();
            this.ListFigures = new System.Windows.Forms.ListBox();
            this.label_choiceTypeFigure = new System.Windows.Forms.Label();
            this.textbox_color = new System.Windows.Forms.TextBox();
            this.label_color = new System.Windows.Forms.Label();
            this.PanelUnderTable.SuspendLayout();
            this.simpleBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableFigures
            // 
            this.TableFigures.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TableFigures.ColumnCount = 5;
            this.TableFigures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.TableFigures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.TableFigures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.TableFigures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.TableFigures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.TableFigures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TableFigures.Location = new System.Drawing.Point(3, 3);
            this.TableFigures.Name = "TableFigures";
            this.TableFigures.RowCount = 1;
            this.TableFigures.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableFigures.Size = new System.Drawing.Size(880, 255);
            this.TableFigures.TabIndex = 0;
            // 
            // PanelUnderTable
            // 
            this.PanelUnderTable.Controls.Add(this.TableFigures);
            this.PanelUnderTable.Location = new System.Drawing.Point(12, 42);
            this.PanelUnderTable.Name = "PanelUnderTable";
            this.PanelUnderTable.Size = new System.Drawing.Size(886, 261);
            this.PanelUnderTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фигура";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(194, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Параметры";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(399, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Периметр";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(721, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Посл.дейст.";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(560, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Площадь";
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
            this.simpleBorder.Text = "Взаимодействие";
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
            this.ListFigures.Size = new System.Drawing.Size(157, 24);
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
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.ListFigures);
            this.Controls.Add(this.label_choiceTypeFigure);
            this.Controls.Add(this.simpleBorder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelUnderTable);
            this.Name = "Window";
            this.Text = "Лабораторные 12-13";
            this.Load += new System.EventHandler(this.Window_Load);
            this.PanelUnderTable.ResumeLayout(false);
            this.simpleBorder.ResumeLayout(false);
            this.simpleBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableFigures;
        private System.Windows.Forms.Panel PanelUnderTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
    }
}

