using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Reflection;
using System.Configuration;

namespace Lab3_Check_
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                double x1, x2, a, h;
                if (textBoxA.Text == "" || textBox_X1.Text == "" || textBox_X2.Text == "" || textBox_H.Text == "")
                {
                    MessageBox.Show("Стандартные параметры!", "Внимание!");
                    DefaultParametrs();
                }

                
                try { x1 = Convert.ToDouble(textBox_X1.Text); }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно задана левая граница");
                    return;
                }
                
                try { x2 = Convert.ToDouble(textBox_X2.Text); }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно задана правая граница");
                    return;
                }
                
                try
                {
                    a = Convert.ToDouble(textBoxA.Text);
                    if (a == 0) throw new ArgumentException();
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно задан константа");
                    return;
                }
                
                try
                {
                    h = Convert.ToDouble(textBox_H.Text);
                    if (h <= 0) throw new ArgumentException();
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно задан шаг");
                    return;
                }


                if (x1 != -x2 || x2 != -x1)
                {
                    MessageBox.Show("Границы должны быть равны по модулю!", "Внимание!");
                    this.chart.Series[0].Points.Clear();
                }


                List<double> points = new List<double>();
                for (double x = x1; x <= x2; x += h)
                {
                    double y = Math.Sqrt(Math.Sqrt(Math.Pow(a, 4) + 4 * a * a * x * x) - x * x - a * a);

                    if (!(double.IsNaN(y)))
                    {
                        dataGridView1.Rows.Add(Math.Round(x, 2), Math.Round(y, 2), Math.Round(-y, 2));
                        points.Add(x);
                    }
                    
                    
                    this.chart.Series[0].Points.AddXY(x, y);
                    this.chart.Series[1].Points.AddXY(x, -y);
                }
                double x_max = points.Max();
                double x_min = points.Min();
                this.chart.Series[0].Points.AddY(x_max);
                this.chart.Series[1].Points.AddY(x_min);
                


            }
            catch (Exception g)
            {
                MessageBox.Show($"Ошибка: " + g.Message, "Внимание!");
            }
        }

        private void сохранитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "txt files (*.txt) | *.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                List<string> param = new List<string>() { textBoxA.Text, textBox_H.Text, textBox_X1.Text, textBox_X2.Text };
                System.IO.File.WriteAllLines(filename, param);            
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
            

        }
        private void загрузитьДанныеИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.txt|";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(dialog.FileName);
                string file_path = dialog.FileName;
                if (ext != ".txt")
                {
                    MessageBox.Show("Неправильный файл");
                    dialog.ShowDialog();
                    file_path = dialog.FileName;
                    ext = Path.GetExtension(file_path);
                }
                var filestream = File.OpenRead(dialog.FileName);
                using (var dataStream = new StreamReader(dialog.FileName))
                {

                    double a;
                    var a_String = dataStream.ReadLine();

                    try
                    {
                        a = Convert.ToDouble(a_String);
                        textBoxA.Text = Convert.ToString(a);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неправильный ввод");
                        return;
                    }

                    double left;
                    var left_String = dataStream.ReadLine();
                    try
                    {
                        Convert.ToDouble(left_String);
                        double.TryParse(left_String, out left);
                        textBox_X1.Text = left_String;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неправильный ввод");
                        return;
                    }


                    double right;
                    var right_String = dataStream.ReadLine();
                    try
                    {
                        double.TryParse(left_String, out right);
                        textBox_X2.Text = right_String;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неправильный ввод");
                        return;
                    }


                    double step;
                    var step_String = dataStream.ReadLine();
                    try
                    {
                        double.TryParse(step_String, out step);
                        textBox_H.Text = step_String;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неправильный ввод");
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("Ошибка загрузки файла!");
            }
        }
    
        private void очиститьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.chart.Series[0].Points.Clear();
            this.chart.Series[1].Points.Clear();
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void DefaultParametrs()
        {
            double x1 = -10;
            double x2 = 10;
            double a = 4.0; 
            double h = 1;
        }
       
        private void вклОтклПриветсвияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool showGreetingOn;

            var file = new StreamReader("ShowGreeting");
            string stringShowGreetingOn = file.ReadLine();
            showGreetingOn = Convert.ToBoolean(stringShowGreetingOn);
            file.Close();

            if (showGreetingOn)
            {
                var file1 = new StreamWriter("ShowGreeting", false);
                showGreetingOn = false;
                file1.WriteLine(showGreetingOn);
                file1.Close();
            }
            else
            {
                var file2 = new StreamWriter("ShowGreeting", false);
                showGreetingOn = true;
                file2.WriteLine(showGreetingOn);
                file2.Close();
            }
        }
    }
}

