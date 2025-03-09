using System;
using System.Collections.Generic;
using System.Linq;

namespace linqexample
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // giá
        public string[] Colors { set; get; }     // các màu sắc
        public int Brand { set; get; }           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString()
           => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";

    }

    public class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Product p = new Product(1, "Abc", 1000, new string[] {"xanh", "do"}, 2);
            //Console.WriteLine(p);

            var brands = new List<Brand>() {
    new Brand{ID = 1, Name = "Công ty AAA"},
    new Brand{ID = 2, Name = "Công ty BBB"},
    new Brand{ID = 4, Name = "Công ty CCC"},
};

            var products = new List<Product>()
{
    new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
    new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
    new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
    new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
    new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
    new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
    new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
};
            int[] numbers = { 1, 2, 4, 6, 4, 2, 8, 9 };
            /*
             1) xac dinh nguon du lieu: from tenphantu in IEnumerables
               ...join,where, oderby, let tenbien = ???...
             2) Lay du lieu: select, group by ...
             */

        //lay ra ten san pham
            //var qr = from a in products select a.Name;
            //foreach (var name in qr)
            //{
            //    Console.WriteLine(name);
            //}

        //lay ra ten va gia san pham
            //var qr = from a in products select $"{a.Name} ; {a.Price}";
            //foreach (var name in qr)
            //{
            //    Console.WriteLine(name);
            //}

        //lay ra san pham co gia bang 400
            //var qr = from product in products
            //         where product.Price == 400
            //         select new
            //         {
            //             Ten = product.Name,
            //             Gia = product.Price,
            //         };
            //foreach (var name in qr)
            //{
            //    Console.WriteLine(name);
            //}

        //lay ra san pham co gia <= 500, mau Xanh
            //var qr = from product in products
            //         from color in product.Colors
            //         where product.Price <= 500 && color == "Xanh"
            //         select new
            //         {
            //             Ten = product.Name,
            //             Gia = product.Price,
            //             Cacmau = product.Colors    
            //         };
            //foreach (var abc in qr)
            //{
            //    Console.WriteLine($"{abc.Ten} - {abc.Gia}");
            //    Console.WriteLine(string.Join(',', abc.Cacmau));
            //}

        //nhom cac san pham theo gia
            //var qr = from p in products
            //         group p by p.Price into gr
            //         orderby gr.Key
            //         select gr;
            //qr.ToList().ForEach(group =>
            //{
            //    Console.WriteLine(group.Key);
            //    group.ToList().ForEach(p => Console.WriteLine(p));
            //});

        // Doi tuong co:
        // Gia
        // Cacsanpham
        // Soluong
            //var qr = from p in products
            //         group p by p.Price into gr
            //         orderby gr.Key //tang dan ve gia
            //         let sl = "So luong la: " + gr.Count()
            //         select new
            //         {
            //             Gia = gr.Key,
            //             Cacsanpham = gr.ToList(),
            //             Soluong = sl
            //         };

            //qr.ToList().ForEach(i =>
            //{
            //    Console.WriteLine(i.Gia);
            //    Console.WriteLine(i.Soluong);
            //    i.Cacsanpham.ForEach(p => Console.WriteLine(p));
            //});

        //ket hop cac nguon du lieu
            // liet ke cac san pham, ten, hang san xuat, gia cua san pham
            var qr = from product in products
                     join brand in brands on product.Brand equals brand.ID into t
                     from b in t.DefaultIfEmpty()
                     select new
                     {
                         ten = product.Name,
                         gia = product.Price,
                         thuonghieu = (b != null) ? b.Name : "No Brand"
              
                     };

            qr.ToList().ForEach(o =>
            {
                Console.WriteLine($"{o.ten,10} {o.thuonghieu,15} {o.gia,5}");

            });


