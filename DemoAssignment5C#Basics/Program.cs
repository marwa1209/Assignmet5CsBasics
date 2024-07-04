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
            o1 = new Employee(); // Casting
            #endregion

            #region example2

            //int X = 10;          //obj new object(10);// Boxing [Safe Casting]
            //object obj = X;

            object obj02 = 10;                                        
            int Y = (int)obj02;   // Casting Unboxing [Unsafe Casting]
            Console.WriteLine(Y);

            #endregion

            #region example3
            //int x = null; // Valid
            // int x => x Allow only int numbers

            //int? Y = null; // Valid
            // int? Y => Y Allow Int Values + Null

            int? YY = null;
            int X = 10;

            //int? Z = Y; // Valid
            int? Z = X; // Valid

            int? Number; //Nullable<int> Number;    // Nullable -> Allow Null + Values

            //decimal Num01 = 1.1M;
            //decimal? Num02 = Num01;

            decimal? Num01 = null;

            Console.WriteLine(Num01);
            Console.WriteLine(YY);
            #endregion

            #region example4:ReferencesType

            string Message = "Hi";
            Message = null; // Valid With Warning
            Message =null!; // Null Forgiveness Operator

            string? Message02 = null; // Valid Without Warning

            Console.WriteLine(Message02);
            Console.WriteLine(Message);

            #endregion
        }
    }
}
