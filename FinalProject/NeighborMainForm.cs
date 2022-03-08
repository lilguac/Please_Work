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
    public partial class NeighborMainForm : Form
    {
        public NeighborMainForm()
        {
            InitializeComponent();
        }

        private void NeighborMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            Form frm = new Tracking();
            frm.Show();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Form frm = new Contact();
            frm.Show();
        }
    }
}
