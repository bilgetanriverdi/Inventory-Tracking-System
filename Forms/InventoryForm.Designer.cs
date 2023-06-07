namespace KücükPrensManagment.Forms
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.dgvDemirbas = new System.Windows.Forms.DataGridView();
            this.InventoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoriesTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınventoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasDbDataSet = new KücükPrensManagment.DemirbasDbDataSet();
            this.btnUpdateI = new System.Windows.Forms.Button();
            this.btnSaveI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.comboTypeD = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteI = new System.Windows.Forms.Button();
            this.txtInventoryID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrans = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnTypes = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboZimmet = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.inventoriesTableAdapter = new KücükPrensManagment.DemirbasDbDataSetTableAdapters.InventoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemirbas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınventoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDemirbas
            // 
            this.dgvDemirbas.AllowUserToAddRows = false;
            this.dgvDemirbas.AllowUserToDeleteRows = false;
            this.dgvDemirbas.AutoGenerateColumns = false;
            this.dgvDemirbas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDemirbas.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvDemirbas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDemirbas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDemirbas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemirbas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoryId,
            this.InventoriesTypeId,
            this.Column1,
            this.InventoryBarkod,
            this.RoomId,
            this.Column2,
            this.PersonnelId,
            this.Column3});
            this.dgvDemirbas.DataSource = this.ınventoriesBindingSource;
            this.dgvDemirbas.GridColor = System.Drawing.Color.Lavender;
            this.dgvDemirbas.Location = new System.Drawing.Point(440, 93);
            this.dgvDemirbas.MultiSelect = false;
            this.dgvDemirbas.Name = "dgvDemirbas";
            this.dgvDemirbas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDemirbas.Size = new System.Drawing.Size(549, 314);
            this.dgvDemirbas.TabIndex = 112;
            this.dgvDemirbas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDemirbas_CellValidating);
            this.dgvDemirbas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDemirbas_RowEnter);
