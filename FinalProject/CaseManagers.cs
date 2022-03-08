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
    public partial class CaseManagers : Form
    {
        public CaseManagers()
        {
            InitializeComponent();
        }

        private void CaseManagers_Load(object sender, EventArgs e)
        {
            btnGoals.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null && txtName != null)
            {
                txtName.Text = "";
                txtID.Text = "";
                txtNotes.Text = "";
                MessageBox.Show("Notes have been added to database");
                btnGoals.Enabled = true;
            }
        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CreateGoals();
            form.ShowDialog();
            this.Show();
        }
    }
}
