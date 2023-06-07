using KücükPrens.Business.Concrete;
using KücükPrensEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KücükPrensManagment.Forms
{
    public partial class DocumentForm : Form
    {
        public DocumentForm()
        {
            InitializeComponent();
        }

        DocumentBusiness documentBusiness = new DocumentBusiness(); 
        InventoryTypeBusiness inventoryTypeBusiness = new InventoryTypeBusiness();

        private void BindTypes()
        {
            var inventoriesTypes = inventoryTypeBusiness.GetAll();
            inventoriesTypes.Insert(0, new InventoriesTypes
            {
                InventoriesTypeId = 0,
                InventoriesTypeName = "Demirbaş"
            });
            comboType.DataSource = inventoriesTypes;
            comboType.DisplayMember = "InventoriesTypeName";
            comboType.ValueMember = "InventoriesTypeId";
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

        private void btnDemirbas_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            this.Hide();
            inventoryForm.Show();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void DocumentForm_Load(object sender, EventArgs e)
        {
            BindTypes();
            dgvFatura.DataSource = documentBusiness.GetDocuments();
        }

        private void btnUpdateF_Click(object sender, EventArgs e)
        {
            documentBusiness.Edit(new Documents
            {
                DocumentId = Convert.ToInt32(txtFaturaID.Text),
                InventoriesTypeId = Convert.ToInt32(comboType.SelectedValue),
                DocumentsDate = dateTime.Value,
                DocumentPrice = Convert.ToInt32(txtPrice.Text),
                DocumentCompany = txtCompany.Text
            });
            dgvFatura.DataSource = documentBusiness.GetDocuments();
        }

        private void btnSaveF_Click(object sender, EventArgs e)
        {
            documentBusiness.Add(new Documents
            {
                InventoriesTypeId = Convert.ToInt32(comboType.SelectedValue),
                DocumentsDate = dateTime.Value,
                DocumentPrice = Convert.ToInt32(txtPrice.Text),
                DocumentCompany = txtCompany.Text

            });

            comboType.Refresh();
            dateTime.Refresh();
            txtPrice.Clear();
            txtCompany.Clear();
            dgvFatura.DataSource = documentBusiness.GetDocuments();
        }

        private void btnDeleteF_Click(object sender, EventArgs e)
        {
            documentBusiness.Delete(Convert.ToInt32(txtFaturaID.Text));
            dgvFatura.DataSource = documentBusiness.GetDocuments();
        }

        private void dgvFatura_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvFatura.Rows[e.RowIndex];
            txtFaturaID.Text = selectedRow.Cells["DocumentId"].Value.ToString();
            comboType.SelectedValue = selectedRow.Cells["InventoriesTypeId"].Value;
            txtPrice.Text = selectedRow.Cells["DocumentPrice"].Value.ToString();
            txtCompany.Text = selectedRow.Cells["DocumentCompany"].Value.ToString();
        }

        private void ScrollToRow(DataGridView dataGridView, int rowIndex)
        {
            if (dataGridView.Rows.Count == 0)
                return;

            if (rowIndex < 0 || rowIndex >= dataGridView.Rows.Count)
                throw new ArgumentOutOfRangeException("rowIndex", "Row index is out of range.");

            // Scroll to the desired row
            dataGridView.FirstDisplayedScrollingRowIndex = rowIndex;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;

            foreach (DataGridViewRow row in dgvFatura.Rows)
              {
                  foreach (DataGridViewCell cell in row.Cells)
                  {
                      if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                     {
                        dgvFatura.Rows[row.Index].Selected = true;
                        ScrollToRow(dgvFatura, row.Index);
                        return;
                     }
                  }
              }

             MessageBox.Show("Aranan kelime bulunamadı.");
        }

    }
}
