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
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
        //Task 2
        private double f(double x)
        {
            return 2*x+1;
        }
   
        private double Binary_Search(int a,int b,double accuracy= 1e-9)
        {
            double l = a, r = b, m=0, eps = accuracy;
            while ((r - l) > eps)
            {
                m = (l + r) * 0.5;
                if (m * m < 0) l = m;
                    else r = m;
            }
            return m;
        }

        // Task 3
        public class Rect
        {

            public double x1=0;
            public double y1 = 0;

            public double x2 = 0;
            public double y2 = 0;

        }
        private bool AreRectCross(Rect A, Rect B)
        {
            var v1 = A.y1 < B.y2;
            var v2 = A.y2 > B.y1;
            var v3 = A.x2 < B.x1;
            var v4 = A.x1 > B.x2;
            return ( v1|| v2|| v3 ||v4);
         
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
                A.x1 = Convert.ToDouble(textBoxTesk3R1X1.Text);
                A.y1 = Convert.ToDouble(textBoxTesk3R1Y1.Text);
                A.x2 = Convert.ToDouble(textBoxTesk3R1X2.Text);
                A.y2 = Convert.ToDouble(textBoxTesk3R1Y2.Text);
                B.x1 = Convert.ToDouble(textBoxTesk3R2X1.Text);
                B.y1 = Convert.ToDouble(textBoxTesk3R2Y1.Text);
                B.x2 = Convert.ToDouble(textBoxTesk3R2X2.Text);
                B.y2 = Convert.ToDouble(textBoxTesk3R2Y2.Text);
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
