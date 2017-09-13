using System;

namespace QuestionsOnOutput.Recursion
{
    public static class RecursionEx
    {
        public static int MyFunction(int N)
        {
            if (N < 4)
                return N + MyFunction(++N) + MyFunction(++N);
            return N;
        }
        //Output: 49



        public static int MyFunction2(int N)
        {
            if (N < 4)
                return N + MyFunction(N++) + MyFunction(N++);
            return N;
        }
        //Output: 80


        public static void BeforePlusPlusAndLastPlusPlusResult01()
        {
            int N = 10;
            N++;
            Console.WriteLine("N = " + N);
            ++N;
            Console.WriteLine("N = " + N);
        }

        public static void BeforePlusPlusAndLastPlusPlusResult02()
        {
            int N = 10;
            Console.WriteLine("N = " + N++);
            Console.WriteLine("N = " + ++N);
        }

        //Output: 


    }
}
