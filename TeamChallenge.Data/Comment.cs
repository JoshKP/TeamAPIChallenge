using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TeamChallenge.Data;

namespace TeamChallange.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public SocialMediaUser Author { get; set; }
        public Post CommentPost { get; set; }

    }
}
