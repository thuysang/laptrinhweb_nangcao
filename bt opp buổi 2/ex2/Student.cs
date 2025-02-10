using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{

    public class Student
    {

        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        // Constructor mặc định
        public Student()
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        // Constructor tham số
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        // Getter và Setter
        public int GetSID() { return SID; }
        public void SetSID(int id) { SID = id; }

        public string GetName() { return TenSV; }
        public void SetName(string ten) { TenSV = ten; }

        public string GetFaculty() { return Khoa; }
        public void SetFaculty(string kh) { Khoa = kh; }

        public float GetMark() { return DiemTB; }
        public void SetMark(float dtb) { DiemTB = dtb; }

        // Phương thức hiển thị thông tin sinh viên
        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Tên SV: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Điểm TB: {0}", this.DiemTB);
            Console.WriteLine("---------------------------");
        }
    }

    public class Tester
    {
        public static void tNhap1SV(Student sv)
        {
            Console.Write("Nhập mã SV: ");
            sv.SetSID(int.Parse(Console.ReadLine()));
            Console.Write("Nhập họ tên SV: ");
            sv.SetName(Console.ReadLine());
            Console.Write("Nhập khoa: ");
            sv.SetFaculty(Console.ReadLine());
            Console.Write("Nhập điểm TB: ");
            sv.SetMark(float.Parse(Console.ReadLine()));
        }

        public static void NhapDS(Student[] DSSV)
        {
            for (int i = 0; i < DSSV.Length; i++)
            {
                Console.WriteLine($"Nhập thông tin sinh viên {i + 1}:");
                DSSV[i] = new Student(); // Khởi tạo phần tử trong mảng
                tNhap1SV(DSSV[i]);
            }
        }

        public static void XuatDS(Student[] DSSV)
        {
            Console.WriteLine("\n==== DANH SÁCH SINH VIÊN ====");
            foreach (Student sv in DSSV)
            {
                sv.Show();
            }
        }

        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(Console.ReadLine());
            Student[] DSSV = new Student[n];

            NhapDS(DSSV);
            XuatDS(DSSV);

            Console.ReadLine();
        }
    }

}
