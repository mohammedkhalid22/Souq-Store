using System;
using System.Collections.Generic;

#nullable disable

namespace Souq_Store.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Discription { get; set; }
    }
}
