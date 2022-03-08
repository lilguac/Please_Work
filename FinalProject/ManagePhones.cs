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
    public partial class ManagePhones : Form
    {
        public ManagePhones()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Form form = new AssignPhone();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ManagePhones_Load(object sender, EventArgs e)
        {
            txtSerial.Text = "example phone serial";
            txtNeighbor.Text = "neighbor name goes here";
            txtDate.Text = "date issued goes here";
        }
    }
}
