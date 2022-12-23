using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using WindowsFormsProject.Properties;

namespace WindowsFormsProject
{
    public partial class Form2 : Form
    {
        public Form2(string equation, double A, double B)
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            textBox_equation.Text = equation;
            textBox_left.Text = Convert.ToString(A);
            textBox_right.Text = Convert.ToString(B);
        }

        Axis ax = new Axis();
        Axis ay = new Axis();
        public double xright;
        public double xleft;
        public double yright;
        public double yleft;

        private void button_draw_Click(object sender, EventArgs e)
        {
            try
            {
                string equation = textBox_equation.Text;
                double A =  Convert.ToDouble(textBox_left.Text);
                double B = Convert.ToDouble(textBox_right.Text);
                double step = Convert.ToDouble(textBox_step.Text);
                ax.Title = "X";
                ay.Title = "Y";
                total_chart.ChartAreas[0].AxisX = ax;
                total_chart.ChartAreas[0].AxisY = ay;
                total_chart.Series[0].ChartType = SeriesChartType.Point;
                xleft = A;
                xright = B;
                double x, y;
                x = A;
                yleft = Math.Round(ModuleMethod.CalculateFunc(xleft, equation), 3);
                yright = Math.Round(ModuleMethod.CalculateFunc(xright, equation), 3);
                while (x < B + step)
                {
                    y = Math.Round(ModuleMethod.CalculateFunc(x, equation), 3);
                    this.total_chart.Series[0].Points.AddXY(x, y);
                    x += step;
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля, проверьте правильность данных");
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ModuleMethod.CheckDot(textBox_right.Text);
            ModuleMethod.CheckDot(textBox_left.Text);
            ModuleMethod.CheckDot(textBox_step.Text);
            ModuleMethod.CheckDot(textBox_equation.Text);
        }
    }
}
