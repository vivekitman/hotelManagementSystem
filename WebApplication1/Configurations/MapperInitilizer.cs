using AutoMapper;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Configurations
{
    public class MapperInitilizer :Profile 
    {
        public MapperInitilizer()
        {
                  
        
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();

            CreateMap<Hotelcs, HotelDTO>().ReverseMap();
             

            CreateMap<Hotelcs, CreateHotelDTO>().ReverseMap();
            CreateMap<ApiUser, UserDTO>().ReverseMap();

        }



    }
}

