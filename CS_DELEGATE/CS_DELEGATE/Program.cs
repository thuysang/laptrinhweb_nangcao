using System;

namespace CS_Delagate
{
    public delegate void ShowLog(string message);
    class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

       // static int Tong(int a, int b) => a + b;

        //static int Hieu(int a, int b) => a - b;

        static void Tong(int a, int b, ShowLog log)
        {
            int kq = a + b;
            log?.Invoke($"Tong la {kq}");
        }
        static void Main(string[] args)
        {

            // Action action; // ~ delegate void KIEU();
            //   Action<string, int> action1;

            //  Action<string> action2;

            // action2 = Warning;
            //  action2 += Info;
            // action2?.Invoke("Thong bao tu Action");


            // Func<int> f1;                     // ~ delegate int KIEU();
            //  Func<string, double, string> f2; // ~ delegate string KIEU(string s, double s);

            // Func<int, int, int> tinhtoan; //~delegate int KIEU(inta, int b);
            // int a = 5;
            //int b = 10;

            //tinhtoan = Tong;
            //Console.WriteLine($"Tong la {tinhtoan(a, b)}");

            Tong(4, 5, Info);

        }

    }
}



