using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamChallange.Models
{
    public class PostCreate
    {
        public SocialMediaUser User { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
