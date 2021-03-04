using System;
using System.Collections.Generic;
using System.Text;

namespace Sales
{
    class Business
    {
        Salesman[] Salesmans = new Salesman[3];
        int salesmancount = 0;

        Product[] Products = new Product[3];
        int productcount = 0;

        Sale[] Sales= new Sale[1000];
        int salescount = 0;

        public void AddSalesman(Salesman newsalesman)
        {
            Salesmans[salesmancount] = newsalesman;
            salesmancount++;
        }
        public void AddProduct(Product newproduct)
        {
            Products[productcount] = newproduct;
            productcount++;
        }

        public void AddSales(Sale newsales)
        {
            Sales[salescount] = newsales;
            salescount++;
        }

        public int countsales()
        {
            int count = 0;
            for (int i=0; i<salescount-1; i++  )
            {

            }
            return count;
        }

        //Who´s the seller (sales man name), who has sold the cheapest product
        public int Lessproduct()
        {
            int higher = 0;

            for (int i = 0; i < productcount; i++)
            {
                if (Products[i].Price > higher)
                {
                    higher = Products[i].Price;
                }

            }
            int less = higher;
            for (int i = 0; i < productcount; i++)
            {
                if (Products[i].Price < less)
                {
                    less = Products[i].Price;
                   
                }

            }
            return less;
            
        }

        public void Cheapseller()
        {
           
            int menor = Lessproduct();
            string name = "";

            for (int i=0; i <salescount; i++)
            {
                if (Sales[i].Product.Price == menor)
                {
                    name = Sales[i].Salesman.Name;
                }
            }
            System.Console.WriteLine("The name of the seller who sold the cheapest product is: "+ name);
        }
        //Hoe many unit of the product has been sold

        public void Unitproduct()
        {
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            for (int i = 0; i < salescount; i++)
            {
                if (Sales[i].Product.Name == "shoes")
                {
                    p1++;
                }
                if (Sales[i].Product.Name == "shirts")
                {
                    p2++;
                }
                if (Sales[i].Product.Name == "lotions")
                {
                    p3++;
                }
            }
            System.Console.WriteLine("quantity of products sold is " + p1);
            System.Console.WriteLine("quantity of products sold is " + p2);
            System.Console.WriteLine("quantity of products sold is " + p3);

        }

        //What´s the most expensive product
        public void Biggestproduct()
        {
            int higher = 0;
            
            for(int i=0; i < productcount; i++)
            {
                if(Products[i].Price> higher)
                {
                    higher = Products[i].Price;
                }

            }
            System.Console.WriteLine("cost of the highest value product is: " + higher);
        }

    }
}
