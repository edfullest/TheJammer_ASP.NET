using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TheJammer.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CommentDate { get; set; }

        // Navigation properties, they are virtual so that they can take advantage of the Entity
        // Framework feature called Lazy Loading
        public int? UserID { get; set; }
        public virtual User User { get; set; }

    }
}