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

        public static bool IsPrime(long number)
        {
            if (number < 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        private static string Multipliers(long n)
        {
            long div = 2;
            if (IsPrime(n)) return "Простое число";

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
        private async static Task<string> MultipliersAsync(long n)
        {
            return await Task.Run(() => Multipliers(n));    

        }



        private async void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            var a = (long)numericUpDown1.Value;
            textBox1.Text = await MultipliersAsync(a);
        }
    }

}
