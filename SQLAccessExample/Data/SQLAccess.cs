using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SQLAccessExample.Data
{
    public class SQLAccess : ISQLAccess
    {
        private readonly IConfiguration config;
        public SQLAccess(IConfiguration _config)
        {
            //Parameters included on the class constructor are automatically dependency injected
            //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0
            config = _config;

        }
        public async Task<List<Model.MyDataStructure>> SELECT_MyData(string id, string title)
        {
            using (SqlConnection con = new SqlConnection(config.GetConnectionString("Default")))
            {
                DynamicParameters parameters = new DynamicParameters();
                //Added commented parameters just as an example of how to pass them
                parameters.Add("PK_MyDataStructure", id);
                parameters.Add("Title", title);
                IEnumerable<Model.MyDataStructure> formacao = await con.QueryAsync<Model.MyDataStructure>("SELECT_MyData", parameters, commandType: CommandType.StoredProcedure);
                return formacao.ToList();
            }
        }
    }
}
