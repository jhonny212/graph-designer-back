using data_graph_designer.Models;
using data_graph_designer.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace data_graph_designer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndpointDetailController : ControllerBase
    {
        private readonly EndpointDetailsService service;
        public EndpointDetailController(EndpointDetailsService service)
        {
            this.service = service;
        }

        // GET api/<EndpointDetailController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EndpointDetail>> Get(int id)
        {
            var result = await this.service.GetAllEndpointDetailsByEndpoint(id);
            return Ok(result);
        }

        [HttpGet("example-data/{id}")]
        public async Task<ActionResult<object>> GetExampleData(int id)
        {
            var result = await service.GetDataFromDatastore(id,5);
            return Ok(new {data = result });
        }
    }
}
