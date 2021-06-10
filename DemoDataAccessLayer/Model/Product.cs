using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDataAccessLayer.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public Decimal UnitPrice { get; set; }

        public Product()
        {
        }

        public Product(int productID, string productName, string quantityPerUnit, decimal unitPrice)
        {
            ProductID = productID;
            ProductName = productName;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
        }

        public override string ToString()
        {
            return $"ProductID: {ProductID} \nProductName: {ProductName} \nQuantityPerUnit: {QuantityPerUnit} \nUnitPrice: {UnitPrice}";
        }
    }
}
