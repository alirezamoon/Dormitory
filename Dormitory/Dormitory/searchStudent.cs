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
    public partial class searchStudent : Form
    {
        public searchStudent()
        {
            InitializeComponent();
        }

        private void txtstno_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Student s = new Student(txtstno.Text);
            StudentBLL sbll = new StudentBLL();
            try
            {
                sbll.Search(s, txtstno.Text);
                dataGridView1.DataSource = sbll.Search(s, txtstno.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }
    }
}
