using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib;
namespace ProductApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection productCollection = new ProductCollection();
            string prompt = $"1.Add\n2.Delete\n3.Display\n4.Search\n5.Query\n6.Exit";
            char c = 'y';
            do
            {
                int option;
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter Product Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Product Unit price");
                            double price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Product Quantity");
                            int quantity = Convert.ToInt32(Console.ReadLine());
                            Product p = new Product(name,price,quantity);
                            productCollection.AddProduct(p);
                            break;
                        case 2:
                            Console.WriteLine("Enter Product Name to delete");
                            string nameDelete = Console.ReadLine();
                            productCollection.DeleteProduct(nameDelete);
                            break;
                        case 3:
                            Product[] productArray=productCollection.DisplayAll();
                            foreach(var obj in productArray)
                            {
                                Console.WriteLine(obj);
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter Product Name to seach");
                            string nameSearch = Console.ReadLine();
                            Product pItem=productCollection.Search(nameSearch);
                            Console.WriteLine(pItem);
                            break;
                        case 5:
                            Console.WriteLine("Enter Unit Price");
                            double priceComapare = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter operator > < =");
                            char ch = Convert.ToChar(Console.ReadLine());
                            Product[] pArray= productCollection.QueryUnitPrice(priceComapare, ch);
                            foreach(Product ob in pArray)
                            {
                                Console.WriteLine(ob);
                            }
                            break;
                        case 6:
                            break;
                    }
                }
                Console.WriteLine("Do you want to continue y/n ?");
                c = Convert.ToChar(Console.ReadLine());
            } 
            while (c != 'n');
            Console.ReadLine();
        }
    }
}
