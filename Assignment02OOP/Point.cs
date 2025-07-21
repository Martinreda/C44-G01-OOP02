using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{
    internal struct Point
    {
        #region attributes
        private double x1, y1;
        private double x2, y2;
        #endregion

        #region methods

        public void SetPoint1(double x, double y)
        {
            x1 = x;
            y1 = y;
        }
        public void SetPoint2(double x, double y)
        {
            x2 = x;
            y2 = y;
        }
        public double GetDistance()
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void ShowPoints()
        {
            Console.WriteLine($"Point 1: ({x1}, {y1})");
            Console.WriteLine($"Point 2: ({x2}, {y2})");
        }

        #endregion
    }
}
