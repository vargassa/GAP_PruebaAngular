using System;
using System.Web;
using System.Linq;
using System.Web.Http;
using Microsoft.AspNet;
using System.Web.Http.Cors;
using System.Collections.Generic;

namespace Prueba_GAP_2.Controllers
{   
    public class StudentGradesController : ApiController
    {
        [HttpGet]
        public List<Models.StudentGrades> LoadAllStudents()
        {
            Data.BDStudentGrades cmd = new Data.BDStudentGrades();

            List<Models.StudentGrades> students = cmd.GetAllStudents();

            return students;
        }

        [HttpGet]
        public List<Models.StudentGrades> FilterStudentByName(String pName)
        {
            Data.BDStudentGrades cmd = new Data.BDStudentGrades();
            List<Models.StudentGrades> students = cmd.GetStudentsByName(pName);

            return students;
        }

        [HttpGet]
        public List<Models.StudentGrades> FilterStudentByNameAndScore(String pName, int pScore)
        {
            Data.BDStudentGrades cmd = new Data.BDStudentGrades();
            List<Models.StudentGrades> students = cmd.GetStudentsByNameAndScore(pName, pScore);

            return students;
        }

        [HttpGet]
        public List<Models.StudentGrades> FilterByAllOptions(String pName, int pScore, String pCourse)
        {
            Data.BDStudentGrades cmd = new Data.BDStudentGrades();
            List<Models.StudentGrades> students = cmd.FilterByAllOptions(pName, pScore, pCourse);

            return students;
        }
    }
}
