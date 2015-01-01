
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using Entity;

[Table("OrderItem")]
public partial class OrderItem
{
    public int OrderID { get; set; }

    public int ProductID { get; set; }

    [Key]
    public int OrderItemKey { get; set; }

    public virtual Order Order { get; set; }

    public virtual Product Product { get; set; }
}