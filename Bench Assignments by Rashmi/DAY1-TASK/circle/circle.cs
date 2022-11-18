using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicesessions
{
    public class circle
    {
        public (double circumference, double area) CircumferenceAndArea(int r)
        {
            double circum = (2 * Math.PI * r);
            double area = (Math.PI * r * r);
            return (circum, area);
        }
    }
}
