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
    public partial class MergeDelete : Form
    {
        public MergeDelete()
        {
            InitializeComponent();
        }

        private void MergeDelete_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new Add();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var form = new Delete();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
