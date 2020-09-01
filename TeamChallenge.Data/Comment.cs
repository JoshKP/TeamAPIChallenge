using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TeamChallenge.Data;

namespace TeamChallange.Models
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(PostComment))]
        public int PostID { get; set; }
        public virtual Post PostComment { get; set; }

        [Required]
        public string Text { get; set; }

        [ForeignKey(nameof(Author))]
        public Guid UserID { get; set; }
        public virtual SocialMediaUser Author { get; set; }
    }
}
