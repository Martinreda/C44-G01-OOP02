using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{
    internal struct Person02
    {
        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructor
        public Person02(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #endregion
    }
}
