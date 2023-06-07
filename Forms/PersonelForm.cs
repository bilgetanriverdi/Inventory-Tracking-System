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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        PersonnelBusiness personnelBusiness = new PersonnelBusiness();
        BranchBusiness branchBusiness = new BranchBusiness();

        private void BindBranches()
        {
            var branches = branchBusiness.GetAll();
            branches.Insert(0, new Branches
            {
                BranchId = 0,
                BranchName = "Branş"
            });
            comboBrans.DataSource = branches;
            comboBrans.DisplayMember = "BranchName";
            comboBrans.ValueMember = "BranchId";
        }
        private void btnSaveP_Click(object sender, EventArgs e)
        {
            personnelBusiness.Add(new Personnels
            {
                PersonnelFirstName = txtPersonelName.Text,
                PersonnelLastName = txtPersonelSurname.Text,
                BranchId = Convert.ToInt32(comboBrans.SelectedValue)
            });
            txtPersonelName.Clear();
            txtPersonelSurname.Clear();
            comboBrans.Refresh();
            dgvPersonel.DataSource = personnelBusiness.PersonelWithBranch();
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

        private void btnExist_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            personnelBusiness.Delete(Convert.ToInt32(txtPersonelID.Text));
            dgvPersonel.DataSource = personnelBusiness.PersonelWithBranch();
        }

        private void btnUpdateP_Click(object sender, EventArgs e)
        {
            personnelBusiness.Edit(new Personnels
            {
                PersonnelId = Convert.ToInt32(txtPersonelID.Text),
                PersonnelFirstName = txtPersonelName.Text,
                PersonnelLastName = txtPersonelSurname.Text,
                BranchId = Convert.ToInt32(comboBrans.SelectedValue)
            });
            dgvPersonel.DataSource = personnelBusiness.PersonelWithBranch();
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            BindBranches();
            dgvPersonel.DataSource = personnelBusiness.PersonelWithBranch();
        }

        private void dgvPersonel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvPersonel.Rows[e.RowIndex];
            txtPersonelID.Text = selectedRow.Cells["PersonnelId"].Value.ToString();
            txtPersonelName.Text = selectedRow.Cells["PersonnelFirstName"].Value.ToString();
            txtPersonelSurname.Text = selectedRow.Cells["PersonnelLastName"].Value.ToString();
            comboBrans.SelectedValue = selectedRow.Cells["BranchId"].Value;
        }
    }
}
