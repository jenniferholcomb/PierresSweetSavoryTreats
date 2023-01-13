using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresBakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Description { get; set; }
    public <FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}