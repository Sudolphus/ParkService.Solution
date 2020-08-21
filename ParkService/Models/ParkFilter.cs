namespace ParkService.Models
{
  public class ParkFilter
  {
    public string Name { get; set; }
    public string State { get; set; }

    public ParkFilter()
    {
      this.Name = "";
      this.State = "";
    }

    public ParkFilter(string name, string state)
    {
      this.Name = name;
      this.State = state;
    }
  }
}