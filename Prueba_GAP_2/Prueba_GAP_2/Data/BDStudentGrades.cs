using System;
using System.Web;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Prueba_GAP_2.Data
{
    public class BDStudentGrades
    {
        public const String ConnectionString = "Data Source=.;Initial Catalog=DataBaseGAP;Integrated Security=True";

        public List<Models.StudentGrades> GetAllStudents()
        {
            List<Models.StudentGrades> listOfStudents = new List<Models.StudentGrades>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetStudentGrades", con))
                {
                    SqlDataReader rdr = null;
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    rdr = cmd.ExecuteReader();
                 
                    while (rdr.Read())                    
                        listOfStudents.Add(new Models.StudentGrades
                        {
                            Student = rdr[0].ToString(),
                            Languaje = Int32.Parse(rdr[1].ToString()),
                            Science = Int32.Parse(rdr[2].ToString()),
                            SocialStudies = Int32.Parse(rdr[3].ToString()),
                            Maths = Int32.Parse(rdr[4].ToString())
                        });
                }
            }

            return listOfStudents;
        }

        public List<Models.StudentGrades> GetStudentsByName(String pName)
        {
            List<Models.StudentGrades> listOfStudents = new List<Models.StudentGrades>();
            if(pName == null)
                pName = "";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetStudentByName", con))
                {
                    SqlDataReader rdr = null;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter();
                    cmd.Parameters.Add( new SqlParameter { ParameterName= "@NAME" , Value=pName});
                    con.Open();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                        listOfStudents.Add(new Models.StudentGrades
                        {
                            Student = rdr[0].ToString(),
                            Languaje = Int32.Parse(rdr[1].ToString()),
                            Science = Int32.Parse(rdr[2].ToString()),
                            SocialStudies = Int32.Parse(rdr[3].ToString()),
                            Maths = Int32.Parse(rdr[4].ToString())
                        });
                }
            }

            return listOfStudents;
        }

        public List<Models.StudentGrades> GetStudentsByNameAndScore(String pName, int pScore)
        {
            List<Models.StudentGrades> listOfStudents = new List<Models.StudentGrades>();
            if (pName == null)
                pName = "";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetStudentByNameAndScore", con))
                {
                    SqlDataReader rdr = null;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter();
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@NAME", Value = pName });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@SCORE", Value = pScore });
                    con.Open();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        listOfStudents.Add(new Models.StudentGrades
                        {

                            Student = rdr[0].ToString(),
                            Languaje = Int32.Parse(rdr[1].ToString()),
                            Science = Int32.Parse(rdr[2].ToString()),
                            SocialStudies = Int32.Parse(rdr[3].ToString()),
                            Maths = Int32.Parse(rdr[4].ToString())
                        });
                    }
                }
            }

            return listOfStudents;
        }

        public List<Models.StudentGrades> FilterByAllOptions(String pName, int pScore, String pCourse)
        {
            List<Models.StudentGrades> listOfStudents = new List<Models.StudentGrades>();
            if (pName == null)
                pName = "";

            if (pCourse == null)
                pCourse = "";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_FilterByAllOptions", con))
                {
                    SqlDataReader rdr = null;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter();
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@NAME", Value = pName });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@SCORE", Value = pScore });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@COURSE", Value = pCourse });
                    con.Open();
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        listOfStudents.Add(new Models.StudentGrades
                        {
                            Student = rdr[0].ToString(),
                            Languaje = Int32.Parse(rdr[1].ToString()),
                            Science = Int32.Parse(rdr[2].ToString()),
                            SocialStudies = Int32.Parse(rdr[3].ToString()),
                            Maths = Int32.Parse(rdr[4].ToString())
                        });
                    }
                }
            }

            return listOfStudents;
        }



    }
}