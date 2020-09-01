using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamChallenge.Data;

namespace TeamChallange.Models
{
    public class Like
    {
        public Post LikedPost { get; set; }
        public SocialMediaUser Liker { get; set; }

    }
}
