using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresBakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }

    [Required(ErrorMessage="Description must be added for new Flavor.")]
    [StringLength(60,ErrorMessage="No more than 60 characters")]
    [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Description must only include characters.")]
    public string Description { get; set; }
    
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}