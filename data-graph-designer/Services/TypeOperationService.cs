using data_graph_designer.Interfaces;
using data_graph_designer.Models;
using data_graph_designer.Repository;
using data_graph_designer.Services;

namespace data_graph_designer.Service{

    public class TypeOperationService : ServiceBase<TypeOperation>{
        public TypeOperationService(TypeOperationRepository repository):base(repository){
        }
    }
}