//Cac phuong thuc
    // Select

        // lay san pham co gia 400
                //var query = from p in products where p.Price == 400 select p;
                //foreach (var product in query)
                //{
                //    Console.WriteLine(product);
                //}

        //lay danh sach ten cac san pham
                //var kq = products.Select(
                //   (p) =>
                //    {
                //        return p.Name;
                //    }
                //    );

                //foreach (var item in kq)
                //{
                //   Console.WriteLine(item);
                //}


        //lay danh sach ten va gia san pham
                //ar kq = products.Select(
                //  (p) =>
                //   {
                //       return p.Name + "(" + p.Price + ")";
                //   }
                //   );

                //foreach (var item in kq)
                //{
                //   Console.WriteLine(item);
                //}

        //tra ve du kieu kieu vo danh
                //var kq = products.Select(
                //   (p) =>
                //   {
                //       return new {
                //           Ten = p.Name,
                //           Gia = p.Price,

                //       };
                // }
                //   );

                //   foreach (var item in kq)
                //   {
                //       Console.WriteLine(item);
                //   }

    // Where

        //lay san pham ten co tr
                //var kq = products.Where(
                //    (p) =>
                //    {
                //        return p.Name.Contains("tr");
                //    }
                //    );
                //foreach (var item in kq)
                //{
                //    Console.WriteLine(item);
                //}

        //lay san pham co gia >=200 va <=400
                //var kq = products.Where(
                //    (p) =>
                //    {
                //        return p.Price >= 200 && p.Price <= 300;
                //    }
                //    );
                //foreach (var item in kq)
                //{
                //    Console.WriteLine(item);
                //}

    // SelectMany
                //var kq = products.SelectMany(
                //    (p) =>
                //    {
                //        return p.Colors;
                //    }
                //    );
                //foreach (var item in kq)
                //{
                //   Console.WriteLine(item);
                //}

    // Min, Max, Sum, Average

                //Console.WriteLine(numbers.Max());

                //Console.WriteLine(numbers.Min());

                //Console.WriteLine(numbers.Sum());

                //Console.WriteLine(numbers.Average());

      //so chan lon nhat
                //Console.WriteLine(numbers.Where(n => n%2 == 0).Max());

        //gia nho nhat cua san pham
                //Console.WriteLine(products.Min(p => p.Price));

    // Join - ket hop 2 nguon du lieu

                //var kq = products.Join(brands, p => p.Brand, b => b.ID, (p, b) =>
                //{
                //    return new
                //    {
                //        Ten = p.Name,
                //        Thuonghieu = b.Name,
                //    };
                //});

                //    foreach (var item in kq)
                //{
                //     Console.WriteLine(item);
                //}

    // GroupJoin

                //var kq = brands.GroupJoin(products, b => b.ID, p => p.Brand,

                //    (brand, pros) =>
                //    {
                //        return new
                //        {
                //            Thuonghieu = brand.Name,
                //            Cacsanpham = pros,
                //        };
                //    }
                //);

                //foreach ( var gr in kq )
                //{
                //    Console.WriteLine(gr.Thuonghieu);
                //    foreach(var p in gr.Cacsanpham)
                //    {
                //        Console.WriteLine(p);

                //    }
                //}

    // Take 

        // in thong tin 4 san pham dau tien
                //products.Take(4).ToList().ForEach( p => Console.WriteLine(p));

    // Skip

                //bo qua thong tin 2 phan tu dau tien, lay nhung phan tu con lai
                //products.Skip(2).ToList().ForEach(p => Console.WriteLine(p));

                // OderBy (tang dan) - OderByDescending (giam dan)

                //in san pham tang dan ve gia
                //products.OrderBy(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));
                //in san pham giam dan ve gia
                //products.OrderByDescending(p => p.Price).ToList().ForEach(p => Console.WriteLine(p));


    // Reverse  - dao nguoc thu tu cac phan tu trong tap hop
                //numbers.Reverse().ToList().ForEach(n => Console.WriteLine(n));

    // GroupBy
       //nhom cac san pham theo gia
                //var kq = products.GroupBy(p => p.Price);
                //foreach(var group in kq)
                //{
                //    Console.WriteLine(group.Key);
                //    foreach (var p in group)
                //    {
                //        Console.WriteLine(p);
                //    }
                //}
 
   // Distinct - loai bo nhung phan tu cung gia tri
                //products.SelectMany(p => p.Colors).Distinct().ToList()
                //    .ForEach(mau => Console.WriteLine(mau));

    // Single - kiem tra cac phan tu thoa man 1 dieu kien logic nao do - neu khong co se phat sinh loi
                //var p = products.Single(p => p.Price == 600);
                //Console.WriteLine(p);

    //neu khong muon phai phat sinh loi - SingleOrDefault - khi khong tim thay tra ve kq la null
                //var p = products.SingleOrDefault(p => p.Price == 1000);
                //Console.WriteLine(p);

    // Any - tra ve true neu thoa man 1 dieu kien logic nao do
                //var p = products.Any(p => p.Price == 600);
                //Console.WriteLine(p);

    // All - tat ca cac phan tu phai thoa man 1 dieu kien logic nao do
        //kiem tra cac phan tu deu co gia tren 200
                //var p = products.All(p => p.Price >= 300);
                //Console.WriteLine(p);

    // Count - dem so luong
        // dem tat ca cac san pham
                //var p = products.Count();
                //Console.WriteLine(p); 
        // dem tat ca cac san pham co gia tren 300
                //var p = products.Count(p => p.Price >= 300);
                //Console.WriteLine(p);


        // In ra ten san pham, ten thuong hieu cos gia tu 300 - 400
        // gia giam dan
                //products.Where(p => p.Price >= 300 && p.Price <= 400)
                //    .OrderByDescending(p => p.Price)
                //    .Join(brands, p => p.Brand, b => b.ID, (sp, th) =>
                //    {
                //        return new
                //        {
                //            TenSP = sp.Name,
                //            TenTH = th.Name,
                //            Gia = sp.Price,
                //        };
                //    })
                //    .ToList()
                //    .ForEach(info =>
                //    {
                //        Console.WriteLine($"{info.TenSP, 15} {info.TenTH, 15}, {info.Gia, 5} ");
                //    });




        }
    }
}


