using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderAlreadyExistsException : Exception
    {
        public OrderAlreadyExistsException() : base("Order already exists")
        {

        }

        public OrderAlreadyExistsException(string messageValue) : base(messageValue)
        {

        }

        public OrderAlreadyExistsException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }
    }
}
