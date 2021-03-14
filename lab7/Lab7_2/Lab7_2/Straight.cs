using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

namespace Lab7_2
{
    public class Straight
    {

        private PointF P1 { get; set; }
        private PointF P2 { get; set; }
        private float A;
        private float B;
        private float C;

        public bool IsParallelWith(Straight l)
        {
            return (this.A / l.A) == (this.B / l.B);
        }
        public bool IsSamelWith(Straight l)
        {
            return (this.A == l.A && this.B == l.B && this.C == l.C );
        }
        public PointF IntersectlWith(Straight l)
        {
          

            float det = this.A * l.B - l.A * this.B;
            var x = (this.B * l.C - l.B * this.B) / det;
            var y = (l.A * this.C - this.A * l.C) / det;

            return new PointF(x, y);
        }
        public IntersectionResult GetIntersectioWith(Straight l)
        {
            var rez = new IntersectionResult();
            rez.IsSame =  this.IsSamelWith(l);
            if (rez.IsSame)return rez;

            rez.IsParallel =  this.IsParallelWith(l);
            if (rez.IsParallel)return rez;
            //else
            rez.IPoint = this.IntersectlWith(l);
            return rez;
        }

        public Straight(PointF a,PointF b)
        {
            this.P1 = a;
            this.P2 = b;
            this.A = P1.Y - P2.Y;
            this.B = P1.X - P2.X;
            this.C = P1.X * P2.Y - P2.X * P1.Y;
        }
    
    }
}
