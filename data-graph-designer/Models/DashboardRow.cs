using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace data_graph_designer.Models;

public partial class DashboardRow
{
    public int Id { get; set; }

    public int HeightId { get; set; }

    public int Order { get; set; }

    public int ColumnsId { get; set; }

    public int? DashboardId { get; set; }

    public virtual DashboardColumn Columns { get; set; } = null!;

    public virtual Dashboard? Dashboard { get; set; }

    [JsonIgnore]
    public virtual ICollection<Graph> Graphs { get; set; } = new List<Graph>();

    public virtual Height Height { get; set; } = null!;
}
