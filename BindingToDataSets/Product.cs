using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToDataSets
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public bool Discontinued { get; set; }

        public Product(int id, string name, int categoryId, string quantity, decimal price, int inStock, int onOrder)
        {
            ProductID = id;
            ProductName = name;
            CategoryId = categoryId;
            QuantityPerUnit = quantity;
            UnitPrice = price;
            UnitsInStock = inStock;
            UnitsOnOrder = onOrder;
        }
    }
}
