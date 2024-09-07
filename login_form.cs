using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_Sysytem
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            Manager_form main = new Manager_form();
           //var confirmResult = MessageBox.Show("Are you sure to delete this item ??","Confirm Delete!!",MessageBoxButtons.YesNo);
            main.Show();
            this.Hide();
            
        }
    }
}
