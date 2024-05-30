using data_graph_designer.Models;
using data_graph_designer.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace data_graph_designer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DimensionController : ControllerBase
    {
        private readonly DimensionService service;

        public DimensionController(DimensionService service)
        {
            this.service = service;
        }

       
        // GET: api/<DimensionController>/row
        [HttpGet("row")]
        public async Task<ActionResult<DashboardColumn>> GetRows()
        {
            var result = await service.GetRows();
            return Ok(result);
        }

        // GET api/<DimensionController>/column
        [HttpGet("column")]
        public async Task<ActionResult<Height>> GetColumns()
        {
            var result = await service.GetDashboardColumns();
            return Ok(result);
        }
        
    }
}
