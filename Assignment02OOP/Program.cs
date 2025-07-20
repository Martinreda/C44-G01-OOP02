namespace Assignment02OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            /*1.	Define a struct "Person" with properties "Name" and "Age". 
             *      Create an array of three "Person" objects and populate it with data.
             *       Then, write a C# program to display the details of all the persons in the array.*/


            Person people = new Person(3);

            people.AddPerson(0, "Martin", 26);
            people.AddPerson(1, "hossam", 30);
            people.AddPerson(2, "Youssef", 22);

            people.ShowAll();

            Console.WriteLine($"\nhossam's Age Before: {people["hossam"]}");
            people["hossam"] = 35;
            Console.WriteLine($"hossam's Age After: {people["hossam"]}");

            #endregion
        }
    }
}
