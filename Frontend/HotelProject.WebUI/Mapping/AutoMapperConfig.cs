using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.About;
using HotelProject.WebUI.Dtos.Booking;
using HotelProject.WebUI.Dtos.Contact;
using HotelProject.WebUI.Dtos.Guest;
using HotelProject.WebUI.Dtos.Login;
using HotelProject.WebUI.Dtos.Register;
using HotelProject.WebUI.Dtos.Room;
using HotelProject.WebUI.Dtos.Service;
using HotelProject.WebUI.Dtos.Staff;
using HotelProject.WebUI.Dtos.Subscribe;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<LoginUserDto, AppUser>().ReverseMap();
            
            CreateMap<CreateUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubsDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();

            CreateMap<ApprovedResDto, Booking>().ReverseMap();
            
            CreateMap<CreateContactDto, Contact>().ReverseMap();

            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            CreateMap<ResultRoomDto, Room>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();
            CreateMap<ResultGuestDto, Guest>().ReverseMap();
        }
    }
}
