using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace homeworkASP.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Client { get; set; }
        public DateTime Date { get; set; }
       public string  URL { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength:100)]

        public string Desc { get; set; }

        public List<PortfolioImage> PortfolioImages { get; set; }

    }
}
