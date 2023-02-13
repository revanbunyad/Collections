using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections.Classs
{
    internal class Product
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Country { get; set; }

        public Product(int id,string name, string country,int price)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Country = country;
            
        }

        public string GetInfo()
        {
            return $"{Id}-{Name} {Price}Azn {Country} ";
        }
    }
    
}
