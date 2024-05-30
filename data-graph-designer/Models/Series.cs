namespace data_graph_designer.Models
{
    public partial class Series
    {
        public int Id { get; set; }
        public string Stack { get; set; }
        public string Type { get; set; }
        public int FieldId { get; set; }
        public virtual EndpointDetail Field { get; set; }

    }
}
