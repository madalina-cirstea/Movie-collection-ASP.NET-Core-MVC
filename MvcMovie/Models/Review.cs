using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        [Display(Name = "Review date")]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }

        public int MovieId { get; set; }
    }
}
