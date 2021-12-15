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
    public class SurveyDocumentsController : ControllerBase
    {
        private readonly SurveyResourcesContext _context;

        public SurveyDocumentsController(SurveyResourcesContext context)
        {
            _context = context;
        }

        // GET: api/SurveyDocuments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SurveyDocument>>> GetSurveyDocuments()
        {
            return await _context.SurveyDocuments.ToListAsync();
        }

        // GET Test
        [HttpGet("File_Extension")]
        public async Task<ActionResult<SurveyDocument>> GetSome(string FileExtension)
        {
            var fileExtension = await _context.SurveyDocuments
                 .Where(a => a.FileExtension == FileExtension)
                 .ToListAsync();

            if (fileExtension == null)
            {
                return NotFound();
            }
            return Ok(fileExtension);
        }

        // GET: api/SurveyDocuments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SurveyDocument>> GetSurveyDocument(int id)
        {
            var surveyDocument = await _context.SurveyDocuments.FindAsync(id);

            if (surveyDocument == null)
            {
                return NotFound();
            }

            return surveyDocument;
        }

        // PUT: api/SurveyDocuments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSurveyDocument(int id, SurveyDocument surveyDocument)
        {
            if (id != surveyDocument.DocumentId)
            {
                return BadRequest();
            }

            _context.Entry(surveyDocument).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurveyDocumentExists(id))
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

        // POST: api/SurveyDocuments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SurveyDocument>> PostSurveyDocument(SurveyDocument surveyDocument)
        {
            _context.SurveyDocuments.Add(surveyDocument);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SurveyDocumentExists(surveyDocument.DocumentId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSurveyDocument", new { id = surveyDocument.DocumentId }, surveyDocument);
        }

        // DELETE: api/SurveyDocuments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSurveyDocument(int id)
        {
            var surveyDocument = await _context.SurveyDocuments.FindAsync(id);
            if (surveyDocument == null)
            {
                return NotFound();
            }

            _context.SurveyDocuments.Remove(surveyDocument);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SurveyDocumentExists(int id)
        {
            return _context.SurveyDocuments.Any(e => e.DocumentId == id);
        }
    }
}
