using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab7_2
{
    public class Geometry
    {
        public static IntersectionResult IntersectionCheck
            (
              PointF p1
             ,PointF p2
             ,PointF p3
             ,PointF p4
            )
        {
            //тут могли быть преобразования строки в набор точек
            var  S1 = new Straight(p1, p2);
            var  S2 = new Straight(p3, p4);

            return S1.GetIntersectioWith(S2);
        }
    }
}
