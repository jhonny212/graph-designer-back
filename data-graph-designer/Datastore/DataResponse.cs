using data_graph_designer.Models;

namespace data_graph_designer.Datastore
{
    public partial class DataResponse
    {
        public virtual List<EndpointDetail> columns { get; set; } =null!;
        public virtual List<object[]> data { get; set; } = null!;

    }
}
