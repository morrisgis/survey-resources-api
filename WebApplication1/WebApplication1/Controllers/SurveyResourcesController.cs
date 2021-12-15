using System;
using System.Collections.Generic;
using System.Data.Common;
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
    public class SurveyResourcesController : ControllerBase
    {
        private readonly SurveyResourcesContext _context;

        public SurveyResourcesController(SurveyResourcesContext context)
        {
            _context = context;
        }

        // GET: api/SurveyResources
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SurveyResource>>> GetSurveyResources()
        {
            return await _context.SurveyResources.ToListAsync();
        }

        // GET: api/SurveyResources/5
        [HttpGet("PresentName")]
        public async Task<ActionResult<SurveyDocument>> GetSome(string PresentName)
        {
            var presentName = await _context.SurveyResources
                 .Where(a => a.PresentName == PresentName)
                 .ToListAsync();

            if (presentName == null)
            {
                return NotFound();
            }
            return Ok(presentName);
        }

        [HttpGet("SurveyResources")]
        public async Task<IActionResult> GetSurveyResources( int page = 1, int pagesize = 25, string fieldlist = "*", string filters = "", string qsearch = "", string sorts = "")
        {
            int offset = (page - 1) * pagesize;

            if (fieldlist != "*")
            {
                fieldlist = fieldlist.Replace("|", ",");
            }

            string orderBy = "";
            if (sorts == "")
            {
                orderBy = orderBy + "SurveyDate DESC";
            }
            else
            {
                orderBy = orderBy + sorts.Replace("|", ",").Replace("(", "").Replace(")", "");
            }

            string whereClause = "";
            if (filters == "")
            {
                whereClause = "";
            }
            else
            {
                whereClause = "WHERE " + filters.Replace(" eq ", " = ").Replace(" gt ", " > ").Replace(" gte ", " >= ").Replace(" lt ", " < ").Replace(" lte ", " <= ").Replace(" neq ", " != ").Replace("''", "'");
            }
            if (qsearch != "")
            {
                string[] strArr = null;
                string qwhere = "";
                int wordcount = 0;
                qsearch = qsearch.Replace(",", " ").Replace("-", "%").Replace("_", "%");
                char[] splitchar = { ' ' };
                strArr = qsearch.Split(splitchar);
                for (wordcount = 0; wordcount <= strArr.Length - 1; wordcount++)
                {
                    if (wordcount == 0)
                    {
                        qwhere = "QSearch LIKE '%" + strArr[wordcount].ToString() + "%'";
                    }
                    else
                    {
                        qwhere += " AND QSearch LIKE '%" + strArr[wordcount].ToString() + "%'";
                    }

                }

                if (whereClause == "")
                {
                    whereClause = "WHERE " + qwhere;
                }
                else
                {
                    whereClause += qwhere;
                }

            }

            string query = "SELECT * FROM dbo.SurveyResources " + whereClause + " ORDER BY " + orderBy + " OFFSET " + offset.ToString() + " ROWS FETCH NEXT " + pagesize.ToString() + " ROWS ONLY";
            Console.Write(query);
            var tmList = await _context.SurveyResources
                .FromSqlRaw(query)
                .AsNoTracking()
                .ToListAsync();

            if (tmList == null)
            {
                return NotFound();
            }

            int count = 0;
            double pageTot = 1;

            if (page == 1)
            {
                query = "SELECT Count(*) FROM dbo.SurveyResources " + whereClause + "";

                var conn = _context.Database.GetDbConnection();
                try
                {
                    await conn.OpenAsync();
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = query;
                        DbDataReader reader = await command.ExecuteReaderAsync();

                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                count = reader.GetInt32(0);

                            }
                        }
                        reader.Dispose();
                    }
                }
                finally
                {
                    conn.Close();
                }



                pageTot = Convert.ToInt16(Math.Ceiling((double)count / pagesize));

                return Ok(new { res = tmList, total = count, page, pagetot = pageTot, pagesize = pagesize });
            }
            else
            {
                return Ok(new { res = tmList, page });
            }
        }

        // PUT: api/SurveyResources/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSurveyResource(int id, SurveyResource surveyResource)
        {
            if (id != surveyResource.SurveyId)
            {
                return BadRequest();
            }

            _context.Entry(surveyResource).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurveyResourceExists(id))
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

        // POST: api/SurveyResources
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SurveyResource>> PostSurveyResource(SurveyResource surveyResource)
        {
            _context.SurveyResources.Add(surveyResource);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SurveyResourceExists(surveyResource.SurveyId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSurveyResource", new { id = surveyResource.SurveyId }, surveyResource);
        }

        // DELETE: api/SurveyResources/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSurveyResource(int id)
        //{
        //    var surveyResource = await _context.SurveyResources.FindAsync(id);
        //    if (surveyResource == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.SurveyResources.Remove(surveyResource);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool SurveyResourceExists(int id)
        {
            return _context.SurveyResources.Any(e => e.SurveyId == id);
        }
    }
}
