using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PokeballReview.Models
{
    public class Reviews
    {
        [Key]

        public int ReviewID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string Etc { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Categories Category { get; set; }
    }
}