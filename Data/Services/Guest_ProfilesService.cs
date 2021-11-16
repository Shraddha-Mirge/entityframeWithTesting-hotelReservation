using hotelRes_V_03.Data.Models;
using hotelRes_V_03.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace hotelRes_V_03.Data.Services
{
    public class Guest_ProfilesService
    {
        private AppDbContext _context;
        public Guest_ProfilesService(AppDbContext context)
        {
            _context = context;
        }
        //Post method
        public void AddGuest_Profile(Guest_ProfileVM Guest_Profile)
        {
            var _Guest_Profile = new Guest_Profile()
            {   
                Guest_name = Guest_Profile.Guest_name,
                Guest_contact = Guest_Profile.Guest_contact,
                Guest_email = Guest_Profile.Guest_email
            };
            _context.Guest_Profiles.Add(_Guest_Profile);
            _context.SaveChanges();
        }
        //get method
        public List<Guest_Profile> GetAllGuest_Profile(string v, string v1) => _context.Guest_Profiles.ToList();
        public Guest_Profile GetGuest_ProfileById(int Guest_ProfileId) => _context.Guest_Profiles.FirstOrDefault(n => n.Id == Guest_ProfileId);
        //put method
        public Guest_Profile UpdateGuest_ProfileById(int Guest_ProfileId, Guest_ProfileVM Guest_Profile)
        {
            var _Guest_Profile = _context.Guest_Profiles.FirstOrDefault(n => n.Id == Guest_ProfileId);
            if (_Guest_Profile != null)
            {
                _Guest_Profile.Guest_name = Guest_Profile.Guest_name;
                _Guest_Profile.Guest_contact = Guest_Profile.Guest_contact;
                _Guest_Profile.Guest_email = Guest_Profile.Guest_email;

                _context.SaveChanges();
            }
            return _Guest_Profile;
        }
        //delete method
        public void DeleteGuest_ProfileById(int Guest_ProfileId)
        {
            var _Guest_Profile = _context.Guest_Profiles.FirstOrDefault(n => n.Id == Guest_ProfileId);
            if (_Guest_Profile != null)
            {
                _context.Guest_Profiles.Remove(_Guest_Profile);
                _context.SaveChanges();
            }
        }





    }
}
