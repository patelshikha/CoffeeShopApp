using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.Model
{
    class OrderItem
    {
        public string[] _OrderItems = new string[50];
 public string[] OrderItems{
 
    get=> _OrderItems;
   
    set =>_OrderItems = value;
    
       }
        public OrderItem() 
        { 
        Console.WriteLine("Default Constructor of order item class"); 
        } 
        public OrderItem(string[] _OrderItem)
            {
                this._OrderItem=_OrderItem;
            }

    }
}
