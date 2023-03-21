using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFCoreHomework5_1.Models
{
    public partial class Products
    {
        public Products()
        {
            Carts = new HashSet<Carts>();
            KeyParams = new HashSet<KeyParams>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double ActionPrice { get; set; }
        public string Description { get; set; }
        public string DescriptionField1 { get; set; }
        public string DescriptionField2 { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<Carts> Carts { get; set; }
        public virtual ICollection<KeyParams> KeyParams { get; set; }
    }
}
