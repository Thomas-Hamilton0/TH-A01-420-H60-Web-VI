using System;
using System.Collections.Generic;

namespace TH_H60_A01.Models;

public partial class ProductCategory
{
    public int CategoryId { get; set; }

    public string ProdCat { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
