
using data_graph_designer.Interfaces;
using data_graph_designer.Repository;
using data_graph_designer.Services;

namespace data_graph_designer.Service{
    public class EndpointService: ServiceBase<Models.Endpoint>{

        public EndpointService(EndpointRepository repository):base(repository){
        }

        public async Task<List<Models.Endpoint>> getEndpointsByType(int type)
        {
            var repository = (EndpointRepository)this._repository;
            return await repository.getEndpointsByType(type);
        }
    }
}