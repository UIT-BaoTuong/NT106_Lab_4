using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai4_WebAPI.Controller
{
    public class StudentController : ApiController
    {
        Student[] students = new Student[]
        {
            new Student { ID = 1, Name = "Nguyen Van A", DateOfBirth = new DateTime(2005, 1, 1), School = "UIT" },
            new Student { ID = 2, Name = "Nguyen Van B", DateOfBirth = new DateTime(2005, 2, 2), School = "HCMUS" },
            new Student { ID = 3, Name = "Nguyen Van C", DateOfBirth = new DateTime(2005, 3, 3), School = "USSH" },
            new Student { ID = 4, Name = "Tran Thi D", DateOfBirth = new DateTime(2005, 4, 4), School = "UIT" },
            new Student { ID = 5, Name = "Le Thi E", DateOfBirth = new DateTime(2005, 5, 5), School = "HCMUS" },
            new Student { ID = 6, Name = "Pham Van F", DateOfBirth = new DateTime(2005, 6, 6), School = "USSH" },
            new Student { ID = 7, Name = "Hoang Thi G", DateOfBirth = new DateTime(2005, 7, 7), School = "UIT" },
            new Student { ID = 8, Name = "Vo Van H", DateOfBirth = new DateTime(2005, 8, 8), School = "HCMUS" },
            new Student { ID = 9, Name = "Dang Thi I", DateOfBirth = new DateTime(2005, 9, 9), School = "USSH" },
            new Student { ID = 10, Name = "Ngo Van J", DateOfBirth = new DateTime(2005, 10, 10), School = "UIT" },
            new Student { ID = 11, Name = "Bui Thi K", DateOfBirth = new DateTime(2005, 11, 11), School = "HCMUS" },
            new Student { ID = 12, Name = "Dang Van L", DateOfBirth = new DateTime(2005, 12, 12), School = "USSH" },
            new Student { ID = 13, Name = "Vu Thi M", DateOfBirth = new DateTime(2005, 1, 13), School = "UIT" }
        };
        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }
        public IHttpActionResult GetProduct(int id)
        {
            var student = students.FirstOrDefault((p) => p.ID == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
