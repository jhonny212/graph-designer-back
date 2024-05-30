using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace data_graph_designer.Models;

public partial class Endpoint
{
    public int Id { get; set; }

    public string DatabaseName { get; set; } = null!;

    public long EndpointTypeId { get; set; }

    public string DatabaseLabel { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<EndpointDetail> EndpointDetails { get; set; } = new List<EndpointDetail>();

    public virtual EndpointType EndpointType { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Graph> Graphs { get; set; } = new List<Graph>();
}
