using System;
using System.Collections;
using System.Collections.Generic;

public class People
{
    private int id;
    private string name;

    public People()
    {
        id = 0;
        name = "No Name";
    }

    public People(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

 
    public virtual void Show()
    {
        Console.WriteLine("ID: {0}", id);
        Console.WriteLine("Name: {0}", name);
    }
}

public class Student : People
{
    private string faculty;
    private float gpa;


    public Student() : base()
    {
        faculty = "No Faculty";
        gpa = 0.0f;
    }


    public Student(int id, string name, string faculty, float gpa) : base(id, name)
    {
        this.faculty = faculty;
        this.gpa = gpa;
    }

  
    public string Faculty
    {
        get { return faculty; }
        set { faculty = value; }
    }

    public float GPA
    {
        get { return gpa; }
        set { gpa = value; }
    }

    
    public override void Show()
    {
        base.Show();
        Console.WriteLine("Faculty: {0}", faculty);
        Console.WriteLine("GPA: {0}", gpa);
        Console.WriteLine("---------------------------");
    }
}

public class Tester
{
    public static void Nhap1SV(Student sv)
    {
        Console.Write("Nhập mã SV: ");
        sv.Id = int.Parse(Console.ReadLine());

        Console.Write("Nhập họ tên SV: ");
        sv.Name = Console.ReadLine();

        Console.Write("Nhập khoa: ");
        sv.Faculty = Console.ReadLine();

        Console.Write("Nhập điểm TB: ");
        sv.GPA = float.Parse(Console.ReadLine());
    }

    public static void NhapDS(List<Student> DSSV)
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin sinh viên {i + 1}:");
            Student sv = new Student();
            Nhap1SV(sv);
            DSSV.Add(sv);
        }
    }

    public static void XuatDS(List<Student> DSSV)
    {
        Console.WriteLine("\n==== DANH SÁCH SINH VIÊN ====\n");
        foreach (Student sv in DSSV)
        {
            sv.Show();
        }
    }

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Sử dụng List<Student>
        List<Student> DSSV = new List<Student>();
        NhapDS(DSSV);
        XuatDS(DSSV);

        // Sử dụng ArrayList
        Console.WriteLine("\n==== DANH SÁCH SINH VIÊN (ArrayList) ====\n");
        ArrayList arrayListDSSV = new ArrayList(DSSV);
        foreach (Student sv in arrayListDSSV)
        {
            sv.Show();
        }

        Console.ReadLine();
    }
}
