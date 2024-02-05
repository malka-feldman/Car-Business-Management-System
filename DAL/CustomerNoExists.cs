using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class CustomerNoExists :Exception
    {
        public CustomerNoExists() : base("Customer doesn't exist")
        {

        }

        public CustomerNoExists(string messageValue) : base(messageValue)
        {

        }

        public CustomerNoExists(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }
    }
}
