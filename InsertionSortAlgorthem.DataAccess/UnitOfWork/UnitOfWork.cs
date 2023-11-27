using InsertionSortAlgorthem.DataAccess.Data;
using InsertionSortAlgorthem.DataAccess.Repository;
using InsertionSortAlgorthem.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlgorthem.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region dependency injection
        private SortAlgoDbContext _db;

        // public ITbRepository Tb { get; private set; }
        public IEmbloyeeRepository TbEmbloyeeRepository { get; private set; }

        public UnitOfWork(SortAlgoDbContext db)
        {
            _db = db;
            //Tb = new TbRepository(_db);
            TbEmbloyeeRepository = new EmbloyeeRepository(_db);

        }
        #endregion

        #region Save
        public void Save()
        {
            try
            {
                int savedChanges = _db.SaveChanges();
                if (savedChanges > 0)
                {
                    Console.WriteLine("Data saved successfully. Number of affected rows: " + savedChanges);

                }
                else
                {
                    Console.WriteLine("No data changes to save.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving data to the database: " + ex.Message);
                // يمكنك التعامل مع الاستثناء هنا، مثلاً طباعة رسالة الخطأ أو تسجيلها
            }
        }
        #endregion
    }
}
