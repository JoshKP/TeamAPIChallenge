﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamChallange.Models;

namespace TeamChallenge.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
                
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public Guid Author { get; set; }

    }
}
