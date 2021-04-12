using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using StudentDataView.Data;
using StudentDataView.Models;

namespace StudentDataView.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentDataContext _context;

        public StudentsController(StudentDataContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentView>>> GetStudents(
            string? name, string? year)
        {
            var studentQueryable = from student in _context.Students
                                   select student;
            if (!String.IsNullOrEmpty(name))
                studentQueryable = FilterName(studentQueryable, name);
            if (!String.IsNullOrEmpty(year))
                studentQueryable = FilterYear(studentQueryable, year);

            var students = await studentQueryable.AsNoTracking()
                .ToListAsync();
            var studentsView = students.Select(student => new StudentView(student))
                .ToList();
            return studentsView;
        }

        [HttpGet("AddPoint/{id}", Name = "AddPoint")]
        public async Task<ActionResult<StudentView>> AddPoint(string id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
                return NotFound();
            student.Points++;
            await _context.SaveChangesAsync();
            return new StudentView(student);
        }

        private static IQueryable<StudentDataModel> FilterName(
            IQueryable<StudentDataModel> studentQueryable, string name)
        {
            return studentQueryable.Where(
                student => student.FirstName.Contains(name) ||
                    student.LastName.Contains(name) ||
                    student.LegalFirstName.Contains(name) ||
                    student.LegalLastName.Contains(name)
            );
        }

        private static IQueryable<StudentDataModel> FilterYear(
            IQueryable<StudentDataModel> studentQueryable, string year)
        {
            return studentQueryable.Where(
                student => student.YearCode == year);
        }

        private bool StudentDataModelExists(string id)
        {
            return _context.Students.Any(e => e.StudentDataModelID == id);
        }
    }
}
