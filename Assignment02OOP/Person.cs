using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02OOP
{
    internal struct  Person
    {
        #region Attributes
        private string[] names;
        private int[] ages;
        private int size;
        #endregion

        #region Constructor
        public Person (int size)
        {
            this.size = size;
            names = new string[size];
            ages = new int[size];
        }
        #endregion

        #region Properties
        public int Size
        {
            get { return size; }
        }
        #endregion

        #region Methods
        public void AddPerson(int index, string name, int age)
        {
            if (index >= 0 && index < size)
            {
                names[index] = name;
                ages[index] = age;
            }
        }

        public void ShowAll()
        {
            Console.WriteLine("List of People:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Person {i + 1}: Name = {names[i]}, Age = {ages[i]}");
            }
        }
        #endregion

        #region Indexer
        public int this[string name]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == name)
                        return ages[i];
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == name)
                    {
                        ages[i] = value;
                    }
                }
            }
        }
        #endregion
    }
}



