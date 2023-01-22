using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresBakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }

    [Required(ErrorMessage="Name must be added for new Treat.")]
    [StringLength(80,ErrorMessage="No more than 60 characters")]
    [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Name must only include characters.")]
    [Display(Name="Treat Name")]
    public string Name { get; set; }
    
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}