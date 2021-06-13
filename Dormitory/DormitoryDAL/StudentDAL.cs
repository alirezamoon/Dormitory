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
        /*
         * ارتباط با دیتابیس
         * Dormitory
         * قابل اعتماد بودن ارتباط
         */
        public StudentDAL()
        {
            connection = new SqlConnection("Server=. ; Database=Dormitory ; trusted_connection= true");
        }
        // افزودن دانشجو به خوابگاه
        public void Insert(Student obj)
        {

            try
            {
                //باز کردن دیتابیس
                connection.Open();

                /*
                 * کوئری افزودن دانشجوی جدید به دیتابیس
                 * دانشجو به اتاق اضافه میشود
                 * ظرفیت اتاق بروزرسانی میشود
                 */
                SqlCommand cmd = new SqlCommand(
                    String.Format(
                        "INSERT INTO student VALUES('{0}','{1}','{2}','{3}','{4}','{5}')" +
                        " update room set capacity = (capacity - 1) where (capacity > 0) and RoomID='{5}' ",
                obj.firstName, obj.lastName, obj.stuID, obj.major, obj.city, obj.roomID), connection);
                // اجرا کردن کوئری
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                /*
                 * اروری داشتیم try اگر در 
                 * متن ارور را برمیگرداند
                 * تا در تکست باکس به کاربر نمایش داده شود
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
        }
        //حذف دانشجو از خوابگاه
        public void Delete(string stno, Student obj)
        {

            try
            {
                //باز کردن دیتابیس
                connection.Open();
                /*
                 * کوئری حذف دانشجو
                 * ابتدا ظرفیت اتاق دانشجو را یکی اضافه میکنیم
                 * سپس دانشجو را از دیتابیس حذف میکنیم
                 */
                SqlCommand cmd = new SqlCommand(
                    String.Format(
                        "update room set capacity = (capacity + 1) where RoomID IN (select stuRoomID from student where stuID='{0}') " +
                        " DELETE FROM STUDENT WHERE stuID = '{0}'"
                        , stno), connection);
                // اجرا کردن کوئری
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                /*
                 * اروری داشتیم try اگر در 
                 * متن ارور را برمیگرداند
                 * تا در تکست باکس به کاربر نمایش داده شود
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

        }
        // بروزرسانی اطلاعات دانشجو
        public void Update(string stno, Student obj)
        {
            try
            {
                //باز کردن دیتابیس
                connection.Open();
                /*
                 * کوئری بروزرسانی اطلاعات دانشجو
                 * ابتدا ظرفیت اتاق مربوط دانشجو را یکی اضافه میکنیم
                 * اطلاعات دانشجو را بروزرسانی میکنیم
                 * به ظرفیت اتاق جدید دانشجو یه واحد اضافه میکنیم
                 * زیرا ممکن است کاربر اتاق دانشجو را تغیر دهد
                 */
                SqlCommand cmd = new SqlCommand(
                    String.Format(
                        "update room set capacity = (capacity + 1) where RoomID IN (select stuRoomID from student where stuID='{6}')" +
                        "UPDATE student SET firstName='{0}',lastName='{1}' ,stuID='{2}' ,major='{3}',city='{4}',stuRoomID='{5}' WHERE stuID = {6}" +
                        "update room set capacity = (capacity - 1) where RoomID IN (select stuRoomID from student where stuID='{6}')",
                obj.firstName, obj.lastName, obj.stuID, obj.major, obj.city, obj.roomID, stno), connection);
                // اجرا کردن کوئری
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                /*
                 * اروری داشتیم try اگر در 
                 * متن ارور را برمیگرداند
                 * تا در تکست باکس به کاربر نمایش داده شود
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

        }
        
        //موجود بودن دانشجو با یک شماره دانشجویی مشخص
        public bool Exists(string stno)
        {
            try
            {
                //باز کردن دیتابیس
                connection.Open();
                /*
                 * کوئری مربوط به موجود بودن دانشجو با شماره دانشجویی مشخص
                 * تعداد دانشجوهارا با این شماره دانشجویی میشمارد
                 * اگر ضفر بود یعنی این شماره دانشجویی در دیتابیس وجود ندارد
                 */
                SqlCommand cmd = new SqlCommand(String.Format("select count(*) from student where stuID = {0}", stno), connection);
                // اجرا کردن کوئری
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
                /*
                 * اروری داشتیم try اگر در 
                 * متن ارور را برمیگرداند
                 * تا در تکست باکس به کاربر نمایش داده شود
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

        // مشاهده اطلاعات تمام دانشجویان
        public List<Student> Select()
        {
            try
            {
                List<Student> li = new List<Student>();
                //باز کردن دیتابیس
                connection.Open();
                /*
                 * کوئری مشاهده اطلاعات تمام دانشجویان
                 */
                SqlCommand cmd = new SqlCommand("select firstName,lastName,stuID,major,city,stuRoomID from Student", connection);
                // اجرا کردن کوئری
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    li.Add(new Student(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                }
                return li;
            }
            catch (SqlException ex)
            {
                /*
                 * اروری داشتیم try اگر در 
                 * متن ارور را برمیگرداند
                 * تا در تکست باکس به کاربر نمایش داده شود
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
            return null;
        }

        //جستجوی یک دانشجو با شماره دانشجویی مشخص
        public List<Student> Search(string stno, Student obj)
        {
            try
            {
                List<Student> li = new List<Student>();
                //باز کردن دیتابیس
                connection.Open();
                /*
                 * کوئری مشاهده اطلاعات یک دانشجو با شماره دانشجویی مشخص
                 */
                SqlCommand cmd = new SqlCommand(String.Format("select firstName,lastName,stuID,major,city,stuRoomID from Student where stuID = '{0}'", stno), connection);
                // اجرا کردن کوئری
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    li.Add(new Student(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
                }
                return li;
            }
            catch (SqlException ex)
            {
                /*
                 * اروری داشتیم try اگر در 
                 * متن ارور را برمیگرداند
                 * تا در تکست باکس به کاربر نمایش داده شود
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

            return null;
        }

        //مشاهده ظرفیت کل خوابگاه
        public int Capacity()
        {
            try
            {
                //باز کردن دیتابیس
                connection.Open();
                /*
                 * کوئری جمع کردن تعداد تخت همه اتاق ها
                 * در واقع برابر است با ظرفیت کل خوابگاه
                 */
                SqlCommand cmd = new SqlCommand("select sum(bedNumber) from room", connection);
                // اجرا کردن کوئری
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n;
            }
            catch (SqlException ex)
            {
                /*
                 * اروری داشتیم try اگر در 
                 * متن ارور را برمیگرداند
                 * تا در تکست باکس به کاربر نمایش داده شود
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
            return 0;

        }

        // مشاهده ظرفیت باقی مانده
        public int AvailableCapacity()
        {

            try
            {
                //باز کردن دیتابیس
                connection.Open();
                /*
                 * کوئری جمع کردن ظرفیت باقیمانده تمام اتاق های خوابگاه
                 * برای مشاهده ظرفیت باقیمانده خوابگاه
                 */
                SqlCommand cmd = new SqlCommand("select sum(capacity) from room", connection);
                // اجرا کردن کوئری
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return n;
            }
            catch (SqlException ex)
            {
                /*
                 * اروری داشتیم try اگر در 
                 * متن ارور را برمیگرداند
                 * تا در تکست باکس به کاربر نمایش داده شود
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
            return 0;

        }
    }
}

