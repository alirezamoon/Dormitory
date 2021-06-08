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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "1234")
            {

                main form = new main();
                form.ShowDialog();
            }
            else
                MessageBox.Show("اطلاعات وارد شده اشتباه است", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
