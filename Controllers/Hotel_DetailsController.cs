using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using hotelRes_V_03.Data;
using hotelRes_V_03.Data.Models;

namespace hotelRes_V_03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hotel_DetailsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public Hotel_DetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Hotel_Details
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel_Detail>>> Gethotel_Details()
        {
            return await _context.hotel_Details.ToListAsync();
        }

        // GET: api/Hotel_Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel_Detail>> GetHotel_Detail(int id)
        {
            var hotel_Detail = await _context.hotel_Details.FindAsync(id);

            if (hotel_Detail == null)
            {
                return NotFound();
            }

            return hotel_Detail;
        }

        // PUT: api/Hotel_Details/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel_Detail(int id, Hotel_Detail hotel_Detail)
        {
            if (id != hotel_Detail.Id)
            {
                return BadRequest();
            }

            _context.Entry(hotel_Detail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Hotel_DetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Hotel_Details
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hotel_Detail>> PostHotel_Detail(Hotel_Detail hotel_Detail)
        {
            _context.hotel_Details.Add(hotel_Detail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotel_Detail", new { id = hotel_Detail.Id }, hotel_Detail);
        }

        // DELETE: api/Hotel_Details/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel_Detail(int id)
        {
            var hotel_Detail = await _context.hotel_Details.FindAsync(id);
            if (hotel_Detail == null)
            {
                return NotFound();
            }

            _context.hotel_Details.Remove(hotel_Detail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Hotel_DetailExists(int id)
        {
            return _context.hotel_Details.Any(e => e.Id == id);
        }
    }
}
