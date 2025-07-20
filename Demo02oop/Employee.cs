using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo02oop
{
    internal struct Employee
    {
        #region Attrubites
        public int Id;
        public string name;
        public int age;
        public decimal salary; 
        #endregion

        #region CTOR
        //3ndi 3 ways a3ml behm al CTOR 
        /*1- public employee() => manually
         *2-CTOR + Tab => empty CTOR
         *3-From attrbites all data */
        
        public Employee(int id, string name, int age)
        {
            this.Id = id;
            this.name = name;
            this.age = age;
        }

        #endregion

        //applay encapsolation 
        /* 01 all attrabutes privte .
         * 02 use setter getter methods 
         * 03 use properites*/

        #region Apply encapsulation using setter Getter methods
        // Getter => get name 
        public string GetName()
        {
            return name;
        }

        //Setters
        public void SetName(string name)
        {
            this.name = name;
        }

        #endregion

        #region 2. applay encapsulation using propertey
        //property can't take parameter 
        //need to valdation 
        //when use property att=> small property => capital 

        #region full propertey
        private decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        #endregion

        #endregion

        #region Method 

        public override string ToString()
        {
            return $"id : {Id} \n Name : {name} \n Age : {age}";
        }
        #endregion

    }
}
