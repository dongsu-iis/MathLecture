using System;

namespace Lesson01
{
    class Lesson01_1
    {

        static string DecimalToBinary(int decimalSource)
        {
            return Convert.ToString(decimalSource, 2);
        }

        static int BinaryToDecimal(string binarySoruce)
        {
            return Convert.ToInt32(binarySoruce, 2);
        }



        static void Main1(string[] args)
        {
            int a = 53;
            string b = "110101";
            Console.WriteLine($"数字{a}の２進数は{DecimalToBinary(a)}です");
            Console.WriteLine($"数字{b}の１０進数は{BinaryToDecimal(b)}です");
        }
    }
}
