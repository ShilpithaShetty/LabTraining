using EmpMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpMvc.Controllers
{
    public class EmpController : Controller
    {
        [HttpGet("/employee")]
        public IActionResult GetEmp()
        {
            var employees = EmpOp.GetEmp();
            return View("EmpList", employees);
        }

        [HttpGet("/search/{empid}")]
        public IActionResult GetPersonDetails(int empid)
        {
            var found = EmpOp.Search(empid);
            return View("Search", found);

        }

        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View("Create", new Emp());
        }
        [HttpPost("/create")]
        public IActionResult Create([FromForm] Emp e)
        {
            EmpOp.CreateNew(e);
            return View("EmpList", EmpOp.GetEmp());
        }

        [HttpGet("/edit/{empid}")]
        public IActionResult Edit(int empid)
        {
            var found = EmpOp.Search(empid);
            return View("Edit", found);

        }

        [HttpPost("/edit/{empid}")]
        public IActionResult Edit(int empid, [FromForm] Emp e)
        {
            var found = EmpOp.Search(e.EmpId);
            found.Email = e.Email;
            found.Age = e.Age;
            found.Name = e.Name;
            found.DOJ = e.DOJ;
            found.Salary = e.Salary;
            found.Designation = e.Designation;
            return View("EmpList", EmpOp.GetEmp());
        }

        public IActionResult GetEmployee(int pEmpId)
        {
            var empBl = new EmpLib.Employee();
            return View("FromDb", empBl.GetEmployees());
        }

        public IActionResult InsertEmployee(int pEmpId)
        {
            var empBl = new EmpLib.Employee();
            return View("InsertDb", empBl.InsertEmployees());
        }

        public IActionResult UpdateEmployee(int pEmpId)
        {
            var empBl = new EmpLib.Employee();
            return View("UpdateDb", empBl.UpdateEmployees());
        }

        public IActionResult DeleteEmployee(int pEmpId)
        {
            var empBl = new EmpLib.Employee();
            return View("DeleteDb", empBl.DeleteEmployees());
        }

    }
}
