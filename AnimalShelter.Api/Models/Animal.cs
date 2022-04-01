namespace AnimalShelter.Api.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public string Breed { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
  }

  public enum Status
  {
    Available,
    Adopted
  }
}