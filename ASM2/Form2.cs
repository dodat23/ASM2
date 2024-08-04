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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Chế độ view để hiển thị trên ListView
            lvcustomer.View = View.Details;
            lvcustomer.GridLines = true;
            lvcustomer.FullRowSelect = true;

            lvcustomer.Columns.Add("Name", 150);
            lvcustomer.Columns.Add("Phone", 150);
            lvcustomer.Columns.Add("Customer type", 200);
            lvcustomer.Columns.Add("Number of people", 100);
            lvcustomer.Columns.Add("Last month", 110);
            lvcustomer.Columns.Add("This month", 110);
            lvcustomer.Columns.Add("Total payment(rental include)", 150);

            ListViewItem item = new ListViewItem("");

            this.cbbtype.SelectedIndexChanged += new System.EventHandler(this.cbbtype_SelectedIndexChanged);
        }

        // Sự kiện btnadd_Click
        private void btnadd_Click(object sender, EventArgs e)
        {
            string Name = txtname.Text;
            string Phone = txtphone.Text;
            string Lastmonth = txtlast.Text;
            string Thismonth = txtthis.Text;
            string People = txtnum.Text;

            string Menu = null;
            if (cbbtype.SelectedIndex == 0)
            {
                Menu = "Household customer";
            }
            else if (cbbtype.SelectedIndex == 1)
            {
                Menu = "Administrative agency, public services";
            }
            else if (cbbtype.SelectedIndex == 2)
            {
                Menu = "Production units";
            }
            else if (cbbtype.SelectedIndex == 3)
            {
                Menu = "Business services";
            }

            double lastMonth, thisMonth;

            string Lastmonth1 = txtlast.Text.Trim().Replace(",", "");
            if (!double.TryParse(Lastmonth1, out lastMonth))
            {
                MessageBox.Show("Please enter a valid number for Last month's water meter.", "Notice",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtlast.Focus();
                return;
            }

            string thisMonthText = txtthis.Text.Trim().Replace(",", "");
            if (!double.TryParse(thisMonthText, out thisMonth))
            {
                MessageBox.Show("Please enter a valid number for This month's water meter.", "Notice",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtthis.Focus();
                return;
            }

            if (lastMonth > thisMonth)
            {
                MessageBox.Show("Last month's index cannot be greater than this month's index, Please again.", "Notice",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtthis.Focus();
                return;
            }

            double waterUsed = thisMonth - lastMonth;
            double totalAmount = 0;
            double environmentalTax = 0;
            double VAT = 0;
            double grandTotal = 0;
            double total = 0;
            double Pretaxcost = 0;

            switch (cbbtype.SelectedIndex)
            {
                case 0: // Household customer
                    {
                        double people;
                        string PeopleText = txtnum.Text.Trim().Replace(",", "");
                        if (!double.TryParse(PeopleText, out people))
                        {
                            MessageBox.Show("Please enter a valid number for number of people.", "Notice",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtnum.Focus();
                            return;
                        }

                        double cubicMetersPerPerson = waterUsed / people;
                        double remainingCubicMeters = cubicMetersPerPerson;
                        double[] waterPrices = { 5.973, 7.052, 8.699, 15.929 };

                        for (int i = 0; i < 3 && remainingCubicMeters > 0; i++)
                        {
                            double currentCubicMeters = Math.Min(10, remainingCubicMeters);
                            totalAmount += currentCubicMeters * waterPrices[i];
                            remainingCubicMeters -= currentCubicMeters;
                        }

                        if (remainingCubicMeters > 0)
                        {
                            totalAmount += remainingCubicMeters * waterPrices[3];
                        }

                        total = totalAmount * people;
                        Pretaxcost = total;
                        environmentalTax = Pretaxcost / 10;
                        VAT = (Pretaxcost + environmentalTax) / 10;
                        grandTotal = VAT + environmentalTax + Pretaxcost;

                        break;
                    }

                case 1: // Administrative agency, public services
                    totalAmount = waterUsed * 9.955;
                    Pretaxcost = totalAmount;
                    environmentalTax = totalAmount / 10;
                    VAT = (totalAmount + environmentalTax) / 10;
                    grandTotal = VAT + environmentalTax + totalAmount;
                    break;

                case 2: // Production units
                    totalAmount = waterUsed * 11.615;
                    Pretaxcost = totalAmount;
                    environmentalTax = totalAmount / 10;
                    VAT = (totalAmount + environmentalTax) / 10;
                    grandTotal = VAT + environmentalTax + totalAmount;
                    break;

                case 3: // Business services
                    totalAmount = waterUsed * 22.068;
                    Pretaxcost = totalAmount;
                    environmentalTax = totalAmount / 10;
                    VAT = (totalAmount + environmentalTax) / 10;
                    grandTotal = VAT + environmentalTax + totalAmount;
                    break;
            }

            ListViewItem item;

            // Kiểm tra nếu đang sửa đổi một mục hiện có
            if (btnadd.Tag != null)
            {
                // Lấy mục đang được chỉnh sửa từ Tag của nút Add
                item = (ListViewItem)btnadd.Tag;

                // Cập nhật thông tin của mục đang chỉnh sửa
                item.Text = Name;
                item.SubItems[1].Text = Phone;
                item.SubItems[2].Text = Menu;
                item.SubItems[3].Text = People;
                item.SubItems[4].Text = lastMonth.ToString();
                item.SubItems[5].Text = thisMonth.ToString();
                item.SubItems[6].Text = grandTotal.ToString("#,#.000"); // Số tiền tổng bao gồm thuế và phí

                // Xóa Tag sau khi cập nhật
                btnadd.Tag = null;
            }
            else
            {
                // Nếu không có mục nào đang được chỉnh sửa, thêm một mục mới
                item = new ListViewItem();
                item.Text = Name;
                item.SubItems.Add(Phone);
                item.SubItems.Add(Menu);
                item.SubItems.Add(People);
                item.SubItems.Add(lastMonth.ToString());
                item.SubItems.Add(thisMonth.ToString());
                item.SubItems.Add(grandTotal.ToString("#,#.000")); // Số tiền tổng bao gồm thuế và phí

                lvcustomer.Items.Add(item);
            }

            // Cập nhật txttotal và txtdscre
            txttotal.Text = grandTotal.ToString("#,#.000");
            txtdscre.Text = "Note: The amount includes environmental tax and VAT.";

            // Gọi phương thức UpdateWaterUsage để cập nhật txtused
            UpdateWaterUsage();

            // Làm sạch các TextBox sau khi thêm hoặc cập nhật
            txtname.Clear();
            txtphone.Clear();
            cbbtype.SelectedIndex = -1;
            txtnum.Clear();
            txtlast.Clear();
            txtthis.Clear();
        }
        private void UpdateWaterUsage()
        {
            // Logic tính toán số nước đã sử dụng và cập nhật txtused
            if (double.TryParse(txtlast.Text.Trim(), out double lastMonth) &&
                double.TryParse(txtthis.Text.Trim(), out double thisMonth))
            {
                double waterUsed = thisMonth - lastMonth;
                if (waterUsed >= 0)
                {
                    txtused.Text = waterUsed.ToString("#,##0.##");
                }
                else
                {
                    txtused.Text = "Invalid";
                }
            }
            else
            {
                txtused.Text = "Invalid";
            }
        }




        private void cbbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtype.SelectedIndex == 0) // Household customer
            {
                txtnum.Enabled = true;
            }
            else
            {
                txtnum.Enabled = false;
                txtnum.Clear();
            }
        }

        private void lvcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvcustomer.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvcustomer.SelectedItems[0];
                txtname.Text = selectedItem.Text;
                txtphone.Text = selectedItem.SubItems[1].Text;

                string Menu = selectedItem.SubItems[2].Text;
                if (Menu == "Household customer")
                {
                    cbbtype.SelectedIndex = 0;
                }
                else if (Menu == "Administrative agency, public services")
                {
                    cbbtype.SelectedIndex = 1;
                }
                else if (Menu == "Production units")
                {
                    cbbtype.SelectedIndex = 2;
                }
                else if (Menu == "Business services")
                {
                    cbbtype.SelectedIndex = 3;
                }
                txtnum.Text = selectedItem.SubItems[3].Text;
                txtlast.Text = selectedItem.SubItems[4].Text;
                txtthis.Text = selectedItem.SubItems[5].Text;
            }
        }
        

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbtype_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtlast_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào đang được chọn không
            if (lvcustomer.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                ListViewItem selectedItem = lvcustomer.SelectedItems[0];

                // Điền thông tin từ mục được chọn vào các TextBox để người dùng chỉnh sửa
                txtname.Text = selectedItem.Text;
                txtphone.Text = selectedItem.SubItems[1].Text;
                // Chọn giá trị phù hợp trong ComboBox
                string customerType = selectedItem.SubItems[2].Text;
                if (customerType == "Household customer")
                {
                    cbbtype.SelectedIndex = 0;
                }
                else if (customerType == "Administrative agency, public services")
                {
                    cbbtype.SelectedIndex = 1;
                }
                else if (customerType == "Production units")
                {
                    cbbtype.SelectedIndex = 2;
                }
                else if (customerType == "Business services")
                {
                    cbbtype.SelectedIndex = 3;
                }

                txtnum.Text = selectedItem.SubItems[3].Text;
                txtlast.Text = selectedItem.SubItems[4].Text;
                txtthis.Text = selectedItem.SubItems[5].Text;
                // Đánh dấu trạng thái đang chỉnh sửa
                btnadd.Tag = selectedItem; // Lưu trữ mục được chọn để sử dụng trong btnadd_Click
                txttotal.Text = selectedItem.SubItems[6].Text; // Cập nhật giá trị tổng số tiền
                txtdscre.Text = "Note: The amount includes environmental tax and VAT."; // Ghi chú
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các thông tin trong các TextBox và ComboBox
            txtname.Clear();
            txtphone.Clear();
            txtnum.Clear();
            txtlast.Clear();
            txtthis.Clear();
            txttotal.Clear();
            txtdscre.Clear();

            // Đặt lại ComboBox về trạng thái không chọn
            cbbtype.SelectedIndex = -1;

            // Đảm bảo các TextBox không cho phép nhập dữ liệu
            txtused.ReadOnly = true;
            txttotal.ReadOnly = true;
            txtdscre.ReadOnly = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào đang được chọn không
            if (lvcustomer.SelectedItems.Count > 0)
            {
                // Xóa mục đang được chọn
                foreach (ListViewItem item in lvcustomer.SelectedItems)
                {
                    lvcustomer.Items.Remove(item);
                }

                // Cập nhật các trường nhập liệu để làm sạch sau khi xóa
                txtname.Clear();
                txtphone.Clear();
                txtnum.Clear();
                txtlast.Clear();
                txtthis.Clear();
                txttotal.Clear();
                txtdscre.Clear();
                cbbtype.SelectedIndex = -1;

                // Đảm bảo các TextBox không cho phép nhập dữ liệu
                txtused.ReadOnly = true;
                txttotal.ReadOnly = true;
                txtdscre.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnprin_Click(object sender, EventArgs e)
        {
            // Tạo instance của Form3
            Form3 form3 = new Form3();

            // Lấy thông tin từ các TextBox trong Form2
            string name = txtname.Text;
            string phone = txtphone.Text;
            string customerType = cbbtype.SelectedItem?.ToString() ?? "";
            string waterLastMonth = txtlast.Text;
            string waterThisMonth = txtthis.Text;
            string waterUsed = txtused.Text;
            string totalAmount = txttotal.Text; // Tổng số tiền bao gồm thuế và phí

            // Gọi phương thức SetBillInformation trên Form3
            form3.SetBillInformation(name, phone, customerType, waterLastMonth, waterThisMonth, waterUsed, totalAmount);

            // Hiển thị Form3
            form3.ShowDialog(); // Hiển thị Form3 như một hộp thoại

            // Nếu cần ẩn Form2 sau khi mở Form3
            //this.Hide();
        }

    }

}

