using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Product
    {
        #region Fields
        private string productName;
        private double unitPrice;
        private int quantity;
        private double total;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        } 
        public double Total
        {
            get { return UnitPrice * Quantity; }
            private set { total = value; }
        }
        #endregion
        #region Constructor
        public Product(string name, double price, int quantity)
        {
            this.ProductName = name;
            this.UnitPrice = price;
            this.Quantity = quantity;
        }
        #endregion
        public override string ToString()
        {
            return string.Format($"Product Name:{ProductName} Unit Price:{UnitPrice} Quantity:{Quantity} Total:{Total}");
        }
    }
}
