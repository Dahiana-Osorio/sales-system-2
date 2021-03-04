using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Business business = new Business();

            Salesman s1 = new Salesman();
            s1.Name = "Julio";
            s1.Age = 45;
            s1.Gender = 1;
            business.AddSalesman(s1);

            Salesman s2 = new Salesman();
            s2.Name = "Maria";
            s2.Age = 35;
            s2.Gender = 0;
            business.AddSalesman(s2);

            Salesman s3 = new Salesman();
            s3.Name = "Natalia";
            s3.Age = 22;
            s3.Gender = 0;
            business.AddSalesman(s3);

            Product p1 = new Product();
            p1.Name = "shoes";
            p1.Price = 70000;
            business.AddProduct(p1);

            Product p2 = new Product();
            p2.Name = "shirts";
            p2.Price = 40000;
            business.AddProduct(p2);

            Product p3 = new Product();
            p3.Name = "lotions";
            p3.Price = 50000;
            business.AddProduct(p3);

            Sale v1 = new Sale();
            v1.Salesman = s1;
            v1.Product = p1;
            v1.Comments = "Sale #1";
            business.AddSales(v1);

            Sale v2 = new Sale();
            v2.Salesman = s2;
            v2.Product = p2;
            v2.Comments = "Sale #2";
            business.AddSales(v2);

            Sale v3 = new Sale();
            v3.Salesman = s3;
            v3.Product = p3;
            v3.Comments = "Sale #3";
            business.AddSales(v3);

            Sale v4 = new Sale();
            v4.Salesman = s3;
            v4.Product = p2;
            v4.Comments = "Sale #4";
            business.AddSales(v4);

            // Sumar el total de las ventas
            int sum = (v1.Product.Price + v2.Product.Price + v3.Product.Price + v4.Product.Price);
            System.Console.WriteLine("Sales total amount: " + sum);
            // products price average
            int prom = (p1.Price+p2.Price+p3.Price)/3;
            System.Console.WriteLine("average product price: " + prom);

            business.Biggestproduct();
            business.Lessproduct();
            business.Cheapseller();
            business.Unitproduct();
        }
    }
}
