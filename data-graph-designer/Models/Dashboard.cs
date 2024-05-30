using System;
using System.Collections.Generic;
using data_graph_designer;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;

namespace data_graph_designer.Models;

public partial class Dashboard
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<DashboardRow> DashboardRows { get; set; } = new List<DashboardRow>();
}
