using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProjectWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x;
        private void ButtonD_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBoxDMC.Text);
            switch (d)
            {
               case 1:
                    labelO.Text = d.ToString("Понедельник");
                    break;
               case 2:
                    labelO.Text = d.ToString("Вторник");
                    break;
               case 3:
                    labelO.Text = d.ToString("Среда");
                    break;
               case 4:
                    labelO.Text = d.ToString("Четверг");
                    break;
               case 5:
                    labelO.Text = d.ToString("Пяница");
                    break;
               case 6:
                    labelO.Text = d.ToString("Суббота");
                    break;
               case 7:
                    labelO.Text = d.ToString("Воскесенье");
                    break;
               default:
                    MessageBox.Show("Ошибка ввода", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ButtonM_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBoxDMC.Text);
            switch (m)
            {
                case 1:
                    labelO.Text = m.ToString("Январь");
                    break;
                case 2:
                    labelO.Text = m.ToString("Февраль");
                    break;
                case 3:
                    labelO.Text = m.ToString("Март");
                    break;
                case 4:
                    labelO.Text = m.ToString("Апрель");
                    break;
                case 5:
                    labelO.Text = m.ToString("Май");
                    break;
                case 6:
                    labelO.Text = m.ToString("Июнь");
                    break;
                case 7:
                    labelO.Text = m.ToString("Июль");
                    break;
                case 8:
                    labelO.Text = m.ToString("Август");
                    break;
                case 9:
                    labelO.Text = m.ToString("Сентябрь");
                    break;
                case 10:
                    labelO.Text = m.ToString("Октябрь");
                    break;
                case 11:
                    labelO.Text = m.ToString("Ноябрь");
                    break;
                case 12:
                    labelO.Text = m.ToString("Декабрь");
                    break;
                default:
                    MessageBox.Show("Ошибка ввода", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void LabelCH_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCH_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxDMC.Text);
            double b = Convert.ToDouble(textBox_CB.Text);
            double z = 0;
            switch(textBox_CZ.Text)
            {
                case "+":
                    {
                        z = a + b;
                        labelO.Text = z.ToString();
                        break;
                    }
                case "-":
                    {
                        z = a - b;
                        //labelO.Text = z.ToString("{z}", z);
                        break;
                    }
                case "*":
                    {
                        z = a * b;
                        //labelO.Text = z.ToString("{z}", z);
                        break;
                    }
                case "/":
                    {
                        z = a / b;
                        //labelO.Text = z.ToString("{z}", z);
                        break;
                    }
                default:
                    MessageBox.Show("Ошибка ввода", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }

        private void ButtonW_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
