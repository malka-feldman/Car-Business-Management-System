using Entities;
using OOPPROJECT1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDal
    {
        static List<Customer> customers = new List<Customer>();
        static bool loaded = false;

        public CustomerDal()
        {
            if (loaded == false)
            {
                InitializeList();
            }
        }
        public void InitializeList()
        {
            StreamReader cinput = new StreamReader(@"..\..\..\DAL\bin\Debug\CustomerTextFile.txt");
            using (cinput)
                {
                    while (!cinput.EndOfStream)
                    {
                        customers.Add(new Customer(cinput.ReadLine(), int.Parse(cinput.ReadLine())));
                    }
                }
            loaded = true;
        }

        public string printList()
        {
            string str = String.Join("\n", customers);
            return str;
        }
        public Customer Create(Customer custo)
        {
            foreach (Customer customer in customers)
            {
                if (customer.Id == custo.Id)
                {
                    throw new CustomerAlreadyExistsException();
                }
            }
            Customer newcustomer = new Customer(custo.Name, custo.Id);
            customers.Add(newcustomer);
            return newcustomer;
        }

        public Customer Retrieve(int id)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == id)
                {
                    Customer customer1 = new Customer(customers[i].Name, customers[i].Id);
                    Customer newCustomer1 = new Customer(customer1.Name, customer1.Id);
                    return newCustomer1;
                }
            }
            throw new CustomerNoExists();
        }

        public bool Update(Customer custo)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == custo.Id)
                {
                    customers.RemoveAt(i);
                    customers.Add(custo);
                    return true;
                }
            }
            throw new CustomerNoExists();
        }

        public void Delete(int id)
        {
            int index = 0;
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == id)
                {
                    index = i;
                    customers.RemoveAt(index);
                    Console.WriteLine("Deleted");
                    return;
                }
            }
            throw new CustomerNoExists();

        }
    }
}
