using InsertionSortAlgorthem.DataAccess.UnitOfWork;
using InsertionSortAlgorthem.Models;

namespace InsertionSortAlgorthem.Utilities
{
    public class InsertionSortingService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InsertionSortingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void SortEmployeesByAge()
        {
            var employees = _unitOfWork.TbEmbloyeeRepository.GetAll().ToList();
            InsertionSort(employees);
            // ... تحديث البيانات في قاعدة البيانات إذا لزم الأمر
        }

        private void InsertionSort(List<TbEmbloyee> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var key = list[i];
                int j = i - 1;

                while (j >= 0 && list[j].Age > key.Age)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
        }

    }
}
