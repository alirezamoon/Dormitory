using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryDAL;
using DormitoryBO;

namespace DormitoryBLL
{
    public class RoomBLL
    {
        // هندل کردن خطاها
        //خطایی رخ نمیدهد Room در رابطه با کار دیتابیس با جدول
        // مستقیم میرویم برای کار با دیتابیس
        RoomDAL roomDataAccessLayer;
        public RoomBLL()
        {
            roomDataAccessLayer = new RoomDAL();
        }
        public List<Room> view()
        {
            return roomDataAccessLayer.Select();
        }
    }
}
