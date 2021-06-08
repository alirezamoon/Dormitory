using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryBLL;
using DormitoryBO;
namespace Dormitory
{
    public partial class updateStudent : Form
    {
        public updateStudent()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string stuID = txtStno.Text;
            string major = txtMajor.Text;
            string city = txtCity.Text;
            string roomID = txtRoom.Text;
            Student S = new Student(fname, lname, stuID, major, city, roomID);
            StudentBLL sBLL = new StudentBLL();
            try
            {
                sBLL.Edit(S, txtStno.Text);
                MessageBox.Show("اطلاعات بروزرسانی شد", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFname.Text = string.Empty;
                txtLname.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtMajor.Text = string.Empty;
                txtStno.Text = string.Empty;
                txtRoom.Text = string.Empty;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // throw;
            }





            //EditStudent a = new EditStudent();
            //a.
            //Student s = new Student(txtstno.Text);
            //StudentBLL sbll = new StudentBLL();
            //try
            //{
            //    sbll.Edit(s, txtstno.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    throw;
            //}

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Student s = new Student(txtstnosearch.Text);
            StudentBLL sbll = new StudentBLL();
            try
            {

                sbll.Search(s, txtstnosearch.Text);

                dataGridView1.DataSource = sbll.Search(s, txtstnosearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

            txtFname.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["FirstName"].Value);
            txtLname.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["LastName"].Value);
            txtStno.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["stuID"].Value);
            txtMajor.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Major"].Value);
            txtCity.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["City"].Value);
            txtRoom.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["roomid"].Value);


            //txtname.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
            //txtname.Text = dataGridView1.Rows[1].Cells["index"].Value;
            //txtname.Text = "";


            //    Student s = new Student(txtstnosearch.Text);
            //    StudentBLL sbll = new StudentBLL();
            //    try
            //    {
            //        sbll.Search(s, txtstno.Text);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        throw;
            //    }
            //}

        }

        private void txtstnosearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
