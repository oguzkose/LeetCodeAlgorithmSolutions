using System;

namespace _2_AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };

            Array.Reverse(array1);           
            var number1 = 100 * array1[0] + 10 * array1[1] + 1 * array1[2];

            Array.Reverse(array2);
            var number2 = 100 * array2[0] + 10 * array2[1] + 1 * array2[2];

            Console.WriteLine(number1+" "+number2);
            var total = number1 + number2;//321+654=975

            int bolum = total / 100;
            Console.WriteLine(bolum);
            
            
        }
    }
}
