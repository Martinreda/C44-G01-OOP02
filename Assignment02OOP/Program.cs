using System.ComponentModel;
using System.Drawing;

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

            Point point = new Point();

            Console.Write("Enter X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            point.SetPoint1(x1, y1);
            point.SetPoint2(x2, y2);

            Console.WriteLine("\nEntered Points:");
            point.ShowPoints();

            double distance = point.GetDistance();
            Console.WriteLine($"\nDistance between the two points = {distance:F2}");

            #endregion
        }
    }
}
