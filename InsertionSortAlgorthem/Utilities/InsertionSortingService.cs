using InsertionSortAlgorthem.Models;

namespace InsertionSortAlgorthem.Utilities
{
    public class InsertionSortingService
    {

        internal void InsertionSort(List<TbEmbloyee> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var key = list[i];
                int j = i - 1;

                while (j >= 0 && list[j].EmbloyeeAge > key.EmbloyeeAge)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
        }

    }
}
