﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine
{
    public class InventoryItem : INotifyPropertyChanged
    {
        #region Fields
        private Item _details;
        private int _quantity;
        #endregion

        #region Properties
        public Item Details { get { return _details; } set {_details = value; OnPropertyChanged("Details");}}
        public int Quantity { get { return _quantity; } set { _quantity = value; OnPropertyChanged("Quantity"); OnPropertyChanged("Description"); } }
        public int ItemID { get { return Details.ID; }}
        public string Description { get { return Quantity > 1 ? Details.NamePlural : Details.Name; }}
        public int Price { get { return Details.Price; }}
        #endregion

        #region Constructors
        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }

        public InventoryItem(Weapon details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
        #endregion

        #region Property Change
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}
