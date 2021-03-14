using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Lab7_2
{
    public class IntersectionResult
    {
        public bool IsSame { get; set; }
        public bool IsParallel { get; set; }
        public PointF? IPoint { get; set; }
        public IntersectionResult(bool same =false, bool parallel = false, PointF? point =null)
        {
            IsSame = same;
            IsParallel = parallel;
            IPoint = point;
        }
    }
}
