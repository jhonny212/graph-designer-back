using System;
using System.Collections.Generic;

namespace data_graph_designer.Models;

public partial class EndpointDetail
{
    public int Id { get; set; }

    public string NameDbName { get; set; } = null!;

    public string NameApp { get; set; } = null!;

    public int TypeDataId { get; set; }

    public int EndpointId { get; set; }

    public virtual Endpoint Endpoint { get; set; } = null!;

    public virtual TypeDatum TypeData { get; set; } = null!;
}
