using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using OOPPROJECT1;

namespace BLL
{
    public class CustomerBLL
    {
        public CustomerDal customer;

        public CustomerBLL(CustomerDal customer1)
        {
            this.customer = customer1;
        }

        public CustomerBLL()
        {
            customer = new CustomerDal();
        }

        public string printBLLList()
        {
            string str = customer.printList();
            return str;
        }
        public Customer Create(Customer custo)
        {
            try
            {
                return customer.Create(custo);
            }
            catch (CustomerAlreadyExistsException ce)
            {
                throw ce;
            }
        }

        public Customer Retrieve(int id)
        {
            try
            {
                return customer.Retrieve(id);
            }
            catch (CustomerNoExists ce)
            {
                throw ce;
            }
        }

        public bool Update(Customer custo)
        {
            try
            {
                return customer.Update(custo);
            }
            catch (CustomerNoExists ce)
            {
                throw ce;
            }
        }
        public void Delete(int id)
        {
            try
            {
                customer.Delete(id);
            }
            catch (CustomerNoExists ce)
            {
                throw ce;
            }
        }
    }
}
