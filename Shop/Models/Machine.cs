using System.Collections.Generic;

namespace Shop.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineers = new HashSet<MachineEngineer>();
    }

    public int MachineId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<MachineEngineer> Engineers { get; set; }
  }
}