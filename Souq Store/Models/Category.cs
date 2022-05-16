﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Souq_Store.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Discription { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
