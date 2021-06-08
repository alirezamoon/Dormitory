using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryBO
{
    public class Room
    {
        public string RoomID { get; set; }
        public string RName { get; set; }
        public int capacity { get; set; }
        public int bedNumber { get; set; }
        public string options { get; set; }
        public Room(string roomID, string rname, int cap, int bednum, string op)
        {
            this.RoomID = roomID;
            this.RName = rname;
            this.capacity = cap;
            this.bedNumber = bednum;
            this.options = op;
        }
        public Room(string roomID, string rname)
        {
            this.RoomID = roomID;
            this.RName = rname;
            this.capacity = 0;
            this.bedNumber = 0;
            this.options = null;
        }

    }
}
