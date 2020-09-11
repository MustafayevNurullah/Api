using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public int? Show { get; set; }
        [NotMapped]
        public List<Comment> CommentList { get; set; }
        

        public string Admin { get; set; }


    }
}
