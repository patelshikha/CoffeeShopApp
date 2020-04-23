using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopClassLibrary.Model
{
    public class Customer

    {
        [DataType(DataType.PhoneNumber)]
         private int _CustomerPhoneNo;
        public int CustomerPhoneNo { get => _CustomerPhoneNo; set => _CustomerPhoneNo = value; }
         private static int _CustomerId = 1;
        
        

        private string _CustomerName;
        public string CustomerName { get => _CustomerName; set => _CustomerName = value; }

        private string _CustomerAddress;
        public string CustomerAddress { get => _CustomerAddress; set => _CustomerAddress = value; }
       
         public string[] Orders = new string[50];
 public string[] _Orders{
 
    get=> _Orders;
   
    set =>_Orders = value;
    
       }
     public Customer() 
    { 
        Console.WriteLine("Default Constructor of customer class"); 
    } 
        public Customer(string _CustomerName,int _CustomerPhoneNo ,string _CustomerAddress)
        {
            _CustomerId = _CustomerId++;
            this._CustomerPhoneNo=_CustomerPhoneNo;
            this._CustomerName=_CustomerName;
            this._CustomerAddress=_CustomerAddress;

        }

    }
}
