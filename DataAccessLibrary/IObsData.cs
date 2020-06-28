using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IObsData
    {
        Task<List<MasterModel>> GetObs();
        Task InsertObs(MasterModel obs);
    }
}