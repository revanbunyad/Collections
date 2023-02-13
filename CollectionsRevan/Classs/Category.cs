using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections.Classs
{
    internal class Category
    {
        private int _id;
        public int Id { get; set; }
        public string Name { get; set; }

        public Category(string name)
        {
            _id++;
            Id = _id;
            Name = Name;

        }

        List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
            bool nameValid = Regex.IsMatch(product.Name, @"^[a-zA-Z]+$");
            if(!nameValid) 
            {
                throw new ValidStringException("Adinizda yalniz herfler olmalidir");
            }
            if (product.Price<0)
            {
                throw new ArgumentOutOfRangeException("Qiymet 0-dan boyuk olmalidir");
            }

        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        
        public void GetFullInfo()
        {
            foreach (Product prd in products)
            {
                Console.WriteLine(prd.GetInfo);
            }
        }
       

    }
}
