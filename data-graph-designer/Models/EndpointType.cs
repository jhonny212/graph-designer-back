using System;
using System.Collections.Generic;

namespace data_graph_designer.Models;

public partial class EndpointType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? Status { get; set; }

    public virtual ICollection<Endpoint> Endpoints { get; set; } = new List<Endpoint>();
}
