using System.ComponentModel.DataAnnotations;

namespace UmbracoAmbience.Web.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter your email address")]
        [EmailAddress(ErrorMessage ="Please enter valid email address")]
        public string Email { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage ="Your message must be less that 500 characters")]
        public string Message { get; set; }
    }
}