using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.Model
{
    class Order
    {
         private static int _OrderId = 1;
         private string _CustomerName;
        public string CustomerName { get => _CustomerName; set => _CustomerName = value; }
         private DateTime _OrderTime;
        public DateTime OrderTime { get => _OrderTime; set => _OrderTime = value; }
        private DateTime _DeliveryTime;
        public DateTime DeliveryTime { get => _DeliveryTime; set => _DeliveryTime = value; }
       
        public struct deliveryAddress
        {
            public string x;

            public Coords(string p)
            {
                 x = p;
            }
        }

        private double _Cost;
        public double Cost { get => _Cost; set => _Cost = value; }
         private string _OrderType;
        public string OrderType { get => _OrderType; set => _OrderType = value; }
    
        public string[] _OrderItems = new string[50];
 public string[] OrderItems{
 
    get=> _OrderItems;
   
    set =>_OrderItems = value;
    
       }


        public Order() 
        { 
        Console.WriteLine("Default Constructor of order class"); 
        } 

        public Order(string _CustomerName,DateTime _OrderTime,
            DateTime _DeliveryTime,double _Cost,string _OrderType)
            {
             _OrderId = _OrderId++;
            this._CustomerName = _CustomerName;
            this._OrderTime = _OrderTime;
            this._DeliveryTime = _DeliveryTime;
            this._Cost = _Cost;
            this._OrderType = _OrderType;
            }

    }
}
