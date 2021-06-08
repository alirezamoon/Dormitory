using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Dormitory
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addStudent cs = new addStudent();
            cs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            removeStudent ds = new removeStudent();
            ds.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showAllStudents v = new showAllStudents();
            v.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchStudent s = new searchStudent();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateStudent ee = new updateStudent();
            ee.ShowDialog();
        }

        private void btncapacity_Click(object sender, EventArgs e)
        {
            Dormitory.Forms.CapacityForm cf = new Dormitory.Forms.CapacityForm();
            cf.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            rooms ee = new rooms();
            ee.ShowDialog();
        }
    }
}
