using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using OOPPROJECT1;
using System.Runtime.Remoting.Messaging;
using Entities;

namespace DAL
{

    public class ProductDAL
    {
        //public static List<Product> products { get; set;}
        public static List<Product> products = new List<Product>();
        static bool loaded = false;

        public ProductDAL()
        {
            if (loaded == false)
            {
                InitializeList();
            }
        }

        public void InitializeList()
        {
            StreamReader input = new StreamReader(@"..\..\..\DAL\bin\Debug\Products1.txt");

            using (input)
            {
                while (!input.EndOfStream)
                {
                    products.Add(new Product(int.Parse(input.ReadLine()), input.ReadLine(), double.Parse(input.ReadLine()), int.Parse(input.ReadLine())));
                }
            }
            loaded = true;
        }

        public string printList()
        {
            string str = String.Join("\n ", products);
            return str;
        }
        public Product Create(Product item)
        {
            foreach (Product product in products)
            {
                if (item.ProductNum == product.ProductNum)
                {
                    throw new ProdAlreadyExistsException();
                }
            }
            Product newitem = new Product(item.ProductNum, item.ProductName, item.CPU, item.AmountInStock); 
            products.Add(newitem);
            return newitem;
         }

        public Product Retrieve(int productNum)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductNum == productNum)
                {
                    Product prod = new Product(products[i].ProductNum, products[i].ProductName, products[i].CPU, products[i].AmountInStock);
                    return prod;
                }
            }
            throw new ReqProdNumNoExistException();
        }
        public bool Update(Product item)
        {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].ProductNum == item.ProductNum)
                    {
                        products.RemoveAt(i);
                        products.Add(item);
                        return true;
                    }
                }
                throw new ReqProdNumNoExistException();
        }

        public void Delete(int productNum)
        {
            int index = 0;
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].ProductNum == productNum)
                    {
                        index = i;
                        products.RemoveAt(index);
                        Console.WriteLine("Deleted");
                        return;  
                    }
                }//end for
                throw new ReqProdNumNoExistException();
        }
    }
}

