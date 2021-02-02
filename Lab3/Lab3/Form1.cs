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
            return x;
        }

        // Task 3
        public class Rect
        {

            public double x1;
            public double y1;

            public double x2;
            public double y2;

        }
        private bool AreRectCross(Rect A, Rect B)
        {

            bool v1 = A.x2 >= B.x1 && A.y2 >= B.y1;
            bool v2 = B.x2 >= A.x1 && B.y2 >= A.y1;

            return v1 || v2;
        }
    }
}
