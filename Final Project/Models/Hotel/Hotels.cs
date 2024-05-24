using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Final_Project.Models.Hotel;

public class Hotels
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public List<Rooms>? Rooms { get; set; }
}
