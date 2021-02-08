using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace lab3_console
{
    class Program
    {

        private static bool IsYearVis(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
        //Task 2
        private static double f(double x)
        { 
            return x+ Math.Sin(x);
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

            public int lx = 0;
            public int ly = 0;
            public int rx = 0;
            public int ry = 0;

            public string toString()
            {
                return lx.ToString() + " " + " " + ly.ToString() + " " + rx.ToString() + " " + ry.ToString();
            }
            public Rect(int lx, int ly, int rx, int ry)
            {
                this.lx = lx;
                this.ly = ly;
                this.rx = rx;
                this.ry = ry;
            }
            public Rectangle GetRectangle()
            {
                Rectangle rectangle = new Rectangle(lx, ly, Math.Abs( rx-lx),Math.Abs( ly-ry));
                return rectangle;
            }
        }
        private static Rectangle AreRectCross(Rect A, Rect B)
        {
            var rA = A.GetRectangle();
            var rB = B.GetRectangle();
            var rS = Rectangle.Intersect(rA, rB);

            return rS;
        }


        static void Main()
        {
            int op;
            string answer = "";
            StreamReader sr = new StreamReader("Input.txt");
            var test_function = Convert.ToInt32(sr.ReadLine());
            while (!sr.EndOfStream)
            {
                List<string> args = new List<string>();
                var line = sr.ReadLine();
                if (line[0] == '#') continue;
                var args_str = line.Split((' '));
                op = Convert.ToInt32(args_str[0]);
                if (test_function != 0 && op != test_function) continue;
                try
                {
                    switch (op)
                    {
                        case 1:
                            var year = Convert.ToInt32(args_str[1]);
                            answer = IsYearVis(year) ? "Yes" : "No";                          
                            break;
                        case 2:
                            var a = Convert.ToDouble(args_str[1]);
                            var b = Convert.ToDouble(args_str[2]);
                            var eps = Convert.ToDouble(args_str[3]);


                            var root = Binary_Search(a, b, eps);
                            answer = String.Format("{0:f15}", root);

                            break;
                        case 3:
                            var A = new Rect(
                                 Convert.ToInt32(args_str[1]),
                                 Convert.ToInt32(args_str[2]),
                                 Convert.ToInt32(args_str[3]),
                                 Convert.ToInt32(args_str[4])
                                );
                            var B = new Rect(
                                  Convert.ToInt32(args_str[5]),
                                  Convert.ToInt32(args_str[6]),
                                  Convert.ToInt32(args_str[7]),
                                  Convert.ToInt32(args_str[8])
                                 );

                            var res = AreRectCross(A, B);
                            if (res == new Rectangle()) answer = "Not Cross";
                            else answer = res.ToString();
                            break;
                    }
                    Console.WriteLine("[" + line + "]: " + answer);



                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }

               
            }
            sr.Close();
            Console.ReadLine();

        }
    }
}
