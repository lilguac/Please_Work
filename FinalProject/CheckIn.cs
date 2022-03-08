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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            txtAction.Text = "";
            txtCategory.Text = "";
            txtName.Text = "";
            txtTitle.Text = "";
            MessageBox.Show("Person has been checked in");
        }
    }
}
