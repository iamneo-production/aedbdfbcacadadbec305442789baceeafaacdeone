using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotnetmicroservicetwo.Models;

public class DeliveryDbContext : DbContext
{

    public DeliveryDbContext(DbContextOptions<DeliveryDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Delivery> Deliverys { get; set; }
}
