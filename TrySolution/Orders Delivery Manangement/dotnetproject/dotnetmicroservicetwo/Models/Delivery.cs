using System;
using System.Collections.Generic;

namespace dotnetmicroservicetwo.Models;
public class Delivery
{
    public int DeliveryID { get; set; }
    public string OrderID { get; set; }
    public string DriverID { get; set; }
    public DateTime DeliveryDate { get; set; }
    public string DeliveryStatus { get; set; }
    public string DeliveryLocation { get; set; }


}
