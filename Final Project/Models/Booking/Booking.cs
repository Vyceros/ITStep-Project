
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project;

public class Booking
{
    [Key]
    public int Id { get; set; }
    public string? customerName { get; set; }
    public string? phoneNumber { get; set; }
    public int RoomId { get; set; }
    public DateTime checkInTime { get; set; }
    public DateTime checkOutTime { get; set; }
    public double totalPrice { get; set; } = 0;
    [ForeignKey("RoomId")]
    public Rooms? Room { get; set; }

}
