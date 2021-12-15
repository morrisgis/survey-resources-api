using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyParcelsLinksController : ControllerBase
    {
        private readonly SurveyResourcesContext _context;

        public SurveyParcelsLinksController(SurveyResourcesContext context)
        {
            _context = context;
        }

        // GET: api/SurveyParcelsLinks
        [HttpGet("Block")]
        public async Task<ActionResult<IEnumerable<SurveyParcelsLink>>> GetSurveyParcelsLinks(string Block)
        {
            var block = await _context.SurveyParcelsLinks
                .Where(a => a.Block == Block)
                .ToListAsync();

            if (block == null)
            {
                return NotFound();
            }
            return Ok(block);
        }

        // GET: api/SurveyParcelsLinks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SurveyParcelsLink>> GetSurveyParcelsLink(int id)
        {
            var surveyParcelsLink = await _context.SurveyParcelsLinks.FindAsync(id);

            if (surveyParcelsLink == null)
            {
                return NotFound();
            }

            return surveyParcelsLink;
        }

        // PUT: api/SurveyParcelsLinks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSurveyParcelsLink(int id, SurveyParcelsLink surveyParcelsLink)
        {
            if (id != surveyParcelsLink.Spid)
            {
                return BadRequest();
            }

            _context.Entry(surveyParcelsLink).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurveyParcelsLinkExists(id))
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

        // POST: api/SurveyParcelsLinks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SurveyParcelsLink>> PostSurveyParcelsLink(SurveyParcelsLink surveyParcelsLink)
        {
            _context.SurveyParcelsLinks.Add(surveyParcelsLink);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSurveyParcelsLink", new { id = surveyParcelsLink.Spid }, surveyParcelsLink);
        }

        // DELETE: api/SurveyParcelsLinks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSurveyParcelsLink(int id)
        {
            var surveyParcelsLink = await _context.SurveyParcelsLinks.FindAsync(id);
            if (surveyParcelsLink == null)
            {
                return NotFound();
            }

            _context.SurveyParcelsLinks.Remove(surveyParcelsLink);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SurveyParcelsLinkExists(int id)
        {
            return _context.SurveyParcelsLinks.Any(e => e.Spid == id);
        }
    }
}
