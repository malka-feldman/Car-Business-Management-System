using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderNoExist : Exception
    {
        public OrderNoExist() : base("Order doesn't exist :(")
        {

        }

        public OrderNoExist(string messageValue) : base(messageValue)
        {

        }

        public OrderNoExist(string messageValue, Exception inner)
            : base(messageValue, inner)
        {

        }
    }
    }
