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
    public partial class EmployeeMainForm : Form
    {
        public EmployeeMainForm()
        {
            InitializeComponent();
        }

        private void EmployeeMainForm_Load(object sender, EventArgs e)
        {

        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            Form frm = new MasterAdmin();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnPgrmMan_Click(object sender, EventArgs e)
        {
            Form frm = new Calendar();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            Form frm = new CaseManagers();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnLeader_Click(object sender, EventArgs e)
        {
            Form frm = new MergeDelete();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            Form frm = new ManagePhones();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// sends to check in gui
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new CheckIn();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Sends to info gui
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Info();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
