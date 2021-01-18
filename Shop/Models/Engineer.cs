using System.Collections.Generic;

namespace Shop.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<MachineEngineer>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }

    public ICollection<MachineEngineer> Machines { get; }
  }

}