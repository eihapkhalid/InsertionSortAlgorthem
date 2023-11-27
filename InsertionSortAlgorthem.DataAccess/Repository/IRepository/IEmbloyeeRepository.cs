using InsertionSortAlgorthem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlgorthem.DataAccess.Repository.IRepository
{
    public interface IEmbloyeeRepository : IRepository<TbEmbloyee>
    {
        void Update(TbEmbloyee obj);
    }
}
