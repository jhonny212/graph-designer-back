using System;
using System.Collections.Generic;

namespace data_graph_designer.Models;

public partial class Graph
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int DashboardRowId { get; set; }

    public int TypeGraphId { get; set; }

    public int EndpointId { get; set; }

    public int Order { get; set; }

    public virtual DashboardRow DashboardRow { get; set; } = null!;

    public virtual Endpoint Endpoint { get; set; } = null!;

    public virtual TypeGraph TypeGraph { get; set; } = null!;
}
