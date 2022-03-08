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
    public partial class CreateGoals : Form
    {
        public CreateGoals()
        {
            InitializeComponent();
            cmbRewards.Items.Add("");
            cmbRewards.Items.Add("name");
            cmbRewards.Items.Add("reward");
            cmbRewards.Items.Add("another one");
            cmbRewards.Items.Add("example");
        }

        private void btnGoal_Click(object sender, EventArgs e)
        {
            string goal = txtGoal.Text;
            txtGoals.Text += goal;
            txtGoals.Text += "\r\n";
            txtGoal.Text = "";
        }

        private void txtGoals_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goals and Rewards have been added to Neighbor's Goals");
            txtGoal.Text = "";
            txtGoals.Text = "";
            txtRewards.Text = "";
            cmbRewards.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var obj = openFileDialog1.FileName;
            txtRewards.Text += obj.ToString();
        }

        private void btnReward_Click(object sender, EventArgs e)
        {
            txtRewards.Text += cmbRewards.Text;
            txtRewards.Text += "\r\n";
        }
    }
}
