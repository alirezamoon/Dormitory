using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryBO
{
    public class Student
    {

        //صفت های دانشجو
        // در دیتابیس Student ستون های جدول
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string stuID { get; set; }
        public string major { get; set; }
        public string city { get; set; }
        public string roomID { get; set; }

        //تعریف سازنده های مورد نیاز
        public Student(string fname, string lname, string stno, string major, string city, string roomID)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.stuID = stno;
            this.major = major;
            this.city = city;
            this.roomID = roomID;
        }
        public Student(string stno)
        {
            this.firstName = null;
            this.lastName = null;
            this.stuID = stno;
            this.major = null;
            this.city = null;
            this.roomID = null;
        }
        public Student()
        {
            this.firstName = null;
            this.lastName = null;
            this.stuID = null;
            this.major = null;
            this.city = null;
            this.roomID = null;
        }
        public Student(string fname, string lname)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.stuID = null;
            this.major = null;
            this.city = null;
            this.roomID = null;
        }
        public Student(string fname, string lname, string stno)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.stuID = stno;
            this.major = null;
            this.city = null;
            this.roomID = null;
        }
        public override string ToString()
        {
            return firstName + " - " + lastName;
        }
    }
}
