using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlog.Models
{
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now;
            this.tags = new HashSet<Tag>();
        }
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        
        public DateTime Date { get; set; }
        
        public ApplicationUser Author { get; set; }

        private ICollection<Tag> tags;


        public virtual ICollection<Tag> Tags { get; set; }

      
    }
}