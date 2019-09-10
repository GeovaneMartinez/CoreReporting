using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebullCore.Models
{
    public class TradeResults
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal? StartPrice { get; set; }
        public decimal? EndPrice { get; set; }
        public int Shares { get; set; }
        public decimal? Percentage { get; set; }
        public decimal ProfitLoss { get; set; }
    }
}
