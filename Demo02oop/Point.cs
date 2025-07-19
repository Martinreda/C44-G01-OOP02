using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02oop
{
    internal struct Point
    {
        #region attrubite 
        public int x;
        public int y;
        #endregion

        #region constructor 
        // struct is a value type not like class i cannot take referance from it 
        // C# 9 
        //empty parameterless CTOR
        public Point()
        {
            x = default;
            y = default;
        }
        // C# 10 
        // compiler will generate empty parameterless CTOR
        // public Point (int x , int y) // b3rf 2 patameters
        //{
        //    this.x = x;
        //    this.y = y;

        //}

        public Point(int _x, int _y) // b3rf 2 patameters
        {
            x /*attrubite*/ = _x; //value
            y = _y;

        }
        #endregion

        #region Method 

        public override string ToString()
        {
            return $"x : {x} , Y : {y}";
        }



        #endregion
    }
}
