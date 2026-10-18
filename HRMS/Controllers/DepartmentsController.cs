using HRMS.Dtos.Departments;
using HRMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static HRMS.Controllers.EmployeesController;

namespace HRMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {


        public static List<Department> departments = new List<Department>()
        {
            new Department(){Id = 1, Name = "Human Resources", Description = "HR Department", FloorNumber = 1},
            new Department(){Id = 2, Name = "Finance", Description = "Finance Department", FloorNumber = 2},
            new Department(){Id = 3, Name = "Development", Description = "Development Department", FloorNumber = 1}
        };

        [HttpGet]
        public IActionResult GetByCriteria([FromQuery]SearchDepartmentsDto departmentsDto)
        {

            var data = from dep in departments
                         where (departmentsDto.Name == null || dep.Name.ToUpper().Contains(departmentsDto.Name.ToUpper())) &&
                            (departmentsDto.FloorNumber == null || dep.FloorNumber == departmentsDto.FloorNumber)
                         orderby dep.Id descending
                         select new DepartmentDto
                         {
                             Id = dep.Id,
                             Name  = dep.Name ,
                             Description = dep.Description,
                             FloorNumber = dep.FloorNumber
                         };
            return Ok(data);

        }
        
        [HttpGet("{id:long}")]
        public IActionResult GetById(long id)
        {
            var data = departments
                .Select(x => new DepartmentDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description =  x.Description,
                    FloorNumber = x.FloorNumber

                }).FirstOrDefault(x => x.Id == id);

            if (data == null)
            {
                return NotFound(new Exception("Department Not Found"));
            }

            return Ok(data);
        }


        [HttpPost]
        public IActionResult Create([FromBody]SaveDepartmentDto departmentDto)
        {

            var dep = new Department
            {
                Id = (departments.LastOrDefault()?.Id??0) + 1,
                Name = departmentDto.Name,
                Description = departmentDto.Description,
                FloorNumber = departmentDto.FloorNumber
            };

            departments.Add(dep);

            return Ok(dep.Id);

        }
        [HttpPut]
        public IActionResult Update(long id, SaveDepartmentDto departmentDto)

            
        {
            if(id != departmentDto.Id)
            {
                return BadRequest(new Exception("Id Mismatch"));//400
            }

            var department = departments.FirstOrDefault(x=>x.Id == departmentDto.Id);
            if (departments is null)
                return NotFound(new Exception("Department not found"));

            department.Name = departmentDto.Name;
            department.Description = departmentDto.Description;
            department.FloorNumber = departmentDto.FloorNumber;

            return Ok();
        }

        
        [HttpDelete("{id:long}")]
        public IActionResult Delete(long id)
        {
            var dep = departments.FirstOrDefault(x=>x.Id == id);

            if (dep is null)
                return NotFound(new Exception("id  does not found"));

            departments.Remove(dep);

            return Ok();
        }

    }
}
