using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine
{
    public class InventoryItem
    {
        #region Properties
        public IItem Details { get; set; }
        public int Quantity { get; set; }
        public int ItemID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string WeaponName { get; set; }
        public string WeaponDesc { get; set; }
        public string WeaponDamage { get; set; }
        public string WeaponDamageType { get; set; }
        public int WeaponPrice { get; set; }
        
        #endregion

        #region Constructors
        public InventoryItem(IItem details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }

        public InventoryItem(Weapon weapon, int quantity)
        {            
            WeaponName = weapon.Name;
            WeaponDesc = weapon.Desc;
            WeaponDamage = weapon.Damage;
            WeaponDamageType = weapon.DamageType;
            WeaponPrice = weapon.Price;
            //Details = weapon;
            Quantity = quantity;
        }
        #endregion
    }
}
