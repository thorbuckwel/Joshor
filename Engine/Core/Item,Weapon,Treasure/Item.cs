using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item : IItem
    {
        #region Fields
        private int _id;
        private string _name;
        private string _namePlural;
        private string _desc;
        private int _price;
        private bool _equiptable;
        #endregion

        #region Properties
        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string NamePlural { get { return _namePlural; } set { _namePlural = value; } }
        public string Desc { get { return _desc; } set { _desc = value; } }
        public int Price { get { return _price; } set { _price = value; } }
        public bool Equiptable { get { return _equiptable; } set { _equiptable = value; } }
        #endregion

        #region Constructor
        public Item(int id, string name, string namePlural, string desc, int price, bool equiptable)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Desc = Desc;
            Price = price;
            Equiptable = equiptable;
        }
        #endregion
    }
}
