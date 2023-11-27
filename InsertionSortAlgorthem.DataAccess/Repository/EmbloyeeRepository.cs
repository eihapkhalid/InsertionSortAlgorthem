using InsertionSortAlgorthem.DataAccess.Data;
using InsertionSortAlgorthem.DataAccess.Repository.IRepository;
using InsertionSortAlgorthem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlgorthem.DataAccess.Repository
{
    public class EmbloyeeRepository : Repository<TbEmbloyee>, IEmbloyeeRepository
    {
        #region dependency injection
        private SortAlgoDbContext _db;
        public EmbloyeeRepository(SortAlgoDbContext db) : base(db)
        {
            _db = db;
        }
        #endregion

        #region Update
        public void Update(TbEmbloyee obj)
        {
            _db.TbEmbloyees.Update(obj);
        }
        #endregion
    }
}
