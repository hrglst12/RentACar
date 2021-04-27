using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProjectAPI.Core.Entities
{
    public partial class Renters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
