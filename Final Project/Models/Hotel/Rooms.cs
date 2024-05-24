
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Final_Project.Models.Hotel;

public class Rooms
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public int HotelId { get; set; }
    public double PricePerDay { get; set; }
    public bool isAvailable { get; set; }
    public int maxGuests { get; set; }
    public int roomTypeId { get; set; }
    [ForeignKey("HotelId")]
    public Hotels? Hotel { get; set; }
    [ForeignKey("roomTypeId")]
    public RoomType? RoomType { get; set; }


}
