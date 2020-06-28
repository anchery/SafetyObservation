using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ObsData : IObsData
    {
        private readonly ISqlDataAccess _db;

        public ObsData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<MasterModel>> GetObs()
        {
            string sql = "Select * From OBS_Master";
            return _db.LoadData<MasterModel, dynamic>(sql, new { });
        }
        public Task InsertObs(MasterModel obs)
        {
            string sql = @"insert into OBS_Master(PICCode,Observer)
                            Values(@PICCode,@Observer);";
            return _db.SaveData(sql, obs);
        }
    }
}
