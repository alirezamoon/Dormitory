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
        /*
         * ارتباط با دیتابیس
         * Dormitory
         * قابل اعتماد بودن ارتباط
         */
        public RoomDAL()
        {
            connection = new SqlConnection("Server=. ; Database=Dormitory ; trusted_connection= true");
        }

        //مشاهده اطلاعات تمام اتاق ها
        public List<Room> Select()
        {
            try
            {
                /*
                 کوئری مربوط به مشاهده اطلاعات جدول اتاق
                 شامل :
                 آیدی ، نام ، ظرفیت ، تعداد تخت ، امکانات
                 */
                List<Room> li = new List<Room>();

                // باز کردن دیتابیس
                connection.Open();
                SqlCommand cmd = new SqlCommand("select roomid, rname, capacity, bednumber, options from Room", connection);

                // اجرا کردن کوئری
                SqlDataReader reader = cmd.ExecuteReader();

                // ذخیره کردن اطلاعات در لیست
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
                    // کار ما به پایان رسید
                    // بستن ریتابیس
                    connection.Close();
                }
            }
            return null;
        }

        // بررسی آیا اتاق با شماره مشخص ظرفیت خالی دارد یا خیر
        public bool hasCapacity(string roomID)
        {
            try
            {
                //باز کردن دیتابیس
                connection.Open();

                //کوئری دریافت ظرفیت یک اتاق با یک آیدی یکتا
                // یک عدد برمیگرداند که نشان دهنده ظرفیت اتاق میباشد
                SqlCommand cmd = new SqlCommand(String.Format("select capacity from room where RoomID = {0}", roomID), connection);
                int n = Convert.ToInt32(cmd.ExecuteScalar());

                // اگر ظرفیت برابر با صفر بود یعنی اتاق ما ظرفیت خالی ندارد
                if (n == 0)
                {
                    return false;
                }
                // اگر ظرفیت برابر با صفر نبود یعنی اتاق ما ظرفیت خالی دارد
                else
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
                /*
                 اگر اروری در 
                 try
                 بود ، ارور برگردانده میشود تا در باکس نمایش داده شود
                 */
                throw ex;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    //بستن دیتابیس
                    connection.Close();
                }
            }
            return false;

        }
    }
}
