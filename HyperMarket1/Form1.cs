using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperMarket1
{
    public partial class AdminForm : Form
    {
        Manager manager = new Manager();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CashierButton_Click(object sender, EventArgs e)
        {
            CashierPanel.Show();
            CategoryPanel.Hide();
            BillPanel.Hide();
            ReportPanel.Hide();
            SupplierPanel.Hide();

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CashierPanel.Hide();
            CategoryPanel.Show();
            BillPanel.Hide();
            ReportPanel.Hide();
            SupplierPanel.Hide();
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            CashierPanel.Hide();
            CategoryPanel.Hide();
            BillPanel.Show();
            ReportPanel.Hide();
            SupplierPanel.Hide();
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            CashierPanel.Hide();
            CategoryPanel.Hide();
            BillPanel.Hide();
            ReportPanel.Hide();
            SupplierPanel.Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            CashierPanel.Hide();
            CategoryPanel.Hide();
            BillPanel.Hide();
            ReportPanel.Show();
            SupplierPanel.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void SupplierPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {

        }
         
        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {

        }

        private void BillPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CashierAddButton_Click(object sender, EventArgs e)
        {
            if (CashierNameTxtBox.Text != "" && CashierPwdTxtBox.Text != "" &&
               CashierUsrNameTxtBox.Text != "" && CashierSalaryTxtBox.Text != "" &&
                CashierPhoneNumber.Text != "" && CahshierWorkingHourTxtBox.Text != "")
            {
                List<String> CashierPhones = new List<String>();
                CashierPhones = CashierPhoneNumber.Text.Split('\n').ToList();
                Cashier cashier = new Cashier(CashierNameTxtBox.Text, CashierUsrNameTxtBox.Text, CashierPwdTxtBox.Text, int.Parse(CahshierWorkingHourTxtBox.Text), CashierPhones, float.Parse(CashierSalaryTxtBox.Text));
                CashierIdTxtBox.Text = cashier.ID.ToString();
                manager.AddCashier(cashier);
            }
            CashierDataGridView.DataSource = Market.market.Cashiers;
        }
    }
}
