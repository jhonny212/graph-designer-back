using System;
using System.Collections.Generic;
using data_graph_designer.Models;
using Microsoft.EntityFrameworkCore;

namespace data_graph_designer;

public partial class GraphDesignerContext : DbContext
{
    public GraphDesignerContext()
    {
    }

    public GraphDesignerContext(DbContextOptions<GraphDesignerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Series> Series { get; set; }
    public virtual DbSet<LineBar> LineBar { get; set; }

    public virtual DbSet<Dashboard> Dashboards { get; set; }

    public virtual DbSet<DashboardColumn> DashboardColumns { get; set; }

    public virtual DbSet<DashboardRow> DashboardRows { get; set; }

    public virtual DbSet<Models.Endpoint> Endpoints { get; set; }

    public virtual DbSet<EndpointDetail> EndpointDetails { get; set; }

    public virtual DbSet<EndpointType> EndpointTypes { get; set; }

    public virtual DbSet<Graph> Graphs { get; set; }

    public virtual DbSet<Height> Heights { get; set; }

    public virtual DbSet<TypeDatum> TypeData { get; set; }

    public virtual DbSet<TypeGraph> TypeGraphs { get; set; }

    public virtual DbSet<TypeOperation> TypeOperations { get; set; }

}
