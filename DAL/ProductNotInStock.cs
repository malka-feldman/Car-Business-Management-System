using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductNotInStock : Exception
    {
        public ProductNotInStock() : base("Sorry, not enough items in stock.")
        {

        }

        public ProductNotInStock (string messageValue) : base(messageValue)
        {

        }

        public ProductNotInStock(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }
    }
}
