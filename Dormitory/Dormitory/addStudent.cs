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
using DormitoryBO;
using DormitoryBLL;

namespace Dormitory
{
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void Created_Click(object sender, EventArgs e)
        {
            string name = txtFname.Text;
            string family = txtLname.Text;
            string stno = txtStno.Text;
            string major = txtMajor.Text;
            string city = txtCity.Text;
            string roomID = cbRooms.SelectedItem.ToString();
            Student S = new Student(name, family, stno, major, city, roomID);
            StudentBLL sBLL = new StudentBLL();
            try
            {
                sBLL.Insert(S);
                MessageBox.Show("دانشجوی جدید اضافه شد", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFname.Text = string.Empty;
                txtLname.Text = string.Empty;
                txtStno.Text = string.Empty;
                txtMajor.Text = string.Empty;
                txtCity.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {
            cbRooms.Items.Add("1001");
            string[] items = { "1002", "1003", "1004", "1005", "1006", "1007", "1008", "1009", "1010", "1011", "1012", "1013", "1014", "1015" };
            cbRooms.Items.AddRange(items);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfamily_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfather_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfiled_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
