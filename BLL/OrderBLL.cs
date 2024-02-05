using DAL;
using OOPPROJECT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using System.Threading.Tasks;
using System.Collections;

namespace BLL
{
    public class OrderBLL
    {
        public OrderDal Order;
        public List<Product> products;
        //public List<Product> Products;

        public OrderBLL(OrderDal Order, List<Product> products)/*, List<Product> products*/
        {
            this.Order = Order;
            this.products = products;
            /*            this.Products = products;
*/
        }
        public OrderBLL()
        {
            Order = new OrderDal();
        }
        public string PrintBLLList()
        {
            return Order.printList();
        }
        public string readAll()
        {
            return Order.readAll();
        }

        public string readByCustomer(int custID)
        {
            return Order.readByCustomer(custID);
        }

        public string ReadByProduct(int prodNum)
        {
            return Order.readByProduct(prodNum);
        }


        public Order Create(Order order)
        {
            try
            {
                return Order.Create(order, products);
            }
            catch (OrderAlreadyExistsException pe)
            {
                throw pe;
            }
            catch (ReqProdNumNoExistException ne)
            {
                throw ne;
            }

            catch (ProductNotInStock ns)
            {
                throw ns;
            }
        }

        public Order Retrieve(int OrdeructNum)
        {
            try
            {
                return Order.Retrieve(OrdeructNum);
            }
            catch (OrderNoExist re)
            {
                throw re;
            }
        }

        public bool Update(Order order)
        {
            try
            {
                return Order.Update(order, products);
            }
            catch (OrderNoExist re)
            {
                throw re;
            }
        }
        public void Delete(int OrderNum)
        {
            try
            {
               Order.Delete(OrderNum);
            }
            catch (OrderNoExist re)
            {
                throw re;
            }
        }
    }
}
