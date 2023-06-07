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
    public partial class InventoryTypesForm : Form
    {
        public InventoryTypesForm()
        {
            InitializeComponent();
        }

        InventoryTypeBusiness inventoryTypeBusiness = new InventoryTypeBusiness();
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

        private void btnSaveR_Click(object sender, EventArgs e)
        {
            inventoryTypeBusiness.Add(new InventoriesTypes
            {
                InventoriesTypeName = txtTypeName.Text
            });

            txtTypeName.Clear();
            dgvInventoryType.DataSource = inventoryTypeBusiness.GetAll();
        }

        private void btnDeleteT_Click(object sender, EventArgs e)
        {
            inventoryTypeBusiness.Delete(Convert.ToInt32(txtTypeID.Text));
            dgvInventoryType.DataSource = inventoryTypeBusiness.GetAll();
        }

        private void dgvInventoryType_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvInventoryType.Rows[e.RowIndex];
            txtTypeID.Text = selectedRow.Cells["InventoriesTypeId"].Value.ToString();
            txtTypeName.Text = selectedRow.Cells["InventoriesTypeName"].Value.ToString();
        }

        private void InventoryTypesForm_Load(object sender, EventArgs e)
        {
            dgvInventoryType.DataSource = inventoryTypeBusiness.GetAll();
        }
    }
}
