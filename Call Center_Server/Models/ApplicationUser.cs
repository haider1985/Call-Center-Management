using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;

namespace Call_Center_Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }=string.Empty;

        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string MidName { get; set; }=string.Empty;

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "User Image")]
        public string? ImageUrl { get; set; }
    }
}
