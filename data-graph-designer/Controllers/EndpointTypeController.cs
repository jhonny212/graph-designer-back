using data_graph_designer.Service;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace data_graph_designer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndpointTypeController : ControllerBase
    {
        private readonly EndpointTypeService endpointTypeService;

        public EndpointTypeController(EndpointTypeService endpointTypeService)
        {
            this.endpointTypeService = endpointTypeService;
        }

        // GET: api/<EndpointTypeController>
        [HttpGet]
        public async Task<ActionResult<Models.Endpoint>> Get(int page, int pageSize)
        {
            var result = await this.endpointTypeService.GetAllPaginated(page, pageSize);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
