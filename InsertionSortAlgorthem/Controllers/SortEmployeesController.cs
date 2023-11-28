using InsertionSortAlgorthem.DataAccess.UnitOfWork;
using InsertionSortAlgorthem.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace InsertionSortAlgorthem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortEmployeesController : ControllerBase
    {
        #region Inject
        private readonly IUnitOfWork _unitOfWork;
        private InsertionSortingService _insertionSortingService;

        public SortEmployeesController(IUnitOfWork unitOfWork, InsertionSortingService insertionSortingService)
        {
            _unitOfWork = unitOfWork;
            _insertionSortingService = insertionSortingService;
        }
        #endregion

        #region Sort Employees By Age
        [HttpGet("SortEmployeesByAge")]
        public IActionResult SortEmployeesByAge()
        {
            var employees = _unitOfWork.TbEmbloyeeRepository.GetAll().ToList();
            _insertionSortingService.InsertionSort(employees);

            // إرجاع استجابة مناسبة
            return Ok(employees);
        }
        #endregion
        
    }
}
