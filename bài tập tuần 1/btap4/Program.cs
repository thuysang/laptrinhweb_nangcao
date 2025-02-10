using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Đảm bảo hiển thị tiếng Việt trong Console

            Console.WriteLine("Chào mừng bạn đến với trò chơi đoán số!");
            Console.WriteLine("Hãy đoán một số từ 1 đến 100. Bạn có 7 lượt đoán.\n");

            Random random = new Random(); // Tạo đối tượng Random để sinh số ngẫu nhiên
            int winningNumber = random.Next(1, 101); // Sinh số ngẫu nhiên từ 1 đến 100
            int maxAttempts = 7; // Số lần đoán tối đa
            int attempts = 0; // Biến đếm số lần đã đoán

            while (attempts < maxAttempts)
            {
                Console.Write($"Lượt đoán {attempts + 1}/{maxAttempts}. Nhập số bạn đoán: ");
                int userGuess;

                // Kiểm tra nhập đúng số nguyên
                if (!int.TryParse(Console.ReadLine(), out userGuess))
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
                    continue; // Yêu cầu người chơi nhập lại
                }

                // Tăng biến đếm số lần đoán
                attempts++;

                // So sánh số người chơi đoán với số trúng thưởng
                if (userGuess == winningNumber)
                {
                    Console.WriteLine($"Chúc mừng! Bạn đã đoán đúng số {winningNumber}.");
                    break; // Kết thúc trò chơi nếu đoán đúng
                }
                else if (userGuess < winningNumber)
                {
                    Console.WriteLine("Số bạn đoán nhỏ hơn số cần tìm.");
                }
                else
                {
                    Console.WriteLine("Số bạn đoán lớn hơn số cần tìm.");
                }

                // Nếu hết lượt đoán
                if (attempts == maxAttempts)
                {
                    Console.WriteLine($"\nRất tiếc! Bạn đã hết lượt. Số cần tìm là {winningNumber}.");
                }
            }

            Console.WriteLine("\nCảm ơn bạn đã tham gia trò chơi!");
        }
    }
}
   