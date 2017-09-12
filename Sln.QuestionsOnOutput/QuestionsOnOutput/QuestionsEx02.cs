using System;

namespace QuestionsOnOutput
{
    public static class QuestionsEx02
    {

        static void arrayMethod(int[] a)
        {
            int[] b = new int[5];
            a = b;
        }
        public static void Question1()
        {
            int[] arr = new int[10];
            arrayMethod(arr);
            Console.WriteLine(arr.Length);
        }
        //Output: 10



        public static void Question2()
        {
            char x = 'A';
            int i = 0;
            Console.WriteLine(true ? x : 0);
            Console.WriteLine(false ? i : x);
        }
        //Output: 65 65

        public static void Question3()
        {
            int num1 = 20;
            int num2 = 30;
            num1 ^= num2 ^= num1 ^= num2;
            Console.WriteLine(num1 + "," + num2);
        }
        //Output: 0,20

        public static void Question4()
        {
            char[] num = { '1', '2', '3' };
            Console.WriteLine(" char array: " + num);
        }
        //Output: char array: System.Char[]

        public static void Question5()
        {
            bool a = true;
            bool b = false;
            a ^= b;
            Console.WriteLine(a);
        }
        //Output:

        public static void Question6()
        {
            bool a = true;
            bool b = false;
            a |= b;
            Console.WriteLine(a);
        }
        //Output:

        public static void Question7()
        {

        }
        //Output:

        public static void Question8()
        {

        }
        //Output:

        public static void Question9()
        {

        }
        //Output:

        public static void Question10()
        {

        }
        //Output:
    }
}
