using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DormitoryBO;


namespace DormitoryDAL
{
    public class StudentDAL
    {
        SqlConnection connection;
        public StudentDAL()
        {
            connection = new SqlConnection("Server=. ; Database=Dormitory ; trusted_connection= true");
        }
        public void Insert(Student obj)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    String.Format(
                        "INSERT INTO student VALUES('{0}','{1}','{2}','{3}','{4}','{5}')" +
                        " update room set capacity = (capacity - 1) where (capacity > 0) and RoomID='{5}' ",
                obj.firstName, obj.lastName, obj.stuID, obj.major, obj.city, obj.roomID), connection);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public void Delete(string stno, Student obj)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    String.Format(
                        "update room set capacity = (capacity + 1) where RoomID IN (select stuRoomID from student where stuID='{0}') "+
                        " DELETE FROM STUDENT WHERE stuID = '{0}'"
                        , stno), connection);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
        public void Update(string stno, Student obj)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    String.Format(
                        "update room set capacity = (capacity + 1) where RoomID IN (select stuRoomID from student where stuID='{6}')" +
                        "UPDATE student SET firstName='{0}',lastName='{1}' ,stuID='{2}' ,major='{3}',city='{4}',stuRoomID='{5}' WHERE stuID = {6}"+
                        "update room set capacity = (capacity - 1) where RoomID IN (select stuRoomID from student where stuID='{6}')",
                obj.firstName, obj.lastName, obj.stuID, obj.major, obj.city, obj.roomID, stno), connection);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
        public bool Exists(string stno)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(String.Format("select count(*) from student where stuID = {0}", stno), connection);
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                if (n == 0)
                {
                    return false;
                }
                else if (n == 1)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return false;

        }
        public List<Student> Select()
        {
            try
            {
                List<Student> li = new List<Student>();
                connection.Open();
                SqlCommand cmd = new SqlCommand("select firstName,lastName,stuID,major,city,stuRoomID from Student", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    li.Add(new Student(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                }
                return li;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return null;
        }
        public List<Student> Search(string stno, Student obj)
        {
            try
            {
                List<Student> li = new List<Student>();
                connection.Open();
                SqlCommand cmd = new SqlCommand(String.Format("select firstName,lastName,stuID,major,city,stuRoomID from Student where stuID = '{0}'", stno), connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    li.Add(new Student(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                }
                return li;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return null;
        }
        public int Capacity()
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select sum(bedNumber) from room", connection);

                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
             return 0;

        }

        public int AvailableCapacity()
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select sum(capacity) from room", connection);

                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return 0;

        }
    }
}

