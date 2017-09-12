using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuestionsOnOutput
{
    public static class QuestionsEx01
    {
        static string location;
        static DateTime time;
        private static string result;
        delegate void Printer();
        delegate void Iterator();


        public static void Question1()
        {
            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
        }
        //Output: 
        //location is null
        //1/1/0001 12:00:00 AM

        public static async Task<string> Question2()
        {
            await Task.Delay(5);
            result = "Hello world!";
            return "Something";
        }
        //Output:
        //Nothings

        public static void Question3()
        {
            List<Printer> printers = new List<Printer>();
            for (int i = 0; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var printer in printers)
            {
                printer();
            }
        }
        //Output:
        //10 (10 times)

        public static void Question4()
        {
            List<Iterator> iterators = new List<Iterator>();
            for (int i = 0; i < 15; i++)
            {
                iterators.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var item in iterators)
            {
                item();
            }

        }
        //Output:
        //15 (15 times)

        public static void Question5()
        {
            Console.WriteLine(Math.Round(6.5));
            Console.WriteLine(Math.Round(11.5));

        }
        //Output: 6 12

        public static void Question6()
        {
            int[] i = new int[0];
            Console.WriteLine(i[0]);
        }
        //Output: IndexOutOfRangeException

        public static void Question7()
        {
            byte num = 100;
            dynamic val = num;
            Console.WriteLine(val.GetType());
            val += 100;
            Console.WriteLine(val.GetType());
        }
        //Output:
        //System.Byte
        //System.Int32


        public static void Question8()
        {
#if (!pi)
            Console.WriteLine("i");
#else
                    Console.WriteLine("PI undefined");
#endif
            Console.WriteLine("ok");
            Console.ReadLine();
        }
        //Output: i ok

        public static void Question9()
        {
            int[] arr = new int[2];
            arr[1] = 10;
            Object o = arr;
            int[] arr1 = (int[])o;
            arr1[1] = 100;
            Console.WriteLine(arr[1]);
            ((int[])o)[1] = 1000;
            Console.WriteLine(arr[1]);
        }
        //Output: 100 1000

        public static void Question10()
        {
            string a = "TechBeamers";
            string b = "TECHBEAMERS";
            int c;
            c = a.CompareTo(b);
            Console.WriteLine(c);
        }
        //Output: -1

    }


}
