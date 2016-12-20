using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace MvcBlog.Models
{
    public class Tag
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public Tag()
        {
            Posts = new List<Post>();
        }

        public virtual ICollection<Post> Posts { get; set; }
        


    }
}