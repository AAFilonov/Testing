using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }
        //Task 1
        private bool IsYearVis(int year)
        {
            if (year % 4 == 0 && year % 100 != 0)
                return true;
            if (year % 4 == 0 && year % 400 == 0)
                return true;
            return false;
        }
        //Task 2
        private static double f(double x)
        {
            return x + Math.Sin(x);
        }

        private static double Binary_Search(double l, double r, double eps = 1e-9)
        {
            double m;
            do
            {
                m = (l + r) * 0.5;
                if (f(m) < 0) l = m;
                else r = m;
            } while ((r - l) > eps);
            return m;
        }

        // Task 3
        public class Rect
        {

            public double lx=0;
            public double ly = 0;

            public double rx = 0;
            public double ry = 0;

        }
        private bool AreRectCross(Rect A, Rect B)
        {
            if (A.lx > B.rx || B.lx > A.rx)
                return false;
            // If one rectangle is above other 
            if (A.ry < B.ly || B.ry < A.ly)
                return false;

            return true;
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            int year = (int)numericUpDownTask1.Value;
            var answer = IsYearVis(year) ? "Да" : "Нет";
            textBoxTask1.Text = answer;
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            int a = (int)numericUpDownTask2Left.Value;
            int b= (int)numericUpDownTask2Right.Value;
            double eps = 0;
            try
            {
                eps = Convert.ToDouble( textBoxTask2Accuracy.Text);
                textBoxTask2Answer.Text = Convert.ToString(Binary_Search(a, b, eps));
            }
            catch
            {
                MessageBox.Show("Значение точности задано некорректно!", "Ошибка");
            }

        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            try
            {
                Rect A = new Rect(); Rect B = new Rect();
                A.lx = Convert.ToDouble(textBoxTesk3R1X1.Text);
                A.ly = Convert.ToDouble(textBoxTesk3R1Y1.Text);
                A.rx = Convert.ToDouble(textBoxTesk3R1X2.Text);
                A.ry = Convert.ToDouble(textBoxTesk3R1Y2.Text);
                B.lx = Convert.ToDouble(textBoxTesk3R2X1.Text);
                B.ly = Convert.ToDouble(textBoxTesk3R2Y1.Text);
                B.rx = Convert.ToDouble(textBoxTesk3R2X2.Text);
                B.ry = Convert.ToDouble(textBoxTesk3R2Y2.Text);

                if (A.lx > A.rx || A.ly > A.ry 
                    || B.lx > B.rx || B.ly > B.ry) 
                    throw new Exception("");

                    var answer = AreRectCross(A,B) ? "Да" : "Нет";
                textBoxTask3Answer.Text = answer;
            }
            catch
            {
                MessageBox.Show("Некорректные входные данные!", "Ошибка");
            }
        }
    }
}
