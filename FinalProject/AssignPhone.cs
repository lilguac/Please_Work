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
    public partial class AssignPhone : Form
    {
        public AssignPhone()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            txtDate.Text = "";
            txtID.Text = "";
            txtNeighbor.Text = "";
            txtSerial.Text = "";
            MessageBox.Show("Information sent to database");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
