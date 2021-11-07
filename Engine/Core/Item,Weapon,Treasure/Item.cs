using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item : IItem
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public string Desc { get; set; }
        public int Price { get; set; }
        public bool Equiptable { get; set; }
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
