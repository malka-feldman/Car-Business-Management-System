using OOPPROJECT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;
using System.CodeDom;
using System.Collections;

namespace DAL
{
    public class OrderDal
    {
        static List<Order> Orders = new List<Order>();
        bool loaded = false;
        public List<Product> products;
        ProductDAL instanceA = new ProductDAL();
        //  public List<Product> products;

        public OrderDal()
        {

        }
        public OrderDal(List<Product> products)
        {
            this.products = products;
            if (loaded == false)
            {
                InitializeList();
            }
        }

        public void InitializeList()
        {
            StreamReader input = new StreamReader(@"..\..\..\DAL\bin\Debug\OrderList.txt");

            using (input)
            {
                while (!input.EndOfStream)
                {
                    Orders.Add(new Order(int.Parse(input.ReadLine()), int.Parse(input.ReadLine()), int.Parse(input.ReadLine()), int.Parse(input.ReadLine())));
                }
            }
            loaded = true;
        }

        public string printList()
        {
            string strfinal = " ";
            foreach(Order o in Orders)
            {
                string str = "Your order number is: " + o.OrderNum;
                string str1 = "The products in this order: " + Retrieve(o.ProductNum);
                strfinal = str + str1;
            }
            return strfinal;
        }

        public Order Create(Order item, List<Product> products)/*, List<Product> products*/
        {
            Order newitem;
            foreach (Order Order in Orders)
            {
                if (item.OrderNum == Order.OrderNum)
                {
                    throw new OrderAlreadyExistsException();
                }
            }

            foreach (Product prod in ProductDAL.products)
            {
                if (prod.ProductNum == item.ProductNum)
                {
                    if(item.OrderQuantity <= prod.AmountInStock)
                    {
                        prod.AmountInStock -= item.OrderQuantity;
                        newitem = new Order(item.ProductNum, item.CustomerID, item.OrderNum, item.OrderQuantity, prod.ProductName);
                        Orders.Add(newitem);
                        return newitem;
                    }
                    throw new ProductNotInStock();
                }
            }
            throw new ReqProdNumNoExistException();
        }

        public string readByCustomer(int custID)
        {
            string str = " ";
            ArrayList list = new ArrayList();
            Boolean orderFound = false;
            foreach (Order order in Orders)
            {
                if (custID == order.CustomerID)
                {
                    orderFound = true;
                    list.Add(order);
                }
            }
            if (orderFound == false)
            {
                throw new OrderNoExist();
            }
            foreach (var order in list)
            {
                str += order.ToString() + "\n";
            }
            return str;
        }

        public string readByProduct(int productNum)
        {
            string str = " ";
            ArrayList list = new ArrayList();
            Boolean orderFound = false;
            foreach (Order order in Orders)
            {
                if (productNum == order.ProductNum)
                {
                    orderFound = true;
                    list.Add(order);
                }
            }
            if (orderFound == false)
            {
                throw new OrderNoExist();
            }
            foreach (var orders in list)
            {
                str += orders.ToString() + "\n"; 
            }
            return str;
        }

        public string readAll()
        {
            string str = null;
            foreach (var orders in Orders)
            {
                str += orders.ToString() + "\n";
            }
            return str;
        }


        public Order Retrieve(int OrderNum1)
        {
            foreach (Product prod in ProductDAL.products)
            {
                for (int i = 0; i < Orders.Count; i++)
                {
                    if (Orders[i].OrderNum == OrderNum1)
                    {
                        Order order = new Order(Orders[i].ProductNum, Orders[i].OrderNum, Orders[i].CustomerID, Orders[i].OrderQuantity, prod.ProductName);
                        return order;
                    }
                }
            }
            throw new OrderNoExist();
        }
        public bool Update(Order item, List<Product> products)
        {
            foreach (Product prod in ProductDAL.products)
            {
                if (prod.ProductNum == item.ProductNum)
                {
                    for (int i = 0; i < Orders.Count; i++)
                    {
                        if (Orders[i].OrderNum == item.OrderNum)
                        {
                            Orders.RemoveAt(i);
                            Orders.Add(item);
                            return true;
                        }
                    }
                    throw new OrderNoExist();
                }
            }
            throw new ReqProdNumNoExistException();
        }

        public void Delete(int OrderNum)
        {
            int index = 0;
            for (int i = 0; i < Orders.Count; i++)
            {
                if (Orders[i].ProductNum == OrderNum)
                {
                    index = i;
                    Orders.RemoveAt(index);
                    Console.WriteLine("Deleted");
                    return;
                }
            }
            throw new OrderNoExist();
        }
    }
}

