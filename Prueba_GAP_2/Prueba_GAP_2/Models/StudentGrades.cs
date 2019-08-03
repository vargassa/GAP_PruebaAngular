using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;

namespace Prueba_GAP_2.Models
{
    public class StudentGrades
    {
        public String Student { get; set; }
        public Int32 Languaje { get; set; }
        public Int32 Science { get; set; }
        public Int32 SocialStudies { get; set; }
        public Int32 Maths { get; set; }
    }
}