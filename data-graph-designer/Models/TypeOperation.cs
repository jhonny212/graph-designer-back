using System;
using System.Collections.Generic;

namespace data_graph_designer.Models;

public partial class TypeOperation
{
    public int Id { get; set; }

    public string Tag { get; set; } = null!;

    public string Name { get; set; } = null!;
}
