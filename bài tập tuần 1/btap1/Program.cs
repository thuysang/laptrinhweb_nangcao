using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                // Nhập hai số nguyên a và b
                Console.Write("Nhập số nguyên a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Nhập số nguyên b: ");
                int b = int.Parse(Console.ReadLine());

                // Nhập toán tử
                Console.Write("Nhập toán tử (+, -, *, /): ");
                char op = char.Parse(Console.ReadLine());

                // Tính toán và in kết quả
                switch (op)
                {
                    case '+':
                        Console.WriteLine($"Kết quả: {a} + {b} = {a + b}");
                        break;
                    case '-':
                        Console.WriteLine($"Kết quả: {a} - {b} = {a - b}");
                        break;
                    case '*':
                        Console.WriteLine($"Kết quả: {a} * {b} = {a * b}");
                        break;
                    case '/':
                        if (b != 0)
                        {
                            Console.WriteLine($"Kết quả: {a} / {b} = {(double)a / b}");
                        }
                        else
                        {
                            Console.WriteLine("Lỗi: Không thể chia cho 0.");
                        }
                        break;
                    default:
                        Console.WriteLine("Lỗi: Toán tử không hợp lệ.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập giá trị hợp lệ.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
    }
}
}