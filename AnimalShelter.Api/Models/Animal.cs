using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AnimalShelter.Api.Models
{
  public class Animal
  {
    /// <summary>
    /// ID of current animal
    /// </summary>
    public int AnimalId { get; set; }

    /// <summary>
    /// Name of the animal
    /// </summary>
    [Required, StringLength(40, MinimumLength = 1)]
    public string Name { get; set; }

    /// <summary>
    /// Species of the animal
    /// </summary>
    [Required, StringLength(40, MinimumLength = 1)]
    public string Species { get; set; }

    /// <summary>
    /// Breed of the animal
    /// </summary>
    [Required, StringLength(40, MinimumLength = 1)]
    public string Breed { get; set; }

    /// <summary>
    /// A description of the animal
    /// </summary>
    [Required]
    public string Description { get; set; }

    [Required]
    [EnumDataType(typeof(Status))]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; }
  }

  // This would fit better somewhere else instead of just in 
  // AnimalShelter.Api.Models.Status, but I'm not sure where.
  /// <summary>
  /// Status of the animal, may be a 0-th index value in the Enum array
  /// </summary>
  public enum Status
  {
    Available,
    Adopted
  }
}