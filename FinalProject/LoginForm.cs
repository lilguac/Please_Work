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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "employee" && txtPassword.Text == "12345")
            {
                var Mainform = new EmployeeMainForm();
                this.Hide();
                Mainform.ShowDialog();
                this.Close();
            }
            else if(txtUser.Text == "neighbor" && txtPassword.Text == "225963")
            {
                var Mainform = new NeighborMainForm();
                this.Hide();
                Mainform.ShowDialog();
                this.Close();
            }
        }
    }
}
