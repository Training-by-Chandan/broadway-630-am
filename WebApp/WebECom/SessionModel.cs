using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebECom
{
    //we have to store List<SessionModel> in session as value for the key 'cart'
    public class SessionModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
