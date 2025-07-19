namespace Demo02oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            /*
             * Struct Value Type
             * struct comes from C lang 
             * Struct doesnot allow inheritance
             * Struct privte public internal 
             */

            //Calling  i must have CTOR on strucrt
            Point P1;

            P1 = new Point(1,2); // New just for ctor selection not referance 
                          //assign x = 1 y = 2
            Console.WriteLine(P1);

            /*struct at memory
             * stack
             */


            #endregion

            #region OOP Defination
            /*
             * every thing is object
             * oop aims to structure software in a way thats model real entites using oop concepts 
             * zy al 3rabya bttgmm3 wa7da wa7da 3la4n nkwanhaa 
             */
            #endregion

        }
    }
}