//            this.dgvDemirbas.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDemirbas_RowValidating);
            // 
            // InventoryId
            // 
            this.InventoryId.DataPropertyName = "InventoryId";
            this.InventoryId.HeaderText = "ID";
            this.InventoryId.Name = "InventoryId";
            this.InventoryId.ReadOnly = true;
            this.InventoryId.Visible = false;
            // 
            // InventoriesTypeId
            // 
            this.InventoriesTypeId.DataPropertyName = "InventoriesTypeId";
            this.InventoriesTypeId.HeaderText = "InventoriesTypeId";
            this.InventoriesTypeId.Name = "InventoriesTypeId";
            this.InventoriesTypeId.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "InventoriesTypeName";
            this.Column1.HeaderText = "Demirbaş";
            this.Column1.Name = "Column1";
            // 
            // InventoryBarkod
            // 
            this.InventoryBarkod.DataPropertyName = "InventoryBarkod";
            this.InventoryBarkod.HeaderText = "Barkod No";
            this.InventoryBarkod.Name = "InventoryBarkod";
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "RoomId";
            this.RoomId.HeaderText = "RoomId";
            this.RoomId.Name = "RoomId";
            this.RoomId.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "RoomName";
            this.Column2.HeaderText = "Mahal";
            this.Column2.Name = "Column2";
            // 
            // PersonnelId
            // 
            this.PersonnelId.DataPropertyName = "PersonnelId";
            this.PersonnelId.HeaderText = "PersonnelId";
            this.PersonnelId.Name = "PersonnelId";
            this.PersonnelId.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PersonnelFirstName";
            this.Column3.HeaderText = "Zimmet Sahibi";
            this.Column3.Name = "Column3";
            // 
            // ınventoriesBindingSource
            // 
            this.ınventoriesBindingSource.DataMember = "Inventories";
            this.ınventoriesBindingSource.DataSource = this.demirbasDbDataSet;
            // 
            // demirbasDbDataSet
            // 
            this.demirbasDbDataSet.DataSetName = "DemirbasDbDataSet";
            this.demirbasDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdateI
            // 
            this.btnUpdateI.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateI.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateI.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateI.ForeColor = System.Drawing.Color.White;
            this.btnUpdateI.Location = new System.Drawing.Point(133, 271);
            this.btnUpdateI.Name = "btnUpdateI";
            this.btnUpdateI.Size = new System.Drawing.Size(83, 32);
            this.btnUpdateI.TabIndex = 110;
            this.btnUpdateI.Text = "Güncelle";
            this.btnUpdateI.UseVisualStyleBackColor = false;
            this.btnUpdateI.Click += new System.EventHandler(this.btnUpdateI_Click);
            // 
            // btnSaveI
            // 
            this.btnSaveI.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveI.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveI.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveI.ForeColor = System.Drawing.Color.White;
            this.btnSaveI.Location = new System.Drawing.Point(310, 271);
            this.btnSaveI.Name = "btnSaveI";
            this.btnSaveI.Size = new System.Drawing.Size(83, 32);
            this.btnSaveI.TabIndex = 109;
            this.btnSaveI.Text = "Kaydet";
            this.btnSaveI.UseVisualStyleBackColor = false;
            this.btnSaveI.Click += new System.EventHandler(this.btnSaveI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "Demirbaş";
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExist.FlatAppearance.BorderSize = 0;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExist.ForeColor = System.Drawing.Color.White;
            this.btnExist.Location = new System.Drawing.Point(863, -2);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(20, 28);
            this.btnExist.TabIndex = 44;
            this.btnExist.Text = "X";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(3, 123);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(86, 31);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Ana Sayfa";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // comboRoom
            // 
            this.comboRoom.BackColor = System.Drawing.Color.Lavender;
            this.comboRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboRoom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboRoom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Location = new System.Drawing.Point(143, 172);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(250, 25);
            this.comboRoom.TabIndex = 106;
            this.comboRoom.Text = "Mahal";
            // 
            // comboTypeD
            // 
            this.comboTypeD.BackColor = System.Drawing.Color.Lavender;
            this.comboTypeD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTypeD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboTypeD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboTypeD.FormattingEnabled = true;
            this.comboTypeD.Location = new System.Drawing.Point(143, 102);
            this.comboTypeD.Name = "comboTypeD";
            this.comboTypeD.Size = new System.Drawing.Size(250, 25);
            this.comboTypeD.TabIndex = 105;
            this.comboTypeD.Text = "Demirbaş";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(417, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 370);
            this.panel4.TabIndex = 102;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 3);
            this.panel2.TabIndex = 48;
            // 
            // btnDeleteI
            // 
            this.btnDeleteI.BackColor = System.Drawing.Color.White;
            this.btnDeleteI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteI.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteI.Location = new System.Drawing.Point(222, 271);
            this.btnDeleteI.Name = "btnDeleteI";
            this.btnDeleteI.Size = new System.Drawing.Size(81, 32);
            this.btnDeleteI.TabIndex = 111;
            this.btnDeleteI.Text = "Sil";
            this.btnDeleteI.UseVisualStyleBackColor = false;
            this.btnDeleteI.Click += new System.EventHandler(this.btnDeleteI_Click);
            // 
            // txtInventoryID
            // 
            this.txtInventoryID.BackColor = System.Drawing.Color.Lavender;
            this.txtInventoryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInventoryID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtInventoryID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInventoryID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtInventoryID.Location = new System.Drawing.Point(143, 70);
            this.txtInventoryID.Name = "txtInventoryID";
            this.txtInventoryID.Size = new System.Drawing.Size(250, 19);
            this.txtInventoryID.TabIndex = 103;
            this.txtInventoryID.Text = "Demirbaş ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnBrans);
            this.panel1.Controls.Add(this.btnPersonel);
            this.panel1.Controls.Add(this.btnTypes);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnArchive);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMain);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 565);
            this.panel1.TabIndex = 100;
            // 
            // btnBrans
            // 
            this.btnBrans.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBrans.FlatAppearance.BorderSize = 0;
            this.btnBrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrans.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrans.ForeColor = System.Drawing.Color.White;
            this.btnBrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrans.Location = new System.Drawing.Point(18, 309);
            this.btnBrans.Name = "btnBrans";
            this.btnBrans.Size = new System.Drawing.Size(57, 31);
            this.btnBrans.TabIndex = 54;
            this.btnBrans.Text = "- Branş";
            this.btnBrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrans.UseVisualStyleBackColor = false;
            this.btnBrans.Click += new System.EventHandler(this.btnBrans_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPersonel.FlatAppearance.BorderSize = 0;
            this.btnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ForeColor = System.Drawing.Color.White;
            this.btnPersonel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonel.Location = new System.Drawing.Point(4, 272);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(98, 31);
            this.btnPersonel.TabIndex = 52;
            this.btnPersonel.Text = "- Personel L.";
            this.btnPersonel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnTypes
            // 
            this.btnTypes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTypes.FlatAppearance.BorderSize = 0;
            this.btnTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTypes.ForeColor = System.Drawing.Color.White;
            this.btnTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypes.Location = new System.Drawing.Point(4, 234);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(86, 31);
            this.btnTypes.TabIndex = 51;
            this.btnTypes.Text = "- D. Türleri";
            this.btnTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTypes.UseVisualStyleBackColor = false;
            this.btnTypes.Click += new System.EventHandler(this.btnTypes_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(4, 197);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(86, 31);
            this.btnInventory.TabIndex = 50;
            this.btnInventory.Text = "Demirbaş";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnArchive.FlatAppearance.BorderSize = 0;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArchive.ForeColor = System.Drawing.Color.White;
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(3, 160);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(86, 31);
            this.btnArchive.TabIndex = 49;
            this.btnArchive.Text = "Fatura";
            this.btnArchive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(18, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // txtBarkod
            // 
            this.txtBarkod.BackColor = System.Drawing.Color.Lavender;
            this.txtBarkod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarkod.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBarkod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkod.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBarkod.Location = new System.Drawing.Point(143, 137);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(250, 19);
            this.txtBarkod.TabIndex = 104;
            this.txtBarkod.Text = "Barkod No";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnExist);
            this.panel3.Location = new System.Drawing.Point(123, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 35);
            this.panel3.TabIndex = 101;
            // 
            // comboZimmet
            // 
            this.comboZimmet.BackColor = System.Drawing.Color.Lavender;
            this.comboZimmet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboZimmet.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboZimmet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboZimmet.FormattingEnabled = true;
            this.comboZimmet.Location = new System.Drawing.Point(143, 212);
            this.comboZimmet.Name = "comboZimmet";
            this.comboZimmet.Size = new System.Drawing.Size(250, 25);
            this.comboZimmet.TabIndex = 113;
            this.comboZimmet.Text = "Zimmet Sahibi";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(726, 65);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(31, 22);
            this.btnAra.TabIndex = 115;
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAra.Location = new System.Drawing.Point(440, 65);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(284, 22);
            this.txtAra.TabIndex = 114;
            this.txtAra.Text = "Ara";
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExcel.Location = new System.Drawing.Point(880, 413);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(109, 37);
            this.btnExcel.TabIndex = 116;
            this.btnExcel.Text = "Excel\'e Aktar";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // inventoriesTableAdapter
            // 
            this.inventoriesTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 462);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.comboZimmet);
            this.Controls.Add(this.dgvDemirbas);
            this.Controls.Add(this.btnUpdateI);
            this.Controls.Add(this.btnSaveI);
            this.Controls.Add(this.comboRoom);
            this.Controls.Add(this.comboTypeD);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnDeleteI);
            this.Controls.Add(this.txtInventoryID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemirbas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınventoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDemirbas;
        private System.Windows.Forms.Button btnUpdateI;
        private System.Windows.Forms.Button btnSaveI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.ComboBox comboTypeD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteI;
        private System.Windows.Forms.TextBox txtInventoryID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTypes;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.ComboBox comboZimmet;
       // private Data.DemirbasDbDataSetTableAdapters.InventoriesTableAdapter inventoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınventoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınventoriesTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınventoryBarkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBrans;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnExcel;
        private DemirbasDbDataSet demirbasDbDataSet;
        private System.Windows.Forms.BindingSource ınventoriesBindingSource;
        private DemirbasDbDataSetTableAdapters.InventoriesTableAdapter inventoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoriesTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoriesTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}