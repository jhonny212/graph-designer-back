using data_graph_designer.Models;
using data_graph_designer.Response;
using data_graph_designer.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace data_graph_designer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeOperationController : ControllerBase
    {
        private readonly TypeOperationService service;
        public TypeOperationController(TypeOperationService service)
        {
            this.service = service;
        }

        // GET: api/<TypeOperationController>
        [HttpGet]
        public async Task<ActionResult<PaginatedResponse<TypeOperation>>> Get(int page=1, int pageSize=100)
        {
            var result = await this.service.GetAllPaginated(page, pageSize);
            return Ok(result);
        }
    }
}
