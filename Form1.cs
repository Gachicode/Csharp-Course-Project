using System;
using System.Windows.Forms;
using WindowsFormsProject.Properties;

namespace WindowsFormsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }
        private void button_solve_click(object sender, EventArgs e)
        {
            if (textBox_epsilon.Text != "" && textBox_equation.Text != "" && textBox_left.Text != "" && textBox_right.Text != "")
            {
                try
                {
                    double epsilon = Convert.ToDouble(textBox_epsilon.Text);
                    double left = Convert.ToDouble(textBox_left.Text);
                    double right = Convert.ToDouble(textBox_right.Text);
                    string equation = textBox_equation.Text;
                    double answer = ModuleMethod.BisectionMethod(epsilon, left, right, equation);
                    label5.Text = Convert.ToString(answer);
                    //MessageBox.Show($"{answer}");
                }
                catch
                {
                    MessageBox.Show("Неверные входные данные");
                }
            }
            else
            {
                MessageBox.Show("Неполные входные данные");
            }
        }

        private void button_graphics_click(object sender, EventArgs e)
        {
            if (textBox_equation.Text != "" && textBox_left.Text != "" && textBox_right.Text != "")
            {
                Form2 new_form2 = new Form2(textBox_equation.Text, Convert.ToDouble(textBox_left.Text), Convert.ToDouble(textBox_right.Text));
                new_form2.Show();
            }
            else
            {
                MessageBox.Show("Неполные входные данные для отрисовки");
            }

        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ModuleMethod.CheckDot(textBox_right.Text);
            ModuleMethod.CheckDot(textBox_left.Text);
            ModuleMethod.CheckDot(textBox_epsilon.Text);
            ModuleMethod.CheckDot(textBox_equation.Text);
        }

    }
}