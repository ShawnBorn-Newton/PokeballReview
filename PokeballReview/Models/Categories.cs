using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PokeballReview.Models
{
    public class Categories
    {
        [Key]
        int CategoryID { get; set; }
        public string CategoryName { get; set; }

        ICollection<Reviews> Reviews { get; set; }
    }
}