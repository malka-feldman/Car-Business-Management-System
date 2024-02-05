using OOPPROJECT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerDal customerDAL = new CustomerDal();
            try
            {
                customerDAL.Create(new Customer("malka", 123));
            }
            catch (CustomerAlreadyExistsException e)
            {
                Console.WriteLine(e.Message);
            }
            /*try
            {
                productDAL.Delete(7);
            }
            catch (ReqProdNumNoExistException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Testing update method should return a bool");
            try
            {
                Console.WriteLine(productDAL.Update(new Product(2, "desktop", 32.23)));
            }
            catch(ReqProdNumNoExistException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Testing retrieve method should return a product");
            try
            {
                Console.WriteLine(productDAL.Retrieve(7));
            }
            catch (ReqProdNumNoExistException e)
            {
                Console.WriteLine(e.Message);
            }*/
            //this has been tested
        }
    }
}
