using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeworkASP.Models
{
    public class Potrfolio_category
    {
        public int Id { get; set; }


        public string Category { get; set; }

        public int PortfolioId { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
