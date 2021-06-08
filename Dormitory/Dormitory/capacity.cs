using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryBO;
using DormitoryBLL;

namespace Dormitory.Forms
{
    public partial class CapacityForm : Form
    {
        public CapacityForm()
        {
            InitializeComponent();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CapacityForm_Load(object sender, EventArgs e)
        {
            StudentBLL sbll = new StudentBLL();
            int n = sbll.Capacity();
            int m = sbll.AvailableCapacity();
            txtcap.Text = Convert.ToString(n);
            txtsaken.Text = Convert.ToString(n-m);
            //-----------------------------------------
            txtempty.Text = Convert.ToString(m);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //StudentBLL sbll = new StudentBLL();
            //int n = sbll.Capacity();
            //txtcapa.Text = Convert.ToString(n);
            //try
            //{
            //    int n = sbll.Capacity();
            //    txtcapa.Text =  n.ToString();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void lblcap_Click(object sender, EventArgs e)
        {
            //StudentBLL sbll = new StudentBLL();
            //int n = sbll.Capacity();
            //lblcap.Text = Convert.ToString(n);
        }

        private void lblsaken_Click(object sender, EventArgs e)
        {

        }

        private void txtcap_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Txtempty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
