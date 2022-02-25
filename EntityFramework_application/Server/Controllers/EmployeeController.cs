using EntityFramework_application.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework_application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<grade> Grade = new List<grade>
        {
            new grade { name_grade = "Product Owner" },
            new grade {name_grade = "Scrum master" },
            new grade { name_grade = "Dev Team" },
            new grade {name_grade = "intern" }

        };
        List<EmployeeInfo> Employees = new List<EmployeeInfo> {

            new EmployeeInfo { EmployeeID = 1, EmployeeName = "mohsen", EmployeeAge = 27 , EmployeeCity = "mourouj", EmployeeExperience = 4 , EmployeeGrade = Grade[0]},
            new EmployeeInfo { EmployeeID = 2, EmployeeName = "Mostafa", EmployeeAge = 25 , EmployeeCity = "monastir", EmployeeExperience = 7 , EmployeeGrade =Grade[1] },
            new EmployeeInfo { EmployeeID = 3, EmployeeName = "mayar", EmployeeAge = 30 , EmployeeCity = "Sousse", EmployeeExperience = 12 , EmployeeGrade = Grade[2]},
            new EmployeeInfo { EmployeeID = 6, EmployeeName = "mohamed", EmployeeAge = 24 , EmployeeCity = "Menzel Kamel", EmployeeExperience = 0 , EmployeeGrade = Grade[3]},
            new EmployeeInfo { EmployeeID = 7, EmployeeName = "Ikbel", EmployeeAge = 28 , EmployeeCity = "Tunis", EmployeeExperience = 0 , EmployeeGrade = Grade[3]},
            new EmployeeInfo { EmployeeID = 11, EmployeeName = "Karima", EmployeeAge = 45 , EmployeeCity = "Qatar", EmployeeExperience = 20 , EmployeeGrade = Grade[1]},
            new EmployeeInfo { EmployeeID = 77, EmployeeName = "henda", EmployeeAge = 26 , EmployeeCity = "Tunis", EmployeeExperience = 2 , EmployeeGrade = Grade[2]},
             new EmployeeInfo { EmployeeID = 119, EmployeeName = "Soukaina", EmployeeAge = 43 , EmployeeCity = "Marsa", EmployeeExperience = 15 , EmployeeGrade = Grade[3]},
        };




        public async Task<IActionResult> GetEmployees() //IActionResul enables us to return an http status code 
        { 

            return Ok(Employees); // return 200 code (200 = ok (sucess)  in an http request 
        }

    }
}
