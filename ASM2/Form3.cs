using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASM2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void SetBillInformation(string name, string phone, string customerType, 
            string waterLastMonth, string waterThisMonth, string waterUsed, string totalAmount)
        {
            // Gán giá trị cho các TextBox
            txtname.Text = name;
            txtphone.Text = phone;
            txttype.Text = customerType;
            txtlast.Text = waterLastMonth;
            txtthis.Text = waterThisMonth;
            txtused.Text = waterUsed;
            txttotal.Text = totalAmount;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            // Đóng Form3
            this.Close();
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
