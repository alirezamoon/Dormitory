using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DormitoryBO;


namespace DormitoryDAL
{
    public class RoomDAL
    {
        SqlConnection connection;
        public RoomDAL()
        {
            connection = new SqlConnection("Server=. ; Database=Dormitory ; trusted_connection= true");
        }
        public List<Room> Select()
        {
            try
            {
                List<Room> li = new List<Room>();
                connection.Open();
                SqlCommand cmd = new SqlCommand("select roomid, rname, capacity, bednumber, options from Room", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    li.Add(new Room(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4)));
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
        public bool hasCapacity(string roomID)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(String.Format("select capacity from room where RoomID = {0}", roomID), connection);
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                if (n == 0)
                {
                    return false;
                }
                else
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
    }
}
