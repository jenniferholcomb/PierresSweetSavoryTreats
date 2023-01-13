using Microsoft.AspNetCore.Identity;

namespace PierresBakery.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string Name { get; set; }
  }
}