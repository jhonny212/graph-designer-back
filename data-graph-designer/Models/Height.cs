using System;
using System.Collections.Generic;

namespace data_graph_designer.Models;

public partial class Height
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Size { get; set; }

    public string Unit { get; set; } = null!;

    public virtual ICollection<DashboardRow> DashboardRows { get; set; } = new List<DashboardRow>();
}
