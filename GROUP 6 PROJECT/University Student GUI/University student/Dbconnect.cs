using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Data;

namespace University_student
{
    internal class Dbconnect
    {
        public static string checkCourseId = "";
        private static string connection_string = "Data Source=DESKTOP-DGV021E;Initial Catalog=University_StudentsS;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(connection_string);

        public void AddUser(string id, string fname, string lname, string email, string phone, string password, int courseid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT_STUDENT", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Fname", fname);
                cmd.Parameters.AddWithValue("@Lname", lname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@courseid", courseid);
                con.Open();

                int exc = cmd.ExecuteNonQuery();
                if (exc > 0)
                {
                    MessageBox.Show("Account Created Successfully");
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        /*this is what I have to remove*/

        //public void AddAdmin(string id, string fname, string lname, string email, string phone, string password, string usertype)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("INSERT_ADMIN", con);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@id", id);
        //        cmd.Parameters.AddWithValue("@Fname", fname);
        //        cmd.Parameters.AddWithValue("@Lname", lname);
        //        cmd.Parameters.AddWithValue("@email", email);
        //        cmd.Parameters.AddWithValue("@phone", phone);
        //        cmd.Parameters.AddWithValue("@password", password);
        //        cmd.Parameters.AddWithValue("@usertype", usertype);
        //        con.Open();

        //        int exc = cmd.ExecuteNonQuery();
        //        if (exc > 0)
        //        {
        //            MessageBox.Show("Account Created Successfully");
        //        }
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //        con.Close();
        //    }
        //}
        public static string USERTYPE;
        public bool LogUser(string id, string password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CHECK_STUDENT", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows)
            {
                checkCourseId = rdr["ID"].ToString();
                USERTYPE = "U";
                con.Close();
                return true;

            }
            con.Close();
            MessageBox.Show("User not Found!");
            return false;
        }
        public bool LogAdmin(string id, string password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("CHECK_ADMIN", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.HasRows)
            {
                USERTYPE = "A";
                con.Close();
                return true;

            }
            con.Close();
            MessageBox.Show("User not Found!");
            return false;


        }


      

        public void DeleteTable(string id)
        {
            try
            {
                string query = "Delete FROM STUDENTS WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();
                int exc = cmd.ExecuteNonQuery();
                if(exc > 0)
                {
                    MessageBox.Show("Successfully Deleted");
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

       




        /* Updating tables one by one*/
        public void updateFirstName(string id, string firstName)
        {
           
            
                con.Open();

                string query = "UPDATE STUDENTS SET First_Name = @FirstName WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            con.Close();
            
        }
        public void updateLastName(string id, string lastName)
        {
            
                con.Open();

                string query = "UPDATE STUDENTS SET Last_Name = @LastName WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            con.Close();
        }

        /*after here*/

        public void updateEmail(string id, string email)
        {
            
                con.Open();

                string query = "UPDATE STUDENTS SET Email = @Email WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            
        }

        public void updatePhone(string id, string phone)
        {
            
            
                con.Open();

                string query = "UPDATE STUDENTS SET Phone = @Phone WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            
        }

        public void updatePassword(string id, string password)
        {
            
            
                con.Open();

                string query = "UPDATE STUDENTS SET Password = @Password WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            
        }
    }
}
