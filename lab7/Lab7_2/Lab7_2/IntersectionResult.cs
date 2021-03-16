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
        private Exception error;

        public Exception GetError()
        {
            return error;
        }

        public void SetError(Exception value)
        {
            error = value;
        }

        public bool IsSame { get; set; }
        public bool IsParallel { get; set; }
        public PointF? IPoint { get; set; }

        public IntersectionResult()
        {
            SetError(null);
            IsSame = false;
            IsParallel = false;
            IPoint = null;
        }

        public IntersectionResult(bool same = false, bool parallel = false, PointF? point = null, Exception error = null)
        {
            SetError(error);
            IsSame = same;
            IsParallel = parallel;
            IPoint = point;
        }
    }
}
