namespace data_graph_designer.Models
{
    public partial class LineBar
    {
        public int Id { get; set; }
        public string Xaxis{ get; set; }
        public string Type { get; set; }
        public bool AreaStyle { get; set; } = false;
        public string PositionLabel { get; set; } = null!;
        public int GraphId { get; set; }
        public virtual Graph Graph { get; set; }
    }
}
