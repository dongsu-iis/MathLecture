using System;

namespace Lesson01
{
    class Lesson01_2
    {
        static int LeftShift(int num,int m)
        {
            return num << m;
        }

        static int RightShift(int num,int m)
        {
            return num >> m;
        }

        static void Main2(string[] args)
        {
            int num = 53;
            int m = 1;
            Console.WriteLine($"数字{num}の２進数を左へ{m}シフトした結果は{LeftShift(num,m)}です");
            Console.WriteLine($"数字{num}の２進数を右へ{m}シフトした結果は{RightShift(num, m)}です");
        }
    }
}
