using System;
using System.Collections.Generic;

#nullable disable

namespace Souq_Store.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Disciption { get; set; }
        public decimal? Prize { get; set; }
        public int? CatId { get; set; }
        public string Photo { get; set; }

        public virtual Category Cat { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
