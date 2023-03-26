using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3_Check_
{
    public partial class Form1 : Form
    {
        private double a,h,x1,x2;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             *Вывод сообщения ошибки 
             *if(усл)
             *{
             *  MessageBox.Show("", "Ошибка"};
             *  return
             *}
             */
            

            if (textBoxA.Text == "" || textBox_X1.Text == "" || textBox_X2.Text == ""|| textBox_H.Text == "")
            {
                MessageBox.Show("Стандартные параметры!", "Внимание!");
                DefaultParametrs();
            }
            else
            {
                x1 = Convert.ToDouble(textBox_X1.Text);
                x2 = Convert.ToDouble(textBox_X2.Text);
                a = Convert.ToDouble(textBoxA.Text);
                h = Convert.ToDouble(textBox_H.Text);
            }

            if (x1 != -x2 || x2 != -x1)
            {
                MessageBox.Show("Границы должны быть равны по модулю!", "Внимание!");
                this.chart.Series[0].Points.Clear();
            }



            for (double x = x1; x <= x2; x += h)
            {
                double y = Math.Sqrt(Math.Sqrt(Math.Pow(a, 4) + 4 * a * a * x * x) - x*x - a*a);
                dataGridView1.Rows.Add(x, y);
                this.chart.Series[0].Points.AddXY(x, y);
                this.chart.Series[0].Points.AddXY(x, -y); // Зеркальная точка
                
            }            
        }

        private void очиститьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.chart.Series[0].Points.Clear();
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
            double a = 1.0; 
            double h = 0.1;
        }

    }
}

