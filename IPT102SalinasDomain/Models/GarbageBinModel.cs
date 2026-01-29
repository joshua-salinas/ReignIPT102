using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace IPT102SalinasDomain.Models
{
    public class GarbageBinModel
    {
        public string Id { get; set; } = string.Empty;

        public string? BinCode { get; set; }
        public string? Location { get; set; }
        public decimal? Capacity { get; set; }
        public string? Status { get; set; }

        // Optional if not used in SQL yet
        public string? Name { get; set; }
        public string? Type { get; set; }

        public bool IsFull { get; set; }
        public DateTime? LastEmptied { get; set; }
        public DateTime? LastUpdated { get; set; }
    }

}
