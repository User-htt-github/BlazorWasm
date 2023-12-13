using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Blazor.API.Entities
{
    public class User : IdentityUser<Guid>
    {
        [MaxLength(250)]
        [Required]
        public String FirstName { get; set; }
        [MaxLength(250)]
        [Required]
        public String LastName { get; set; }
    }
}
