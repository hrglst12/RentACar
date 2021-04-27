using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProjectAPI.Core.Entities
{
    public partial class Rents
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? CarId { get; set; }
        public int? FirmaId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
