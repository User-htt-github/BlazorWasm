using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Blazor.API.Entities
{
    public class Role : IdentityRole<Guid>
    {
        [MaxLength(250)]
        [Required]
        public String Description { get; set; }
    }
}
