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
