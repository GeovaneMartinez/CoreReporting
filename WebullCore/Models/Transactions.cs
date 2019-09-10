using System;
using System.Collections.Generic;

namespace WebullCore.Models
{
    public partial class Transactions
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public decimal? StartPrice { get; set; }
        public int Shares { get; set; }
        public string EndDate { get; set; }
        public decimal? EndPrice { get; set; }
        public string Symbol { get; set; }
    }
}
