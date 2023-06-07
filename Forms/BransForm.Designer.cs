namespace KücükPrensManagment.Forms
{
    partial class BransForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BransForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBrans = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnTypes = new System.Windows.Forms.Button();
            this.dgvBrans = new System.Windows.Forms.DataGridView();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasDbDataSet = new KücükPrensManagment.DemirbasDbDataSet();
            this.txtBransName = new System.Windows.Forms.TextBox();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBransID = new System.Windows.Forms.TextBox();
            this.btnDeleteB = new System.Windows.Forms.Button();
            this.btnSaveB = new System.Windows.Forms.Button();
            this.branchesTableAdapter = new KücükPrensManagment.DemirbasDbDataSetTableAdapters.BranchesTableAdapter();
            this.btnUpdateB = new System.Windows.Forms.Button();
            this.BranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(348, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 342);
            this.panel4.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Branş Listesi";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(123, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(890, 35);
            this.panel5.TabIndex = 124;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(490, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 28);
            this.button1.TabIndex = 44;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBrans
            // 
            this.btnBrans.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBrans.FlatAppearance.BorderSize = 0;
            this.btnBrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrans.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrans.ForeColor = System.Drawing.Color.White;
            this.btnBrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrans.Location = new System.Drawing.Point(16, 309);
            this.btnBrans.Name = "btnBrans";
            this.btnBrans.Size = new System.Drawing.Size(58, 31);
            this.btnBrans.TabIndex = 53;
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
            // dgvBrans
            // 
            this.dgvBrans.AllowUserToAddRows = false;
            this.dgvBrans.AllowUserToDeleteRows = false;
            this.dgvBrans.AutoGenerateColumns = false;
            this.dgvBrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBrans.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvBrans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BranchId,
            this.BranchName});
            this.dgvBrans.DataSource = this.branchesBindingSource;
            this.dgvBrans.GridColor = System.Drawing.Color.Lavender;
            this.dgvBrans.Location = new System.Drawing.Point(376, 64);
            this.dgvBrans.Name = "dgvBrans";
            this.dgvBrans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrans.Size = new System.Drawing.Size(235, 342);
            this.dgvBrans.TabIndex = 122;
            this.dgvBrans.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrans_RowEnter);
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            this.branchesBindingSource.DataSource = this.demirbasDbDataSet;
            // 
            // demirbasDbDataSet
            // 
            this.demirbasDbDataSet.DataSetName = "DemirbasDbDataSet";
            this.demirbasDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBransName
            // 
            this.txtBransName.BackColor = System.Drawing.Color.Lavender;
            this.txtBransName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBransName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBransName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBransName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBransName.Location = new System.Drawing.Point(146, 115);
            this.txtBransName.Name = "txtBransName";
            this.txtBransName.Size = new System.Drawing.Size(176, 19);
            this.txtBransName.TabIndex = 121;
            this.txtBransName.Text = "Branş Adı";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 3);
            this.panel2.TabIndex = 48;
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
            this.panel1.TabIndex = 123;
            // 
            // txtBransID
            // 
            this.txtBransID.BackColor = System.Drawing.Color.Lavender;
            this.txtBransID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBransID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBransID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBransID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtBransID.Location = new System.Drawing.Point(146, 73);
            this.txtBransID.Name = "txtBransID";
            this.txtBransID.Size = new System.Drawing.Size(176, 19);
            this.txtBransID.TabIndex = 120;
            this.txtBransID.Text = "ID";
            // 
            // btnDeleteB
            // 
            this.btnDeleteB.BackColor = System.Drawing.Color.White;
            this.btnDeleteB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteB.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteB.Location = new System.Drawing.Point(222, 197);
            this.btnDeleteB.Name = "btnDeleteB";
            this.btnDeleteB.Size = new System.Drawing.Size(94, 32);
            this.btnDeleteB.TabIndex = 119;
            this.btnDeleteB.Text = "Sil";
            this.btnDeleteB.UseVisualStyleBackColor = false;
            this.btnDeleteB.Click += new System.EventHandler(this.btnDeleteB_Click);
            // 
            // btnSaveB
            // 
            this.btnSaveB.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveB.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveB.ForeColor = System.Drawing.Color.White;
            this.btnSaveB.Location = new System.Drawing.Point(222, 155);
            this.btnSaveB.Name = "btnSaveB";
            this.btnSaveB.Size = new System.Drawing.Size(94, 32);
            this.btnSaveB.TabIndex = 118;
            this.btnSaveB.Text = "Kaydet";
            this.btnSaveB.UseVisualStyleBackColor = false;
            this.btnSaveB.Click += new System.EventHandler(this.btnSaveB_Click);
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdateB
            // 
            this.btnUpdateB.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateB.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateB.ForeColor = System.Drawing.Color.White;
            this.btnUpdateB.Location = new System.Drawing.Point(222, 238);
            this.btnUpdateB.Name = "btnUpdateB";
            this.btnUpdateB.Size = new System.Drawing.Size(94, 32);
            this.btnUpdateB.TabIndex = 126;
            this.btnUpdateB.Text = "Güncelle";
            this.btnUpdateB.UseVisualStyleBackColor = false;
            this.btnUpdateB.Click += new System.EventHandler(this.btnUpdateB_Click);
            // 
            // BranchId
            // 
            this.BranchId.DataPropertyName = "BranchId";
            this.BranchId.HeaderText = "ID";
            this.BranchId.Name = "BranchId";
            this.BranchId.ReadOnly = true;
            this.BranchId.Visible = false;
            // 
            // BranchName
            // 
            this.BranchName.DataPropertyName = "BranchName";
            this.BranchName.HeaderText = "Branş Adı";
            this.BranchName.Name = "BranchName";
            // 
            // BransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 462);
            this.Controls.Add(this.btnUpdateB);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvBrans);
            this.Controls.Add(this.txtBransName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBransID);
            this.Controls.Add(this.btnDeleteB);
            this.Controls.Add(this.btnSaveB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BransForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BransForm";
            this.Load += new System.EventHandler(this.BransForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBrans;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnTypes;
        private System.Windows.Forms.DataGridView dgvBrans;
        private System.Windows.Forms.TextBox txtBransName;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBransID;
        private System.Windows.Forms.Button btnDeleteB;
        private System.Windows.Forms.Button btnSaveB;
        private DemirbasDbDataSet demirbasDbDataSet;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private DemirbasDbDataSetTableAdapters.BranchesTableAdapter branchesTableAdapter;
        private System.Windows.Forms.Button btnUpdateB;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
    }
}