using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8; // Đảm bảo hỗ trợ tiếng Việt trong Console

                Console.WriteLine("Giải phương trình bậc hai: ax^2 + bx + c = 0");

                try
                {
                    // Nhập các hệ số a, b, c
                    Console.Write("Nhập hệ số a (a ≠ 0): ");
                    double a = double.Parse(Console.ReadLine());

                    if (a == 0)
                    {
                        Console.WriteLine("Hệ số a phải khác 0. Đây không phải là phương trình bậc hai.");
                        return;
                    }

                    Console.Write("Nhập hệ số b: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.Write("Nhập hệ số c: ");
                    double c = double.Parse(Console.ReadLine());

                    // Tính delta
                    double delta = b * b - 4 * a * c;

                    Console.WriteLine($"Delta = {delta}");

                    // Kiểm tra giá trị của delta để tìm nghiệm
                    if (delta < 0)
                    {
                        Console.WriteLine("Phương trình vô nghiệm.");
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        Console.WriteLine($"Phương trình có nghiệm kép: x = {x}");
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine($"Phương trình có hai nghiệm phân biệt:");
                        Console.WriteLine($"x1 = {x1}");
                        Console.WriteLine($"x2 = {x2}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập đúng định dạng số.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
    }
}
    }
}
