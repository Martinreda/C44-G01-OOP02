using System.ComponentModel;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;

namespace Assignment02OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            ///*1.	Define a struct "Person" with properties "Name" and "Age". 
            // *      Create an array of three "Person" objects and populate it with data.
            // *       Then, write a C# program to display the details of all the persons in the array.*/


            //Person people = new Person(3);

            //people.AddPerson(0, "Martin", 26);
            //people.AddPerson(1, "hossam", 30);
            //people.AddPerson(2, "Youssef", 22);

            //people.ShowAll();

            //Console.WriteLine($"\nhossam's Age Before: {people["hossam"]}");
            //people["hossam"] = 35;
            //Console.WriteLine($"hossam's Age After: {people["hossam"]}");

            #endregion

            #region Q02
            /*2.Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". 
            Write a C# program that takes two points as input from the user and calculates the distance between them.*/

            //Point point = new Point();

            //Console.Write("Enter X1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter X2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //point.SetPoint1(x1, y1);
            //point.SetPoint2(x2, y2);

            //Console.WriteLine("\nEntered Points:");
            //point.ShowPoints();

            //double distance = point.GetDistance();
            //Console.WriteLine($"\nDistance between the two points = {distance:F2}");

            #endregion

            #region Q03
            //3.Create a struct called "Person02" with properties "Name" and "Age". 
            //Write a C# program that takes details of 3 persons as input from the user 
            //and displays the name and age of the oldest person.

            //Person02 person1, person2, person3;

            //// --- Input 1 ---
            //Console.Write("Enter name of person 1: ");
            //string name1 = Console.ReadLine();

            //Console.Write("Enter age of person 1: ");
            //int age1 = int.Parse(Console.ReadLine());

            //person1 = new Person02(name1, age1);

            //// --- Input 2 ---
            //Console.Write("Enter name of person 2: ");
            //string name2 = Console.ReadLine();

            //Console.Write("Enter age of person 2: ");
            //int age2 = int.Parse(Console.ReadLine());

            //person2 = new Person02(name2, age2);

            //// --- Input 3 ---
            //Console.Write("Enter name of person 3: ");
            //string name3 = Console.ReadLine();

            //Console.Write("Enter age of person 3: ");
            //int age3 = int.Parse(Console.ReadLine());

            //person3 = new Person02(name3, age3);

            //// --- Find Oldest ---
            //Person02 oldest = person1;

            //if (person2.Age > oldest.Age)
            //    oldest = person2;

            //if (person3.Age > oldest.Age)
            //    oldest = person3;

            //Console.WriteLine($"\nThe oldest person is: {oldest.Name}, Age: {oldest.Age}");

            #endregion

            #region Q04
            //            4.Create a struct named Rectangle that represents a rectangle with the following fields:
            //width(type: double)
            //height(type: double)

            //Implement encapsulation by making the fields private and provide public properties access and modify these values.Ensure the following conditions are met:
            //The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message.
            //Implement a public read-only property Area that calculates and returns the area of the rectangle(Area = width * height).

            //Implement a method DisplayInfo that prints the rectangle's dimensions and area.
            //Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.

            Rectangle rect = new Rectangle();

          
            Console.Write("Enter width: ");
            rect.Width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            rect.Height = Convert.ToDouble(Console.ReadLine());

            
            rect.DisplayInfo();

            #endregion
        }
}
}
