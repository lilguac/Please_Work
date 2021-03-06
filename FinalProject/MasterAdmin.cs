using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MasterAdmin : Form
    {
        public MasterAdmin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roles will be added to employee/volunteer");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roles will be removed from employee/volunteer");
        }
    }
}
