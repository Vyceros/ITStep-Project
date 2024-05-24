//Map data from Models to DTO
using Final_Project.Models.Hotel;
using AutoMapper;

namespace Final_Project.Data
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Rooms, RoomDTO>().ReverseMap();
            CreateMap<Booking, BookingDTO>().ReverseMap();
        }
    }
}