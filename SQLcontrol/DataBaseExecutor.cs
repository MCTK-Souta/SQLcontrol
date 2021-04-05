using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SQLcontrol
{
    public class DataBaseExecutor 
    {
        public static void InsertTestTablel(string fn, string ln, string birthday, string sex,string address //新增
            , string idn,string password,string email,string phone,string education
            ,string school,string department,string exp,string expyear) 
        {
            string connectionstring = "Data Source=localhost\\SQLExpress;Initial Catalog=Course registration; Integrated Security=true";

            string queryString =
                $@"INSERT INTO student_region
                    (StudentFirstName,StudentLastName,Birthday,Sex,Address,IDN,Password,Email,
                     Phone,Education,School,Department,Exp,Expyear)
                VALUES
                    (@StudentFirstName,@StudentLastName,@Birthday,@Sex,@Address,@IDN,@Password,@Email,
                     @Phone,@Education,@School,@Department,@Exp,@Expyear);";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@StudentFirstName", fn);
                command.Parameters.AddWithValue("@StudentLastName", ln);
                command.Parameters.AddWithValue("@Birthday", birthday);
                command.Parameters.AddWithValue("@Sex", sex);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@IDN", idn);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Education", education);
                command.Parameters.AddWithValue("@School", school);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@Exp", exp);
                command.Parameters.AddWithValue("@Expyear", expyear);


                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();
                    HttpContext.Current.Response.Write("Total change" + totalChangeRows + "Rows");
                }

                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex.Message);
                }
            }
        } 
        public static DataTable ReadTestTable1DT(string IDN) //查詢身分證
        {
            string connectionstring =
                "Data Source=localhost\\SQLExpress;Initial Catalog=Course registration; Integrated Security=true";

            string queryString =
                $@" SELECT * FROM student_region
                    WHERE IDN = @IDN 
                    ;";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@IDN", IDN);


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }

                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex.Message);
                    return null;
                }

            }

        }

        public static DataTable ReadTestTable1DTtest()
        {
            string connectionstring =
                "Data Source=localhost\\SQLExpress;Initial Catalog=CSharpLession; Integrated Security=true";

            string queryString =
                $@" SELECT * FROM TestTable1
                    WHERE NumberCol = @NumberCol 
                    ORDER BY ID DESC;";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@NumberCol", "3");


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

            }


        }

        public static void DeleteTestTablel(string idn) //刪除
        {
            string connectionstring = "Data Source=localhost\\SQLExpress;Initial Catalog=Course registration; Integrated Security=true";

            string queryString =
                $@"DELETE FROM student_region WHERE IDN=@IDN";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@IDN", idn);

                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();
                    HttpContext.Current.Response.Write("Total change" + totalChangeRows + "Rows");
                }

                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex.Message);
                }
            }
        } 

        public static void UpdateTestTablel(string fn, string ln, string birthday, string sex, string address //新增
            , string idn, string password, string email, string phone, string education
            , string school, string department, string exp, string expyear) //修改
        {
            string connectionstring = "Data Source=localhost\\SQLExpress;Initial Catalog=Course registration; Integrated Security=true";

            string queryString =
                $@"UPDATE  student_region SET
                    StudentFirstName=@StudentFirstName,StudentLastName=@StudentLastName,Birthday=@Birthday,Sex=@Sex,Address=@Address,IDN=@IDN,Password=@Password,Email=@Email,
                    Phone=@Phone,Education=@Education,School=@School,Department=@Department,Exp=@Exp,Expyear=@Expyear
                WHERE
                    IDN=@IDN;";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@StudentFirstName", fn);
                command.Parameters.AddWithValue("@StudentLastName", ln);
                command.Parameters.AddWithValue("@Birthday", birthday);
                command.Parameters.AddWithValue("@Sex", sex);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@IDN", idn);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Education", education);
                command.Parameters.AddWithValue("@School", school);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@Exp", exp);
                command.Parameters.AddWithValue("@Expyear", expyear);

                try
                {
                    connection.Open();
                    int totalChangeRows = command.ExecuteNonQuery();
                    HttpContext.Current.Response.Write("Total change" + totalChangeRows + "Rows");
                }

                catch (Exception ex)
                {
                    HttpContext.Current.Response.Write(ex.Message);
                }
            }
        } 
    }
}