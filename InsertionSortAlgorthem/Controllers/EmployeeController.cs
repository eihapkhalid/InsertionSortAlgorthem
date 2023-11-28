using InsertionSortAlgorthem.DataAccess.UnitOfWork;
using InsertionSortAlgorthem.Models;
using InsertionSortAlgorthem.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsertionSortAlgorthem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Inject
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Post Creat Employee
        [HttpPost("PostEmployee")]
        public IActionResult PostEmployee([FromBody] TbEmbloyee model)
        {
            try
            {
                var foundEmployee = _unitOfWork.TbEmbloyeeRepository.Get(e => e.EmbloyeeId == model.EmbloyeeId);
                if (foundEmployee != null)
                {
                    #region Update
                    // تحديث الإعدادات الحالية
                    foundEmployee.EmbloyeeId = model.EmbloyeeId;
                    foundEmployee.EmbloyeeName = model.EmbloyeeName;
                    foundEmployee.EmbloyeeAge = model.EmbloyeeAge;
                    foundEmployee.EmbloyeeIsActive = model.EmbloyeeIsActive;
                    foundEmployee.EmbloyeeSalary = model.EmbloyeeSalary;
                    _unitOfWork.Save(); // لحفظ التغييرات في قاعدة البيانات
                    #endregion
                }
                else
                {
                    #region Add new
                    // إضافة موظف جديد
                    _unitOfWork.TbEmbloyeeRepository.Add(model);
                    _unitOfWork.Save(); // لحفظ التغييرات في قاعدة البيانات 
                    #endregion
                }

                #region Ok
                return Ok(model); // إرجاع النموذج بالبيانات المحدثة أو الجديدة 
                #endregion
            }
            catch (Exception ex)
            {
                #region error
                // التعامل مع الاستثناءات
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                #endregion
            }
        }
        #endregion

        [HttpGet("GetAllEmployee")]
        public IActionResult GetAllEmployee()
        {
            var ListEmployee = _unitOfWork.TbEmbloyeeRepository.GetAll();
            return Ok(ListEmployee); // تحويل القائمة إلى OkObjectResult
        }

    }
}
