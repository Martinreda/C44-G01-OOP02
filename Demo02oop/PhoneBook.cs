using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo02oop
{
    internal struct PhoneBook
    {
        //array for struct 
        #region attrubites 
        string[] names;
        long[] numbers;
        int size;
        #endregion

        #region propertey 
        public int Size
        { 
            get
            {
                return size;
            }
        }
        #endregion

        #region constructor
        public PhoneBook(int size )
        {
            this.size = size;
            names = new string[size];
            numbers = new long[size];
        }

        #endregion

        #region  methodes
        public void AddPerson (int position , string name , long num)
        {
            if (names != null && numbers != null)
            {
                if (position >= 0 && position < size)
                {
                    names[position] = name;
                    numbers[position] = num;
                }
            }
        }
        #endregion

        #region using setter 

        public long GetPersonNumber(string Name)

        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0;  i < names.Length; i++)
                {
                    if (Name == names[i])
                        return numbers[i];
                }
            }
            return -1;
        }
       //set value in array 
       public void SetPersonNumber (string Name , long NewNumber)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                       {
                        numbers[i] = NewNumber;
                       }
                }
            }
            
        }


        #endregion

        #region indexer
        // spiecal type of property using keyword [this] 
        //this => refer to phone book struct
        public long this[string Name]
        {
            get
            {

                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                            return numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                {
                    if (names is not null && numbers is not null)
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            if (Name == names[i])
                            {
                                numbers[i] = value;
                            }
                        }
                    }

                }
            }
        }
        #endregion
    }
}
