using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresBakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Display(Name="Treat Name")]
    public string Name { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}