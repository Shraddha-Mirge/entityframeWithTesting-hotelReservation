using hotelRes_V_03.Data.Models;
using hotelRes_V_03.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace hotelRes_V_03.Data.Services
{
    public class Hotel_DetailsService
    {
        private AppDbContext _context;
        public Hotel_DetailsService(AppDbContext context)
        {
            _context = context;
        }
        public void AddHotel_Detail(Hotel_DetailVM hotel_Detail)
        {
            var _Hotel_Detail = new Hotel_Detail()
            {
                Hotel_Name = hotel_Detail.Hotel_Name,
                Description = hotel_Detail.Description,
                Address = hotel_Detail.Address,
                city = hotel_Detail.city,
                state = hotel_Detail.state,
                pin_code = hotel_Detail.pin_code,
                contact_number = hotel_Detail.contact_number,
                email = hotel_Detail.email




            };
            _context.hotel_Details.Add(_Hotel_Detail);
            _context.SaveChanges();
        }

        public List<Hotel_Detail> GetAllHotel_Detail() => _context.hotel_Details.ToList();
        public Hotel_Detail GetHotel_DetailById(int Hotel_DetailId) => _context.hotel_Details.FirstOrDefault(n => n.Id == Hotel_DetailId);

        public Hotel_Detail UpdateHotel_DetailById(int Hotel_DetailId, Hotel_DetailVM hotel_Detail)
        {
            var _Hotel_Detail = _context.hotel_Details.FirstOrDefault(n => n.Id == Hotel_DetailId);
            if (_Hotel_Detail != null)
            {
                _Hotel_Detail.Hotel_Name = hotel_Detail.Hotel_Name;
                _Hotel_Detail.Description = hotel_Detail.Description;
                _Hotel_Detail.Address = hotel_Detail.Address;
                _Hotel_Detail.city = hotel_Detail.city;
                _Hotel_Detail.state = hotel_Detail.state;
                _Hotel_Detail.pin_code = hotel_Detail.pin_code;
                _Hotel_Detail.contact_number = hotel_Detail.contact_number;
                _Hotel_Detail.email = hotel_Detail.email;

                _context.SaveChanges();
            }
            return _Hotel_Detail;
        }

        public void DeleteHotel_DetailById(int Hotel_DetailId)
        {
            var _Hotel_Detail = _context.hotel_Details.FirstOrDefault(n => n.Id == Hotel_DetailId);
            if (_Hotel_Detail != null)
            {
                _context.hotel_Details.Remove(_Hotel_Detail);
                _context.SaveChanges();
            }
        }
    }
}
