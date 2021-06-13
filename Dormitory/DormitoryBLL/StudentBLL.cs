using DormitoryBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryDAL;

namespace DormitoryBLL
{
    public class StudentBLL
    {
        StudentDAL StudentDataAccessLayer;
        RoomDAL RoomDataAccessLayer;
        public StudentBLL()
        {
            StudentDataAccessLayer = new StudentDAL();
            RoomDataAccessLayer = new RoomDAL();
        }
        //هندل کردن خطاها
        public void Insert(Student obj)
        {
            if (RoomDataAccessLayer.hasCapacity(obj.roomID) == false)
            {
                throw new Exception("ظرفیت اتاق پر است. لطفا اتاق دیگری انتخاب کنید");
            }
            if (string.IsNullOrEmpty(obj.firstName) || string.IsNullOrEmpty(obj.lastName) || string.IsNullOrEmpty(obj.stuID) || string.IsNullOrEmpty(obj.city) || string.IsNullOrEmpty(obj.major) || string.IsNullOrEmpty(obj.roomID))
            {
                throw new Exception("لطفا تمام فیلد ها را پر کنید");
            }
            if (obj.firstName.Length > 50 || obj.lastName.Length > 50)
            {
                throw new Exception("طول نام یا نام خانوادگی بیش از حد مجاز است ");
            }
            if (StudentDataAccessLayer.Exists(obj.stuID) == true)
            {
                throw new Exception("دانشجو با این شماره دانشجویی قبلا اضافه شده است");
            }
            StudentDataAccessLayer.Insert(obj);
        }
        public void Delete(Student obj, string stno)
        {
            if (StudentDataAccessLayer.Exists(stno) == false)
            {
                throw new Exception("...این شماره دانشجویی وجود ندارد");
            }
            StudentDataAccessLayer.Delete(stno, obj);
        }
        public void Edit(Student obj, string stno)
        {
            if (string.IsNullOrEmpty(obj.firstName) || string.IsNullOrEmpty(obj.lastName) || string.IsNullOrEmpty(obj.stuID) || string.IsNullOrEmpty(obj.city) || string.IsNullOrEmpty(obj.major) || string.IsNullOrEmpty(obj.roomID))
            {
                throw new Exception("لطفا تمام فیلد ها را پر کنید");
            }
            if (obj.firstName.Length > 50 || obj.lastName.Length > 50)
            {
                throw new Exception("طول نام یا نام خانوادگی بیش از حد مجاز است ");
            }
            if (StudentDataAccessLayer.Exists(stno) == false)
            {
                throw new Exception("...این شماره دانشجویی وجود ندارد");
            }
            StudentDataAccessLayer.Update(stno, obj);
        }
        public List<Student> view()
        {
            return StudentDataAccessLayer.Select();
        }
        public List<Student> Search(Student obj, string stno)
        {
            if (StudentDataAccessLayer.Exists(stno) == false)
            {
                throw new Exception("...این شماره دانشجویی وجود ندارد");
            }
            return StudentDataAccessLayer.Search(stno, obj);
        }

        public int Capacity()
        {
            return StudentDataAccessLayer.Capacity();
        }
        public int AvailableCapacity()
        {
            return StudentDataAccessLayer.AvailableCapacity();
        }
    }
}


