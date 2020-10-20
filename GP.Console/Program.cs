using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Provider p1 = new Provider();
            //p1.Password = "123456";
            //p1.ConfirmPassword = "123456";

            Category c1 = new Category() { Name = "Cat1", CategoryId = 1 };
            Category c2 = new Category() { Name = "Cat2", CategoryId = 2 };
            Category c3 = new Category() { Name = "Cat3", CategoryId = 3 };
            Product prod1 = new Product()
            {
                ProductId=1,
                Name = "PROD1",
                DateProd = DateTime.Now,
                Price = 20,
                Quantity = 5,
                Category = c1
            };
            Product prod2 = new Product()
            {
                ProductId = 2,
                Name = "PROD2",
                DateProd = DateTime.Now,
                Price = 40,
                Quantity = 50,
                Category = c1
            };

            Product prod3 = new Product()
            {
                ProductId = 3,
                Name = "PROD3",
                DateProd = DateTime.Now,
                Price = 40,
                Quantity = 50,
                Category = c3
            };
            Product prod4 = new Product()
            {
                ProductId = 4,
                Name = "PROD4",
                DateProd = DateTime.Now,
                Price = 40,
                Quantity = 50,

            };
            Product prod5 = new Product()
            {
                ProductId = 5,
                Name = "PROD5",
                DateProd = DateTime.Now,
                Price = 40,
                Quantity = 50,
                Category = c2
            };
            Product prod6 = new Product()
            {
                ProductId = 6,
                Name = "PROD",
                DateProd = DateTime.Now,
                Price = 40,
                Quantity = 50,
                Category = c3
            };

            // initialisateur d'objet

            Provider p1 = new Provider(){ Password = "123456" ,
                 ConfirmPassword = "123456"  };
            p1.Products = new List<Product>() { prod1, prod2, prod3 };


           

            System.Console.WriteLine("la valeur initial de isapproved= "+p1.IsApproved);

            System.Console.WriteLine("Passage par valeur");
            Provider.SetIsApproved(p1.Password, p1.ConfirmPassword, p1.IsApproved);
            System.Console.WriteLine(p1.IsApproved);

            System.Console.WriteLine("Passage par reference");
            Provider.SetIsApproved(p1);
            System.Console.WriteLine(p1.IsApproved);
            

            Provider p2 = new Provider("123456", DateTime.Now,
                "provider@gmail.com",
                2, false, "123457", "provider2");
            p2.Products = new List<Product>() { prod1, prod5 };

           

            Provider p3 = new Provider()
            {
                Id = 3,
                ConfirmPassword = "00000",
                Password = "00000"
            };
            p3.Products = new List<Product>() { prod1, prod4 };
            Provider p4 = new Provider()
            {
                Id = 4,
                ConfirmPassword = "00000",
                Password = "00000"
            };
            p4.Products = new List<Product>() { prod6, prod4 };
            Provider p5 = new Provider()
            {
                Id = 5,
                ConfirmPassword = "00000",
                Password = "00000"
            };
            p4.Products = new List<Product>() { prod6, prod4 };

            System.Console.WriteLine("les details de 1er Provider");
            p1.GetDetails();
            System.Console.WriteLine("les details de 2eme Provider");
            p2.GetDetails();

            prod1.GetMyType();

            Chemical ch1 = new Chemical()
            {
                LabName = "esprit",
                City="tunis",
                StreetAddress="Ghazela",
                ProductId = 10,
                DateProd = DateTime.Now,
                Price = 40,
                Quantity = 50,
                Category = c2
                
            };

            ch1.GetMyType();
            ch1.GetDetails();


            System.Console.ReadKey();
        }
    }
}
