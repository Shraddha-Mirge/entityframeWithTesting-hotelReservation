using hotelRes_V_03.Data.Services;
using hotelRes_V_03.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hotelRes_V_03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Guest_ProfilesController : ControllerBase
    {
        public Guest_ProfilesService _Guest_ProfilesService;
        public Guest_ProfilesController(Guest_ProfilesService guest_ProfilesService)
        {
            _Guest_ProfilesService = guest_ProfilesService;
        }


        //get
       
        [HttpGet("get-all-Guest_Profile")]
        public IActionResult GetAllGuest_Profile()
        {
            var allGuest_Profile = _Guest_ProfilesService.GetAllGuest_Profile();
            return Ok(allGuest_Profile);
        }


        //get id
        [HttpGet("get-Guest_profile-by-id/{id}")]
        public IActionResult GetGuest_ProfileById(int id)
        {
            var Guest_Profile = _Guest_ProfilesService.GetGuest_ProfileById(id);
            return Ok(Guest_Profile);
        }


        //post
        [HttpPost("add-book")]
        public IActionResult AddGuest_Profile([FromBody] Guest_ProfileVM Guest_Profile)
        {
            _Guest_ProfilesService.AddGuest_Profile(Guest_Profile);
            return Ok();
        }

        //put
        [HttpPut("Update-guest_profile-by-id/{id}")]
        public IActionResult UpdateGuest_ProfileById(int id, [FromBody] Guest_ProfileVM Guest_Profile)
        {
            var updateGuest_Profile = _Guest_ProfilesService.UpdateGuest_ProfileById(id, Guest_Profile);
            return Ok(updateGuest_Profile);
        }

        //Delete

        [HttpDelete("Delete-Guest_profile-by-id/{id}")]
        public IActionResult DeleteGuest_ProfileById(int id)
        {
            _Guest_ProfilesService.DeleteGuest_ProfileById(id);
            return Ok();
        }



    }
}
