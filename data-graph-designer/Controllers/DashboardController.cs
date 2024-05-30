using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using data_graph_designer;
using data_graph_designer.Models;
using data_graph_designer.Response;
using data_graph_designer.Service;
using Microsoft.AspNetCore.Http.HttpResults;

namespace data_graph_designer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {

        private readonly DashboardService dashboardService;
        public DashboardController(DashboardService dashboardService)
        {
            this.dashboardService = dashboardService;
        }

        // GET: api/Dashboard
        [HttpGet]
        public async Task<ActionResult<PaginatedResponse<Dashboard>>> GetDashboards(int page, int pageSize)
        {
            IEnumerable<Dashboard> data = 
                await dashboardService.GetAllPaginated(page, pageSize);
            if (data == null)
            {
                return NotFound();
            }
            return new PaginatedResponse<Dashboard>() { Data = data, Page = page, PageSize = pageSize };
        }

        // GET: api/Dashboard/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dashboard>> GetDashboard(int id)
        {
            var result = await dashboardService.GetById(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PUT: api/Dashboard/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Dashboard>>  PutDashboard(int id, Dashboard dashboard)
        {
            if (id != dashboard.Id)
            {
                return BadRequest();
            }
            return Ok(await dashboardService.Update(dashboard, id));
        }

        // POST: api/Dashboard
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dashboard>> PostDashboard(Dashboard dashboard)
        {
            var result = await dashboardService.Save(dashboard);
            return Created("GetDashboard", result);
        }

        // DELETE: api/Dashboard/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteDashboard(int id)
        {
            var result = await dashboardService.DeleteById(id);
            return Ok(result);
        }
    }
}
