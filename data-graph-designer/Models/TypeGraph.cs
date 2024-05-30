using System;
using System.Collections.Generic;

namespace data_graph_designer.Models;

public partial class TypeGraph
{
    public int Id { get; set; }

    public string Tag { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Graph> Graphs { get; set; } = new List<Graph>();
}
