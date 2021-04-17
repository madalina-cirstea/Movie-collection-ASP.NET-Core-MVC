using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models.ViewModels
{
    public class MovieReviewsViewModel
    {
        public Movie Movie { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public Review NewReview { get; set; }
    }
}
