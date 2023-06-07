namespace KücükPrensManagment.Forms
{
    partial class PersonelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelForm));
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnTypes = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.PersonnelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasDbDataSet = new KücükPrensManagment.DemirbasDbDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrans = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnUpdateP = new System.Windows.Forms.Button();
            this.btnSaveP = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.txtPersonelName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPersonelSurname = new System.Windows.Forms.TextBox();
            this.comboBrans = new System.Windows.Forms.ComboBox();
            this.personnelsTableAdapter = new KücükPrensManagment.DemirbasDbDataSetTableAdapters.PersonnelsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 3);
            this.panel2.TabIndex = 48;
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.AllowUserToAddRows = false;
            this.dgvPersonel.AllowUserToDeleteRows = false;
            this.dgvPersonel.AutoGenerateColumns = false;
            this.dgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPersonel.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvPersonel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonnelId,
            this.PersonnelFirstName,
            this.PersonnelLastName,
            this.BranchId,
            this.BrandName});
            this.dgvPersonel.DataSource = this.personnelsBindingSource;
            this.dgvPersonel.GridColor = System.Drawing.Color.Lavender;
            this.dgvPersonel.Location = new System.Drawing.Point(440, 65);
            this.dgvPersonel.MultiSelect = false;
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonel.Size = new System.Drawing.Size(422, 342);
            this.dgvPersonel.TabIndex = 124;
            this.dgvPersonel.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonel_RowEnter);
            // 
            // PersonnelId
            // 
            this.PersonnelId.DataPropertyName = "PersonnelId";
            this.PersonnelId.HeaderText = "ID";
            this.PersonnelId.Name = "PersonnelId";
            this.PersonnelId.ReadOnly = true;
            this.PersonnelId.Visible = false;
            // 
            // PersonnelFirstName
            // 
            this.PersonnelFirstName.DataPropertyName = "PersonnelFirstName";
            this.PersonnelFirstName.HeaderText = "Ad";
            this.PersonnelFirstName.Name = "PersonnelFirstName";
            this.PersonnelFirstName.ReadOnly = true;
            // 
            // PersonnelLastName
            // 
            this.PersonnelLastName.DataPropertyName = "PersonnelLastName";
            this.PersonnelLastName.HeaderText = "Soyad";
            this.PersonnelLastName.Name = "PersonnelLastName";
            this.PersonnelLastName.ReadOnly = true;
            // 
            // BranchId
            // 
            this.BranchId.DataPropertyName = "BranchId";
            this.BranchId.HeaderText = "BranchId";
            this.BranchId.Name = "BranchId";
            this.BranchId.ReadOnly = true;
            this.BranchId.Visible = false;
            // 
            // BrandName
            // 
            this.BrandName.DataPropertyName = "BranchName";
            this.BrandName.HeaderText = "Branş";
            this.BrandName.Name = "BrandName";
            // 
            // personnelsBindingSource
            // 
            this.personnelsBindingSource.DataMember = "Personnels";
            this.personnelsBindingSource.DataSource = this.demirbasDbDataSet;
            // 
            // demirbasDbDataSet
            // 
            this.demirbasDbDataSet.DataSetName = "DemirbasDbDataSet";
            this.demirbasDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(417, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 342);
            this.panel4.TabIndex = 116;
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
            // txtPersonelID
            // 
            this.txtPersonelID.BackColor = System.Drawing.Color.Lavender;
            this.txtPersonelID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPersonelID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPersonelID.Location = new System.Drawing.Point(143, 70);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(250, 19);
            this.txtPersonelID.TabIndex = 117;
            this.txtPersonelID.Text = "Personel ID";
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
            this.panel1.TabIndex = 114;
            // 
            // btnBrans
            // 
            this.btnBrans.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBrans.FlatAppearance.BorderSize = 0;
            this.btnBrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrans.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrans.ForeColor = System.Drawing.Color.White;
            this.btnBrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrans.Location = new System.Drawing.Point(15, 309);
            this.btnBrans.Name = "btnBrans";
            this.btnBrans.Size = new System.Drawing.Size(59, 31);
            this.btnBrans.TabIndex = 53;
            this.btnBrans.Text = "- Branş";
            this.btnBrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrans.UseVisualStyleBackColor = false;
            this.btnBrans.Click += new System.EventHandler(this.btnBrans_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "Personel Listesi";
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExist.FlatAppearance.BorderSize = 0;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExist.ForeColor = System.Drawing.Color.White;
            this.btnExist.Location = new System.Drawing.Point(751, 1);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(20, 28);
            this.btnExist.TabIndex = 44;
            this.btnExist.Text = "X";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnUpdateP
            // 
            this.btnUpdateP.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateP.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateP.ForeColor = System.Drawing.Color.White;
            this.btnUpdateP.Location = new System.Drawing.Point(133, 219);
            this.btnUpdateP.Name = "btnUpdateP";
            this.btnUpdateP.Size = new System.Drawing.Size(90, 32);
            this.btnUpdateP.TabIndex = 122;
            this.btnUpdateP.Text = "Güncelle";
            this.btnUpdateP.UseVisualStyleBackColor = false;
            this.btnUpdateP.Click += new System.EventHandler(this.btnUpdateP_Click);
            // 
            // btnSaveP
            // 
            this.btnSaveP.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveP.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveP.ForeColor = System.Drawing.Color.White;
            this.btnSaveP.Location = new System.Drawing.Point(314, 219);
            this.btnSaveP.Name = "btnSaveP";
            this.btnSaveP.Size = new System.Drawing.Size(79, 32);
            this.btnSaveP.TabIndex = 121;
            this.btnSaveP.Text = "Kaydet";
            this.btnSaveP.UseVisualStyleBackColor = false;
            this.btnSaveP.Click += new System.EventHandler(this.btnSaveP_Click);
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.BackColor = System.Drawing.Color.White;
            this.btnDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteP.Location = new System.Drawing.Point(229, 219);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(79, 32);
            this.btnDeleteP.TabIndex = 123;
            this.btnDeleteP.Text = "Sil";
            this.btnDeleteP.UseVisualStyleBackColor = false;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // txtPersonelName
            // 
            this.txtPersonelName.BackColor = System.Drawing.Color.Lavender;
            this.txtPersonelName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPersonelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPersonelName.Location = new System.Drawing.Point(143, 102);
            this.txtPersonelName.Name = "txtPersonelName";
            this.txtPersonelName.Size = new System.Drawing.Size(250, 19);
            this.txtPersonelName.TabIndex = 118;
            this.txtPersonelName.Text = "Personel Ad";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnExist);
            this.panel3.Location = new System.Drawing.Point(123, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 35);
            this.panel3.TabIndex = 115;
            // 
            // txtPersonelSurname
            // 
            this.txtPersonelSurname.BackColor = System.Drawing.Color.Lavender;
            this.txtPersonelSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelSurname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPersonelSurname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelSurname.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPersonelSurname.Location = new System.Drawing.Point(143, 135);
            this.txtPersonelSurname.Name = "txtPersonelSurname";
            this.txtPersonelSurname.Size = new System.Drawing.Size(250, 19);
            this.txtPersonelSurname.TabIndex = 126;
            this.txtPersonelSurname.Text = "Personel Soyad";
            // 
            // comboBrans
            // 
            this.comboBrans.BackColor = System.Drawing.Color.Lavender;
            this.comboBrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBrans.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBrans.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBrans.FormattingEnabled = true;
            this.comboBrans.Location = new System.Drawing.Point(143, 166);
            this.comboBrans.Name = "comboBrans";
            this.comboBrans.Size = new System.Drawing.Size(250, 25);
            this.comboBrans.TabIndex = 127;
            this.comboBrans.Text = "Branş";
            // 
            // personnelsTableAdapter
            // 
            this.personnelsTableAdapter.ClearBeforeFill = true;
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 462);
            this.Controls.Add(this.comboBrans);
            this.Controls.Add(this.txtPersonelSurname);
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdateP);
            this.Controls.Add(this.btnSaveP);
            this.Controls.Add(this.btnDeleteP);
            this.Controls.Add(this.txtPersonelName);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelForm";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnTypes;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnUpdateP;
        private System.Windows.Forms.Button btnSaveP;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.TextBox txtPersonelName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPersonelSurname;
        private System.Windows.Forms.Button btnBrans;
        private System.Windows.Forms.ComboBox comboBrans;
        private DemirbasDbDataSet demirbasDbDataSet;
        private System.Windows.Forms.BindingSource personnelsBindingSource;
        private DemirbasDbDataSetTableAdapters.PersonnelsTableAdapter personnelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
    }
}