using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DormitoryBLL;
using DormitoryBO;

namespace Dormitory
{
    public partial class removeStudent : Form
    {
        public removeStudent()
        {
            InitializeComponent();
        }

        private void btndeleted_Click(object sender, EventArgs e)
        {
            Student s = new Student(txtstno.Text);
            StudentBLL sbll = new StudentBLL();
            try
            {
                sbll.Delete(s, txtstno.Text);
                MessageBox.Show("دانشجوی مورد نظر حذف گردید", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }



        }

        private void txtstno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
