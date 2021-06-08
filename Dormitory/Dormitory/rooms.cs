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

namespace Dormitory
{
    public partial class rooms : Form
    {
        public rooms()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            RoomBLL sbll = new RoomBLL();
            dataGridView1.DataSource = sbll.view();
        }
    }
}
