using System.ComponentModel;
using System.Reflection;
using System.Threading.Channels;

namespace Assignmet5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment5 
            #region q1
            ///Passing by Value:
            ///A copy of the value is passed to the method.
            ///Changes to the parameter inside the method do not affect the original variable.

            ///Passing by Reference:
            ///A reference to the original value is passed to the method.
            ///Changes to the parameter inside the method affect the original variable.

            int valueType = 5;
            Console.WriteLine("Original value: " + valueType);
            // Pass by value
            ModifyByValue(valueType);
            Console.WriteLine("After ModifyByValue: " + valueType);
            // Pass by reference
            ModifyByReference(ref valueType);
            Console.WriteLine("After ModifyByReference: " + valueType);
            #endregion

            #region q2
            ///Passing Reference Types by Value:
            ///The method receives a copy of the reference to the object, not the actual object itself.
            ///The method can modify the object's data, but reassigning the reference inside the method does not affect the original reference.

            ///Passing Reference Types by Reference:
            ///The method receives the actual reference to the object.
            /// The method can modify the object's data, and reassigning the reference inside the method affects the original reference.

            Class1 myObject = new Class1 { Value = 5 };
            Console.WriteLine("Original value: " + myObject.Value);

            // Pass by value
            ModifyByValue(myObject);
            Console.WriteLine("After ModifyByValue: " + myObject.Value);

            // Pass by reference
            ModifyByReference(ref myObject);
            Console.WriteLine("After ModifyByReference: " + myObject.Value);
            #endregion

            #region q3
            Console.WriteLine("Enter four numbers: ");
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Enter fourth number: ");
            int num4 = int.Parse(Console.ReadLine());

            (int sumResult, int subResult) = CalculateSumAndSubtraction(num1, num2, num3, num4);

            Console.WriteLine($"Summation result: {sumResult}");
            Console.WriteLine($"Subtraction result: {subResult}");
            #endregion

            #region q4
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits = CalculateSumOfDigits(number);
            Console.WriteLine($"The sum of the digits of the number {number} is: {sumOfDigits}");
            #endregion

            #region q5
            Console.Write("Enter a number to check if it's prime: ");
            int numb = int.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);
            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
            #endregion

            #region q6
            int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            int minValue;
            int maxValue;
            MinMaxArray(numbers, out minValue, out maxValue);
            Console.WriteLine($"Minimum value: {minValue}");
            Console.WriteLine($"Maximum value: {maxValue}");
            #endregion

            #region q7
            Console.Write("Enter a number to calculate its factorial: ");
            int userNumber = int.Parse(Console.ReadLine());
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is: {factorial}");
            #endregion

            #region q8
            string originalString = "hello";
            int position = 1; 
            char newChar = 'i'; 

            string modifiedString = ChangeChar(originalString, position, newChar);
            Console.WriteLine($"Original string: {originalString}");
            Console.WriteLine($"Modified string: {modifiedString}");
            #endregion
            #endregion
        }
        //functions
        #region Assignment5
        #region q1
        static void ModifyByValue(int number)
        {
            number = 10; // Does not affect original valueType
        }
        static void ModifyByReference(ref int number)
        {
            number = 20; // Affects original valueType
        }
        #endregion

        #region q2
        static void ModifyByValue(Class1 obj)
        {
            obj.Value = 10; 
            obj = new Class1 { Value = 15 };
        }

        static void ModifyByReference(ref Class1 obj)
        {
            obj.Value = 20;
            obj = new Class1 { Value = 25 };
        }
        #endregion

        #region q3
        static (int, int) CalculateSumAndSubtraction(int a, int b, int c, int d)
        {
            int sum = a + b;
            int subtraction = c - d;
            return (sum, subtraction);
        }
        #endregion

        #region q4
        static int CalculateSumOfDigits(int num)
        {
            int sum = 0;

            num = Math.Abs(num);

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
        #endregion

        #region q5
        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false; 
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; 
                }
            }

            return true; 
        }
        #endregion

        #region q6
        static void MinMaxArray(int[] array, out int min, out int max)
        {
            min = array[0];
            max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }
            }
        }
        #endregion

        #region q7
        static long CalculateFactorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            long result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
        #endregion

        #region q8
        static string ChangeChar(string input, int position, char newChar)
        {
            if (position < 0 || position >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
            }

            char[] charArray = input.ToCharArray();
            charArray[position] = newChar;
            return new string(charArray);
        }
        #endregion
        #endregion
    }
}
