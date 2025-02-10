using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Đảm bảo hiển thị tiếng Việt trong Console

            Console.WriteLine("Chương trình kiểm tra số nguyên tố");

            int n;

            // Vòng lặp để đảm bảo nhập một số nguyên n ≥ 2
            do
            {
                Console.Write("Nhập một số nguyên n (n ≥ 2): ");
                n = int.Parse(Console.ReadLine()); // Chuyển đổi giá trị nhập từ chuỗi sang số nguyên
                if (n < 2)
                {
                    // Nhắc nhở nếu số nhập vào nhỏ hơn 2
                    Console.WriteLine("Số n phải lớn hơn hoặc bằng 2. Vui lòng nhập lại.");
                }
            } while (n < 2); // Tiếp tục yêu cầu nhập lại nếu n < 2

            // Kiểm tra n có phải là số nguyên tố hay không
            if (IsPrime(n))
            {
                Console.WriteLine($"Số {n} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"Số {n} không phải là số nguyên tố.");
            }
        }

        // Phương thức kiểm tra số nguyên tố
        static bool IsPrime(int number)
        {
            if (number < 2) return false; // Các số nhỏ hơn 2 không phải là số nguyên tố

            // Kiểm tra các ước từ 2 đến √number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    // Nếu tìm thấy ước (chia hết), thì không phải số nguyên tố
                    return false;
                }
            }
            // Nếu không tìm thấy ước nào, số đó là số nguyên tố
            return true;
        }
    }
}
    