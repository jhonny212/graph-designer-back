using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace data_graph_designer.Models;

public partial class TypeDatum
{
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    public string TypeDb { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<EndpointDetail> EndpointDetails { get; set; } = new List<EndpointDetail>();
}
