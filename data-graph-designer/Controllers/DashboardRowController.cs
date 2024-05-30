using data_graph_designer.Models;
using data_graph_designer.Response;
using data_graph_designer.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace data_graph_designer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardRowController : ControllerBase
    {
        private readonly DashboardRowService service;
        public DashboardRowController(DashboardRowService service){
            this.service = service;
        }
        // GET: api/<DashboardRowController>
        [HttpGet("{id}")]
        public async Task<ActionResult<PaginatedResponse<DashboardRow>>> Get(int page, int pageSize, int id)
        {
            var data = await this.service.GetDashboardRowByDashboard(page,pageSize,id);
            if(data == null){
                return NotFound();
            }
            return new PaginatedResponse<DashboardRow>(){
                Data = data,
                Page = page,
                PageSize = pageSize
            };
        }

        // POST api/<DashboardRowController>
        [HttpPost]
        public async Task<ActionResult<DashboardRow>> Post(DashboardRow dashboardRow)
        {
            var result = await service.Save(dashboardRow);
            return Created("",result);
        }
    }
}
