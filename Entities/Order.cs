using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Entities
{

    public class Order
    {
        public int ProductNum { get; set; } 
        public int CustomerID { get; set; }
        public int OrderQuantity { get; set; }
        public int OrderNum { get; set; }

        public string ProductName { get; set; }
        DateTime DateTime { get; set; }

        public Order(int productNum, int customID, int orderNum, int orderQuantity)
        {
            CustomerID = customID;
            ProductNum = productNum;
            OrderNum = orderNum;
            OrderQuantity = orderQuantity;
            DateTime = DateTime.Now;
        }
        public Order(int productNum, int customID, int orderNum, int orderQuantity, string ProductName)
        {
            CustomerID = customID;
            ProductNum = productNum;
            OrderNum = orderNum;
            OrderQuantity = orderQuantity;
            DateTime = DateTime.Now;
            this.ProductName = ProductName;
        }

        public override string ToString()
        {
            return $"Order Number: {OrderNum}, {DateTime} \n Product Ordered ID: {ProductNum} Product Name: {ProductName} Quantity: {OrderQuantity}";
        }
    }
}
