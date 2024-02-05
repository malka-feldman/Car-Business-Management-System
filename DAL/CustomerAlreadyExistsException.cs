using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerAlreadyExistsException : Exception
    {
        public CustomerAlreadyExistsException() : base("Customer already exists")
        {

        }

        public CustomerAlreadyExistsException(string messageValue) : base(messageValue)
        {

        }

        public CustomerAlreadyExistsException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }
    }
}
