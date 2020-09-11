using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [ForeignKey("PostId")]
        public int PostId { get; set; }
    }
}
