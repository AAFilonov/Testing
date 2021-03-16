using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;

namespace Lab7_2
{
    public class Geometry
    {
        public static IntersectionResult IntersectionCheck
            (
              PointF p1
             , PointF p2
             , PointF p3
             , PointF p4
            )
        {
            //тут могли быть преобразования строки в набор точек
            var S1 = new Straight(p1, p2);
            var S2 = new Straight(p3, p4);

            return S1.GetIntersectioWith(S2);
        }

        public static IntersectionResult IntersectionCheckStr(string input)// "1.3 1.3 ..." 8 xbctk                    

        {
            IntersectionResult rez = new IntersectionResult();
            List<float> values = new List<float>();
            try
            {
                var Numbers = input.Split(new[] { ' ', ';' });

                foreach (var i in Numbers)
                {
                    var num = float.Parse(i, CultureInfo.InvariantCulture.NumberFormat);
                    values.Add(num);
                }
            }
            catch (FormatException e)
            {
                rez.SetError(e);
                return rez;
            }

            //количество переданных значений не соотвесвует  4 парам координат
            if (values.Count != 8)
            {
                var e = new Exception("Wrong amount of arguments");
                rez.SetError(e);
                return rez;
            }
            //количество занчений корректно

            PointF p1 = new PointF(values[0], values[1]);
            PointF p2 = new PointF(values[2], values[3]);
            PointF p3 = new PointF(values[4], values[5]);
            PointF p4 = new PointF(values[6], values[7]);

            //тут могли быть преобразования строки в набор точек
            var S1 = new Straight(p1, p2);
            var S2 = new Straight(p3, p4);
            rez = S1.GetIntersectioWith(S2);
            return rez;
        }

    }
}
