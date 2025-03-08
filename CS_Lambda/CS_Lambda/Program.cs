using System;
using System.Linq;

namespace CS_Lambda
{
    /*
     Lambda - anonymous function

    1)
    (tham so) =>bieu_thuc;

    2)
    (tham_so) => {

    }

     */
    class Program
    {
        static void Main(string[] args)
        {
            // Action<string> thongbao;
            //thongbao = (string s) => Console.WriteLine(s); // ~delegate void KIEU(string s) = Action<string>

            //for (int i = 0; i < 10; i++)
            //  {
            //     thongbao?.Invoke("xin chao");
            // }    

            // (int a, int b) =>
            // {
            //    int kq = a + b;
            //     return kq;
            // } 

            // Action thongbao;
            // thongbao = () => Console.WriteLine("Xin chao cac ban");
            // thongbao?.Invoke();


            //Action<string, string> welcome;
            //welcome = (mgs, name) => Console.WriteLine(mgs + " " + name);
            //welcome?.Invoke("Xin chao", "Thuy Sang");
            //welcome?.Invoke("Chao mung", "Thsan");


            //Action<string, string> welcome;
            //welcome = (mgs, name) =>
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine(mgs + " " + name);
            //    Console.ResetColor();
            // };
            //welcome?.Invoke("Xin chao", "Thuy Sang");
            //welcome?.Invoke("Chao mung", "Thsan");


            //Func<int, int, int> tinhtoan;

            //tinhtoan = (int a, int b) =>
            //{
            //    int kq = a + b;
            //   return kq;
            //};
            //Console.WriteLine(tinhtoan.Invoke(5, 6));


            //int[] mang = { 2, 4, 64, 5, 7, 8, 9, 33, 55 };

            //var kq = mang.Select(
            //   (int x) =>
            //{
            //    return Math.Sqrt(x);
            //});

            //foreach (var result in kq)
            //{
            //   Console.WriteLine(result);
            // }

            //int[] mang = { 2, 4, 64, 5, 7, 8, 9, 33, 55 };

            //mang.ToList().ForEach(
            //   (int x) =>
            //    {
            //        if ( x % 2 != 0)
            //            Console.WriteLine(x);
            //    });


            //int[] mang = { 2, 4, 64, 5, 7, 8, 9, 33, 55 };
            //var kq = mang.Where(
            //    (x) =>
            //    {
            //        return x % 4 == 0;
            //    }
            //
            //    );
            //foreach (var n in kq)
            //{
            //    Console.WriteLine(n);
            //}


            int[] mang = { 2, 4, 64, 5, 7, 8, 9, 33, 55 };
            var kq = mang.Where(x => x >= 2 && x<= 35 );
            foreach (var n in kq)
            {
                Console.WriteLine(n);
            }

        }
    }
}