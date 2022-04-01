using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AnimalShelter.Api.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required, StringLength(40, MinimumLength = 1)]
    public string Name { get; set; }
    [Required, StringLength(40, MinimumLength = 1)]
    public string Species { get; set; }
    [Required, StringLength(40, MinimumLength = 1)]
    public string Breed { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    [EnumDataType(typeof(Status))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; }
  }

  // This would fit better somewhere else instead of just in 
  // AnimalShelter.Api.Models.Status, but I'm not sure where.
  public enum Status
  {
    Available,
    Adopted
  }
}