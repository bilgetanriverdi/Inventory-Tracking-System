using KücükPrens.Business.Concrete;
using KücükPrensEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KücükPrensManagment.Forms
{
    public partial class BransForm : Form
    {
        public BransForm()
        {
            InitializeComponent();
        }

        BranchBusiness branchBusiness = new BranchBusiness();
        private void btnSaveB_Click(object sender, EventArgs e)
        {
            branchBusiness.Add(new Branches
            {
                BranchName = txtBransName.Text
            });

            txtBransName.Clear();
            dgvBrans.DataSource = branchBusiness.GetAll();
        }

        private void BransForm_Load(object sender, EventArgs e)
        {
            dgvBrans.DataSource = branchBusiness.GetAll();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DocumentForm documentForm = new DocumentForm();
            this.Hide();
            documentForm.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            this.Hide();
            inventoryForm.Show();
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            InventoryTypesForm inventoryTypesForm = new InventoryTypesForm();
            this.Hide();
            inventoryTypesForm.Show();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            PersonelForm personelForm = new PersonelForm();
            this.Hide();
            personelForm.Show();
        }

        private void btnBrans_Click(object sender, EventArgs e)
        {
            BransForm bransForm = new BransForm();
            this.Hide();
            bransForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            branchBusiness.Delete(Convert.ToInt32(txtBransID.Text));
            dgvBrans.DataSource = branchBusiness.GetAll();
        }

        private void dgvBrans_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvBrans.Rows[e.RowIndex];
            txtBransID.Text = selectedRow.Cells["BranchId"].Value.ToString();
            txtBransName.Text = selectedRow.Cells["BranchName"].Value.ToString();
        }

        private void btnUpdateB_Click(object sender, EventArgs e)
        {
            branchBusiness.Edit(new Branches
            {
                BranchId = Convert.ToInt32(txtBransID.Text),
                BranchName = txtBransName.Text
            });
            dgvBrans.DataSource = branchBusiness.GetAll();
        }
    }
}
