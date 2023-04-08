namespace Lab3_Check_
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьДанныеИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вклОтклПриветсвияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxN = new System.Windows.Forms.GroupBox();
            this.textBox_X2 = new System.Windows.Forms.TextBox();
            this.textBox_X1 = new System.Windows.Forms.TextBox();
            this.pointY = new System.Windows.Forms.Label();
            this.minX = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.minChart = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colummY2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_H = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBoxN.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(6, 21);
            this.chart.Name = "chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Black;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.LegendText = "Бернулли";
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "Бернулли";
            series2.Name = "Series2";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(583, 416);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            title1.Name = "Title1";
            title1.Text = "Лемниската Бернулли";
            this.chart.Titles.Add(title1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(552, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Построить график";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьГрафикToolStripMenuItem,
            this.очиститьГрафикToolStripMenuItem,
            this.сохранитьДанныеToolStripMenuItem,
            this.загрузитьДанныеИзФайлаToolStripMenuItem,
            this.toolStripSeparator1});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // построитьГрафикToolStripMenuItem
            // 
            this.построитьГрафикToolStripMenuItem.Name = "построитьГрафикToolStripMenuItem";
            this.построитьГрафикToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.построитьГрафикToolStripMenuItem.Text = "Построить график";
            this.построитьГрафикToolStripMenuItem.Click += new System.EventHandler(this.построитьГрафикToolStripMenuItem_Click);
            // 
            // очиститьГрафикToolStripMenuItem
            // 
            this.очиститьГрафикToolStripMenuItem.Name = "очиститьГрафикToolStripMenuItem";
            this.очиститьГрафикToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.очиститьГрафикToolStripMenuItem.Text = "Очистить график";
            this.очиститьГрафикToolStripMenuItem.Click += new System.EventHandler(this.очиститьГрафикToolStripMenuItem_Click);
            // 
            // сохранитьДанныеToolStripMenuItem
            // 
            this.сохранитьДанныеToolStripMenuItem.Name = "сохранитьДанныеToolStripMenuItem";
            this.сохранитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.сохранитьДанныеToolStripMenuItem.Text = "Сохранить данные";
            this.сохранитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДанныеToolStripMenuItem_Click);
            // 
            // загрузитьДанныеИзФайлаToolStripMenuItem
            // 
            this.загрузитьДанныеИзФайлаToolStripMenuItem.Name = "загрузитьДанныеИзФайлаToolStripMenuItem";
            this.загрузитьДанныеИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.загрузитьДанныеИзФайлаToolStripMenuItem.Text = "Загрузить данные из файла";
            this.загрузитьДанныеИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.загрузитьДанныеИзФайлаToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(281, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вклОтклПриветсвияToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // вклОтклПриветсвияToolStripMenuItem
            // 
            this.вклОтклПриветсвияToolStripMenuItem.Name = "вклОтклПриветсвияToolStripMenuItem";
            this.вклОтклПриветсвияToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.вклОтклПриветсвияToolStripMenuItem.Text = "Вкл/Откл приветсвия";
            this.вклОтклПриветсвияToolStripMenuItem.Click += new System.EventHandler(this.вклОтклПриветсвияToolStripMenuItem_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.chart);
            this.groupBox.Location = new System.Drawing.Point(12, 31);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(609, 453);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "График";
            // 
            // groupBoxN
            // 
            this.groupBoxN.Controls.Add(this.textBox_X2);
            this.groupBoxN.Controls.Add(this.textBox_X1);
            this.groupBoxN.Controls.Add(this.pointY);
            this.groupBoxN.Controls.Add(this.minX);
            this.groupBoxN.Location = new System.Drawing.Point(23, 21);
            this.groupBoxN.Name = "groupBoxN";
            this.groupBoxN.Size = new System.Drawing.Size(298, 89);
            this.groupBoxN.TabIndex = 5;
            this.groupBoxN.TabStop = false;
            this.groupBoxN.Text = "Границы";
            // 
            // textBox_X2
            // 
            this.textBox_X2.Location = new System.Drawing.Point(64, 50);
            this.textBox_X2.Name = "textBox_X2";
            this.textBox_X2.Size = new System.Drawing.Size(100, 22);
            this.textBox_X2.TabIndex = 6;
            // 
            // textBox_X1
            // 
            this.textBox_X1.Location = new System.Drawing.Point(64, 22);
            this.textBox_X1.Name = "textBox_X1";
            this.textBox_X1.Size = new System.Drawing.Size(100, 22);
            this.textBox_X1.TabIndex = 5;
            // 
            // pointY
            // 
            this.pointY.AutoSize = true;
            this.pointY.Location = new System.Drawing.Point(8, 53);
            this.pointY.Name = "pointY";
            this.pointY.Size = new System.Drawing.Size(51, 16);
            this.pointY.TabIndex = 4;
            this.pointY.Text = "X(max):";
            // 
            // minX
            // 
            this.minX.AutoSize = true;
            this.minX.Location = new System.Drawing.Point(7, 22);
            this.minX.Name = "minX";
            this.minX.Size = new System.Drawing.Size(51, 16);
            this.minX.TabIndex = 0;
            this.minX.Text = "X(мин):";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(118, 21);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 7;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // minChart
            // 
            this.minChart.AutoSize = true;
            this.minChart.Location = new System.Drawing.Point(14, 24);
            this.minChart.Name = "minChart";
            this.minChart.Size = new System.Drawing.Size(98, 16);
            this.minChart.TabIndex = 2;
            this.minChart.Text = "A (константа):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBoxN);
            this.groupBox1.Location = new System.Drawing.Point(640, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 447);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(23, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 222);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Таблица точек";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_X,
            this.column_Y1,
            this.colummY2});
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(260, 185);
            this.dataGridView1.TabIndex = 9;
            // 
            // column_X
            // 
            this.column_X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.column_X.Frozen = true;
            this.column_X.HeaderText = "X";
            this.column_X.MinimumWidth = 6;
            this.column_X.Name = "column_X";
            this.column_X.ReadOnly = true;
            this.column_X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.column_X.Width = 44;
            // 
            // column_Y1
            // 
            this.column_Y1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.column_Y1.Frozen = true;
            this.column_Y1.HeaderText = "Y (1)";
            this.column_Y1.MinimumWidth = 6;
            this.column_Y1.Name = "column_Y1";
            this.column_Y1.ReadOnly = true;
            this.column_Y1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.column_Y1.Width = 63;
            // 
            // colummY2
            // 
            this.colummY2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colummY2.Frozen = true;
            this.colummY2.HeaderText = "Y (2)";
            this.colummY2.MinimumWidth = 6;
            this.colummY2.Name = "colummY2";
            this.colummY2.ReadOnly = true;
            this.colummY2.Width = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_H);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxA);
            this.groupBox2.Controls.Add(this.minChart);
            this.groupBox2.Location = new System.Drawing.Point(23, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 91);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Константы";
            // 
            // textBox_H
            // 
            this.textBox_H.Location = new System.Drawing.Point(118, 49);
            this.textBox_H.Name = "textBox_H";
            this.textBox_H.Size = new System.Drawing.Size(100, 22);
            this.textBox_H.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "H (Шаг):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1006, 613);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab3";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBoxN.ResumeLayout(false);
            this.groupBoxN.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьГрафикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBoxN;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBox_X2;
        private System.Windows.Forms.TextBox textBox_X1;
        private System.Windows.Forms.Label pointY;
        private System.Windows.Forms.Label minChart;
        private System.Windows.Forms.Label minX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьДанныеИзФайлаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colummY2;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вклОтклПриветсвияToolStripMenuItem;
    }
}

