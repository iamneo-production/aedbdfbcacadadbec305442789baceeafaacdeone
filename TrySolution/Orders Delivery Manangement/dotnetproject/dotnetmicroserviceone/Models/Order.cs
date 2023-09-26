using System;
using System.Collections.Generic;

namespace dotnetmicroserviceone.Models;
public class Order
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public string ProductID { get; set; }
    public DateTime OrderDate { get; set; }
    public string OrderStatus { get; set; }
    public string DeliveryAddress { get; set; }

}
