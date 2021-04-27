using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProjectAPI.Core.Entities
{
    public partial class Firms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
