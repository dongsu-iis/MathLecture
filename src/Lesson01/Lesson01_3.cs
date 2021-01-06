using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    class Lesson01_3
    {
        static int Or(int num1,int num2)
        {
            return (num1 | num2);
        }

        static int And(int num1,int num2)
        {
            return (num1 & num2);
        }

        static int Xor(int num1,int num2)
        {
            return (num1 ^ num2);
        }

        static void Main(string[] args)
        {
            int a = 53;
            int b = 35;
            Console.WriteLine($"数字{a}と数字{b}のORの結果は{Or(a,b)}です");
            Console.WriteLine($"数字{a}と数字{b}のANDの結果は{And(a, b)}です");
            Console.WriteLine($"数字{a}と数字{b}のXORの結果は{Xor(a, b)}です");
        }

    }
}
