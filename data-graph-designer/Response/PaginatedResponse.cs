namespace data_graph_designer.Response
{
    public class PaginatedResponse<T>
    {
        public required IEnumerable<T> Data { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
