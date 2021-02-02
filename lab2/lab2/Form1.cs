using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string Multipliers(int n)
        {
            int div = 2;
            string output = n.ToString()+" = 1 ";
            while (n > 1)
            {
                while (n % div == 0)
                {
                    output+= " * " + div.ToString();
                    n = n / div;
                }
                div++;
            }
            return output;
        }

        private static string MultipliersFixed(int n)
        {
            int div = 2;
            if (n > 0)
            {
                string output = n.ToString() + " = 1 ";
                while (n > 1)
                {
                    while (n % div == 0)
                    {
                        output += " * " + div.ToString();
                        n = n / div;
                    }
                    div++;
                }
                return output;
            }
            else
            {
                return "Введите натуральное число";

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            var a = (int)numericUpDown1.Value;

            textBox1.Text = MultipliersFixed(a);
        }
    }

}
