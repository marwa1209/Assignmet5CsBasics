namespace DemoAssignment5C_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region example1: casting
            object o1;
            o1 = "Ahmed"; // Casting

            o1=1; // Casting [Value Type > Reference Type] Boxing
            o1 = 'A'; // Casting [Value Type -> Reference Type] Boxing
            o1 = new Class1(); // Casting
            #endregion

            #region example2

            //int X = 10;          //obj new object(10);// Boxing [Safe Casting]
            //object obj = X;

            object obj02 = 10;                                        
            int Y = (int)obj02;   // Casting Unboxing [Unsafe Casting]
            Console.WriteLine(Y);

            #endregion
        }
    }
}
