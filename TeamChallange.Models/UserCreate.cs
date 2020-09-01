using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamChallange.Models
{
    public class UserCreate
    {
        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 2 characters.")]
        public string Name { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 2 characters.")]
        public string Email { get; set; }
    }
}
