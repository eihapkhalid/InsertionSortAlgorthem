using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortAlgorthem.Models
{
    public class TbEmbloyee
    {
        [Key]
        public int EmbloyeeId { get; set; }

        [Required(ErrorMessage = "يجب إدخال الاسم")]
        [StringLength(100, ErrorMessage = "يجب ألا يتجاوز الاسم 100 حرف")]
        public string EmbloyeeName { get; set; }

        [Required(ErrorMessage = "يجب إدخال العمر")]
        [Range(18, 65, ErrorMessage = "يجب أن يكون العمر بين 18 و 65 سنة")]
        public int EmbloyeeAge { get; set; }

        [Required(ErrorMessage = "يجب إدخال الراتب")]
        [Range(1000, 100000, ErrorMessage = "يجب أن يكون الراتب بين 1000 و 100000")]
        public decimal EmbloyeeSalary { get; set; }

        [Required(ErrorMessage = "يجب تحديد حالة النشاط")]
        public bool EmbloyeeIsActive { get; set; }
    }
}
