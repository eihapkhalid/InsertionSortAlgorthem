using InsertionSortAlgorthem.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlgorthem.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Save();

        //public ITbRepository Tb { get; }
        public IEmbloyeeRepository TbEmbloyeeRepository { get; }
    }
}
