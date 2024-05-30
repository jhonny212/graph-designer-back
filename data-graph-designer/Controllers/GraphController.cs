using data_graph_designer.Models;
using data_graph_designer.Response;
using data_graph_designer.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace data_graph_designer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphController : ControllerBase
    {
        private readonly GraphTypeService service;
        public GraphController(GraphTypeService service)
        {
            this.service = service;
        }

        // GET: api/<GraphController>
        [HttpGet]
        public async Task<ActionResult<PaginatedResponse<TypeGraph>>> Get(int page, int pageSize)
        {
            var result = await this.service.GetAllPaginated(page, pageSize);
            return Ok(result);
        }
    }
}
