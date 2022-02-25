using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_application.Shared
{
    public  class EmployeeInfo
    {

        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public int EmployeeAge { get; set; }
        [Required]
        public string EmployeeCity { get; set; }
        [Required]
        public grade EmployeeGrade { get; set; }
        [Required]
        public int EmployeeExperience { get; set; }
        





    }
}
