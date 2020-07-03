using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            int number;
            string nmbr;
            nmbr = Console.ReadLine();
            number = Convert.ToInt32(nmbr);
            Console.WriteLine(isSimpleStr(number));
            while (true)
            {               
                    while (!isSimple(number))
                    {
                        number++;
                    }
                    Console.WriteLine("Next simple number is " + number);
                //Console.ReadKey();
                Thread.Sleep(1000);
                number++;
            }
        }
        public static string isSimpleStr(int a)
        {
            if (isSimple(a)) return "simple";
            else return "not simple";
        }
        public static bool isSimple(int a)
        {
            bool smpl = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    //Console.WriteLine("Number is not simple");
                    smpl = false;
                }
            }
            return smpl;
        }
    }
}
