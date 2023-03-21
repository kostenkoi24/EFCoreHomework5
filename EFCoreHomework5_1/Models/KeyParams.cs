using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFCoreHomework5_1.Models
{
    public partial class KeyParams
    {
        public Guid Id { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? KeyWordsId { get; set; }

        public virtual Words KeyWords { get; set; }
        public virtual Products Product { get; set; }
    }
}
