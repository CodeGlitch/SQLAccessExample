using SQLAccessExample.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLAccessExample.Data
{
    public interface ISQLAccess
    {
        Task<List<MyDataStructure>> SELECT_MyData(string id, string title);
    }
}