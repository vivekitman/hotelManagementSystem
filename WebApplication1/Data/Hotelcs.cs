using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    public class Hotelcs
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        public string City { get; set; }
        public string Region { get; set; }
        
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
         public Country CountryName { get; set; }
      

    }
}
