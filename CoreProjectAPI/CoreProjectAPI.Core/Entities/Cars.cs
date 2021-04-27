using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProjectAPI.Core.Entities
{
    public partial class Cars
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stock { get; set; }
        public decimal? Price { get; set; }
        public int? FirmaId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
