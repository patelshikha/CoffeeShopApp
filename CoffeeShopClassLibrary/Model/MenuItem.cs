using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.Model
{
    class MenuItem
    {
        private string _ItemName;
        public string ItemName{ get => _ItemName; set => _ItemName = value; }
        private string _ItemDescription;
        public string ItemDescription{ get => _ItemDescription; set => _ItemDescription = value; }
       
        private double _ItemCost;
        public double ItemCost { get => _ItemCost; set => _ItemCost = value; }
       
       public MenuItem() 
       { 
        Console.WriteLine("Default Constructor of menu item class"); 
       }         public MenuItem(string _ItemName, string _ItemDescription, double _ItemCost)            {                this._ItemName = _ItemName;                this._ItemDescription = _ItemDescription;                this._ItemCost = _ItemCost;             }
    }
}
