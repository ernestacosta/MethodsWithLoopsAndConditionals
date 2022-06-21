using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Threes(); 
            PrintThousand();
            Console.WriteLine(IsEqual(2, 8));
        }
        public static void PrintThousand()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void Threes()
        {
            for(int k = 3; k <= 999; k +=3)
            {
                Console.WriteLine(k);
            }
        }

        public static bool IsEqual(int a, int b)
        {
            var check = (a == b) ? true : false;
            return check;   
        }
        
    }
}
