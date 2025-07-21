using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{
    internal struct Rectangle
    {
        #region Private Fields
        private double width;
        private double height;
        #endregion

        // -------------------------------
        #region Public Properties
        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;
                else
                    Console.WriteLine("Width cannot be negative!");
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else
                    Console.WriteLine(" Height cannot be negative!");
            }
        }

        // Read-only property
        public double Area
        {
            get { return width * height; }
        }
        #endregion

        // -------------------------------
        #region Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Rectangle Info:");
            Console.WriteLine($"Width:  {width}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Area:   {Area}");
        }
        #endregion
    }
}
