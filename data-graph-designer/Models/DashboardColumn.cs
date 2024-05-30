using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace data_graph_designer.Models;

public partial class DashboardColumn
{
    public int Id { get; set; }

    public int Columns { get; set; }

    public string Unit { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<DashboardRow>? DashboardRows { get; set; } = new List<DashboardRow>();
}
