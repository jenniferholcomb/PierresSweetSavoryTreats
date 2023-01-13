using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresBakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public <FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}