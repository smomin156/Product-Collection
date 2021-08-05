using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public  class ProductCollection
    {
        private  List<Product> products;
         public ProductCollection()
        {
            products = new List<Product>();
        }

        public  void AddProduct(Product obj)
        {
            products.Add(obj);
        }
        public  void DeleteProduct(string name)
        {
            var itemRemove = products.Single(p => p.ProductName == name);
            products.Remove(itemRemove);
        }
        public  Product[] DisplayAll()
        {
            return products.ToArray();
        }
        public Product Search(string name)
        {
            var item= products.Single(p => p.ProductName == name);
            return item;
        }
        public Product[] QueryUnitPrice(double unitPrice,char ch)
        {
            List<Product> pArray = new List<Product>();
            switch (ch)
            {
                case '>':
                    pArray = (products.FindAll(p => p.UnitPrice > unitPrice));
                    break;
                case '<':
                    pArray = (products.FindAll(p => p.UnitPrice < unitPrice));
                    break;
                case '=':
                    pArray = (products.FindAll(p => p.UnitPrice == unitPrice));
                    break;
                default:
                    break;

            }
            return pArray.ToArray();
        }

    }
 


}

