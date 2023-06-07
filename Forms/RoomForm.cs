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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        RoomBusiness roomBusiness = new RoomBusiness();
        private void RoomForm_Load(object sender, EventArgs e)
        {
            dgvRoom.DataSource = roomBusiness.GetAll();

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void btnSaveR_Click(object sender, EventArgs e)
        {
            roomBusiness.Add(new Rooms
            {
                RoomName = txtRoomName.Text
            });

            txtRoomName.Clear();
            dgvRoom.DataSource = roomBusiness.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentForm documentForm = new DocumentForm();
            this.Hide();
            documentForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            roomBusiness.Delete(Convert.ToInt32(txtRoomID.Text));
            dgvRoom.DataSource = roomBusiness.GetAll();
        }

        private void dgvRoom_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvRoom.Rows[e.RowIndex];
            txtRoomID.Text = selectedRow.Cells["RoomId"].Value.ToString();
            txtRoomName.Text = selectedRow.Cells["RoomName"].Value.ToString();
        }
    }
}
