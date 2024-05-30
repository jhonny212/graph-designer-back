
using data_graph_designer.Datastore;
using data_graph_designer.Interfaces;
using data_graph_designer.Models;
using data_graph_designer.Repository;
using data_graph_designer.Services;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace data_graph_designer.Service{

    public class EndpointDetailsService: ServiceBase<EndpointDetail>{

        public DataDbContext dataDbContext;
        public EndpointRepository endpointRepository;

        public EndpointDetailsService(EndpointDetailRepository repository, DataDbContext dataDbContext, EndpointRepository endpointRepository) : base(repository)
        {
            this.dataDbContext = dataDbContext;
            this.endpointRepository = endpointRepository;
        }

        public Task<List<EndpointDetail>> GetAllEndpointDetailsByEndpoint(int id)
        {
            var repository = (EndpointDetailRepository)this._repository;
            return repository.GetAllEndpointDetailsByEndpoint(id);
        }

        public async Task<DataResponse> GetDataFromDatastore(int idTable, int limit = 5)
        {
            //Get table and columns
            Models.Endpoint table = await endpointRepository.GetById(idTable);
            List<Models.EndpointDetail> columns = await GetAllEndpointDetailsByEndpoint(idTable);
            string[] stringColumns = columns.Select(c=>c.NameDbName).ToArray();

            //Create response object
            List<object[]> data = new List<object[]>();
            DataResponse response = new DataResponse() { columns = columns, data = data };

            //Statement
            FormattableString sql = @$"select {string.Join(",",stringColumns)} from ""{table.DatabaseName.Trim()}"" limit {limit}";

            //Create connection
            using (var command = this.dataDbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sql.ToString();
                dataDbContext.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    while (result.Read()) {
                        var dataTmp = new object[columns.Count];
                        int counter = 0;
                        columns.ForEach(item =>
                        {
                            dataTmp[counter] = result.GetValue(item.NameDbName);
                            counter++;
                        });
                        data.Add(dataTmp);
                    }
                }
            }
            return response;
        }
    }
}