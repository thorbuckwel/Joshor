using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        private int _id;
        private string _name;
        private string _namePlural;
        private int _price;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string NamePlural { get { return _namePlural; } set { _namePlural = value; } }
        public int Price { get { return _price; } set { _price = value; } }

        public Item(int id, string name, string namePlural, int price)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Price = price;
        }
    }
}
