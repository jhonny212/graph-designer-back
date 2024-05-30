using data_graph_designer.Models;
using data_graph_designer.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace data_graph_designer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndpointController : ControllerBase
    {
        private readonly EndpointService endpointService;
        

        public EndpointController(EndpointService endpointService, EndpointTypeService endpointTypeService)
        {
            this.endpointService = endpointService;
        }


        // GET: api/<EndpointController>
        [HttpGet]
        public async Task<ActionResult<Models.Endpoint>> GetAllEndpoints(int page, int pageSize)
        {
            var result = await this.endpointService.GetAllPaginated(page, pageSize);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // GET: api/EndpointController/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Endpoint>> GetAllEndpoints(int id)
        {
            
            var result = await endpointService.getEndpointsByType(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
