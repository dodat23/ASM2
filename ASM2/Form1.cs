using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            string username = txtuser.Text.Trim();
            string password = txtpass.Text.Trim();

          
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
          
            
            Form2 mainForm = new Form2();
            mainForm.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult check_Exit = MessageBox.Show("Do you want exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check_Exit == DialogResult.Yes)
            {
                this.Close();
            }

        }

    }
}
