using KücükPrens.Business.Concrete;
using KücükPrensEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Microsoft.Office.Interop.Excel;
//using excel= Microsoft.Office.Interop.Excel;


namespace KücükPrensManagment.Forms
{
    public partial class InventoryForm : Form
    {

        public InventoryForm()
        {
            InitializeComponent();
        }

        InventoryBusiness inventoryBusiness = new InventoryBusiness();
        InventoryTypeBusiness inventoryTypeBusiness = new InventoryTypeBusiness();
        RoomBusiness roomBusiness = new RoomBusiness();
        PersonnelBusiness personnelBusiness = new PersonnelBusiness();


        private void BindTypes()
        {
            var inventoriesTypes = inventoryTypeBusiness.GetAll();
            inventoriesTypes.Insert(0, new InventoriesTypes
            {
                InventoriesTypeId = 0,
                InventoriesTypeName = "Demirbaş"
            });
            comboTypeD.DataSource = inventoriesTypes;
            comboTypeD.DisplayMember = "InventoriesTypeName";
            comboTypeD.ValueMember = "InventoriesTypeId";
        }

        private void BindRooms()
        {
            var rooms = roomBusiness.GetAll();
            rooms.Insert(0, new Rooms
            {
                RoomId = 0,
                RoomName = "Mahal"
            });
            comboRoom.DataSource = rooms;
            comboRoom.DisplayMember = "RoomName";
            comboRoom.ValueMember = "RoomId";
        }

        private void BindPersonels()
        {
            var personels = personnelBusiness.GetAll();
            personels.Insert(0, new Personnels
            {
                PersonnelId = 0,
                PersonnelFirstName = "Zimmet"
            });
            comboZimmet.DataSource = personels;
            comboZimmet.DisplayMember = "PersonnelFirstName";
            comboZimmet.ValueMember = "PersonnelId";
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

        private void btnExist_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void btnBrans_Click(object sender, EventArgs e)
        {
            BransForm bransForm = new BransForm();
            this.Hide();
            bransForm.Show();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            BindTypes();
            BindRooms();
            BindPersonels();
            dgvDemirbas.DataSource = inventoryBusiness.GetInventory();
        }


        public void btnSaveI_Click(object sender, EventArgs e)
        {
            string InventoryBarkod = txtBarkod.Text;

            // DataGridView üzerinde her bir satırı kontrol et
            foreach (DataGridViewRow row in dgvDemirbas.Rows)
            {
                if (row.Cells["InventoryBarkod"].Value != null && row.Cells["InventoryBarkod"].Value.ToString() == InventoryBarkod)
                {
                    MessageBox.Show("Bu barkod numarasıyla kayıt zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            inventoryBusiness.Add(new Inventories
            {
                InventoriesTypeId = Convert.ToInt32(comboTypeD.SelectedValue),
                InventoryBarkod = txtBarkod.Text,
                RoomId = Convert.ToInt32(comboRoom.SelectedValue),
                PersonnelId = Convert.ToInt32(comboZimmet.SelectedValue)
            });

            comboTypeD.Refresh();
            txtBarkod.Clear();
            comboRoom.Refresh();
            comboZimmet.Refresh();
            dgvDemirbas.DataSource = inventoryBusiness.GetInventory();

        }

        private void btnDeleteI_Click(object sender, EventArgs e)
        {
            inventoryBusiness.Delete(Convert.ToInt32(txtInventoryID.Text));
            dgvDemirbas.DataSource = inventoryBusiness.GetInventory();
        }

        private void btnUpdateI_Click(object sender, EventArgs e)
        {
            inventoryBusiness.Edit(new Inventories
            {
                InventoryId = Convert.ToInt32(txtInventoryID.Text),
                InventoriesTypeId = Convert.ToInt32(comboTypeD.SelectedValue),
                InventoryBarkod = txtBarkod.Text,
                RoomId = Convert.ToInt32(comboRoom.SelectedValue),
                PersonnelId = Convert.ToInt32(comboZimmet.SelectedValue)
            });
            dgvDemirbas.DataSource = inventoryBusiness.GetInventory();
        }

        private void dgvDemirbas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvDemirbas.Rows[e.RowIndex];
            txtInventoryID.Text = selectedRow.Cells["InventoryId"].Value.ToString();
            comboTypeD.SelectedValue = selectedRow.Cells["InventoriesTypeId"].Value;
            txtBarkod.Text = selectedRow.Cells["InventoryBarkod"].Value.ToString();
            comboRoom.SelectedValue = selectedRow.Cells["RoomId"].Value;
            comboZimmet.SelectedValue = selectedRow.Cells["PersonnelId"].Value;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            /* DataTable dt = new DataTable();
             DataView dv = dt.DefaultView;
             dv.RowFilter = "InventoriesTypeName LIKE '" + txtAra.Text + "%'";
             dgvDemirbas.DataSource = dv;*/
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string searchText = txtAra.Text;

            foreach (DataGridViewRow row in dgvDemirbas.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        dgvDemirbas.Rows[row.Index].Selected = true;
                        ScrollToRow(dgvDemirbas, row.Index);
                        return;
                    }
                }
            }

            MessageBox.Show("Aranan kelime bulunamadı.");
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

        private void btnExcel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dgvDemirbas.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[1, i + 1];
                myRange.Value2 = dgvDemirbas.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvDemirbas.Columns.Count; i++)
            {
                for (int j = 0; j < dgvDemirbas.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = dgvDemirbas[i, j].Value;
                }
            }

        }

        private void dgvDemirbas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            /*string newBarcode = dgvDemirbas.Rows[e.RowIndex].Cells["InventoryBarkod"].Value.ToString();

            foreach (DataGridViewRow row in dgvDemirbas.Rows)
            {
                if (row.Index == e.RowIndex) continue;

                string barcode = row.Cells["InventoryBarkod"].Value.ToString();

                if (barcode == newBarcode)
                {
                    MessageBox.Show("Bu barkod numarası zaten kullanımda! Yeni kayıtı silin!");
                    break;
                }
            }*/
        }
    }
}
