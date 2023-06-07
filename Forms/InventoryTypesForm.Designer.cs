namespace KücükPrensManagment.Forms
{
    partial class InventoryTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryTypesForm));
            this.btnDeleteT = new System.Windows.Forms.Button();
            this.btnSaveR = new System.Windows.Forms.Button();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.dgvInventoryType = new System.Windows.Forms.DataGridView();
            this.InventoriesTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoriesTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınventoriesTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasDbDataSet = new KücükPrensManagment.DemirbasDbDataSet();
            this.ınventoriesTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrans = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnTypes = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inventoriesTypesTableAdapter = new KücükPrensManagment.DemirbasDbDataSetTableAdapters.InventoriesTypesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınventoriesTypesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınventoriesTypesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteT
            // 
            this.btnDeleteT.BackColor = System.Drawing.Color.White;
            this.btnDeleteT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteT.Location = new System.Drawing.Point(236, 197);
            this.btnDeleteT.Name = "btnDeleteT";
            this.btnDeleteT.Size = new System.Drawing.Size(80, 32);
            this.btnDeleteT.TabIndex = 83;
            this.btnDeleteT.Text = "Sil";
            this.btnDeleteT.UseVisualStyleBackColor = false;
            this.btnDeleteT.Click += new System.EventHandler(this.btnDeleteT_Click);
            // 
            // btnSaveR
            // 
            this.btnSaveR.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveR.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveR.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveR.ForeColor = System.Drawing.Color.White;
            this.btnSaveR.Location = new System.Drawing.Point(236, 155);
            this.btnSaveR.Name = "btnSaveR";
            this.btnSaveR.Size = new System.Drawing.Size(80, 32);
            this.btnSaveR.TabIndex = 82;
            this.btnSaveR.Text = "Kaydet";
            this.btnSaveR.UseVisualStyleBackColor = false;
            this.btnSaveR.Click += new System.EventHandler(this.btnSaveR_Click);
            // 
            // txtTypeID
            // 
            this.txtTypeID.BackColor = System.Drawing.Color.Lavender;
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypeID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTypeID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTypeID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTypeID.Location = new System.Drawing.Point(146, 73);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(176, 19);
            this.txtTypeID.TabIndex = 104;
            this.txtTypeID.Text = "ID";
            // 
            // txtTypeName
            // 
            this.txtTypeName.BackColor = System.Drawing.Color.Lavender;
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypeName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTypeName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTypeName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTypeName.Location = new System.Drawing.Point(146, 115);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(176, 19);
            this.txtTypeName.TabIndex = 105;
            this.txtTypeName.Text = "Demirbaş";
            // 
            // dgvInventoryType
            // 
            this.dgvInventoryType.AllowUserToAddRows = false;
            this.dgvInventoryType.AllowUserToDeleteRows = false;
            this.dgvInventoryType.AutoGenerateColumns = false;
            this.dgvInventoryType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventoryType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInventoryType.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvInventoryType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventoryType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInventoryType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoriesTypeId,
            this.InventoriesTypeName});
            this.dgvInventoryType.DataSource = this.ınventoriesTypesBindingSource1;
            this.dgvInventoryType.GridColor = System.Drawing.Color.Lavender;
            this.dgvInventoryType.Location = new System.Drawing.Point(376, 64);
            this.dgvInventoryType.MultiSelect = false;
            this.dgvInventoryType.Name = "dgvInventoryType";
            this.dgvInventoryType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInventoryType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryType.Size = new System.Drawing.Size(256, 342);
            this.dgvInventoryType.TabIndex = 107;
            this.dgvInventoryType.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventoryType_RowEnter);
            // 
            // InventoriesTypeId
            // 
            this.InventoriesTypeId.DataPropertyName = "InventoriesTypeId";
            this.InventoriesTypeId.HeaderText = "ID";
            this.InventoriesTypeId.Name = "InventoriesTypeId";
            this.InventoriesTypeId.ReadOnly = true;
            this.InventoriesTypeId.Visible = false;
            // 
            // InventoriesTypeName
            // 
            this.InventoriesTypeName.DataPropertyName = "InventoriesTypeName";
            this.InventoriesTypeName.HeaderText = "Demirbaş";
            this.InventoriesTypeName.Name = "InventoriesTypeName";
            // 
            // ınventoriesTypesBindingSource1
            // 
            this.ınventoriesTypesBindingSource1.DataMember = "InventoriesTypes";
            this.ınventoriesTypesBindingSource1.DataSource = this.demirbasDbDataSet;
            // 
            // demirbasDbDataSet
            // 
            this.demirbasDbDataSet.DataSetName = "DemirbasDbDataSet";
            this.demirbasDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ınventoriesTypesBindingSource
            // 
            this.ınventoriesTypesBindingSource.DataMember = "InventoriesTypes";
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
            this.panel1.TabIndex = 115;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(123, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(890, 35);
            this.panel5.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Demirbaş Türleri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(516, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 28);
            this.button1.TabIndex = 44;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(348, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 342);
            this.panel4.TabIndex = 117;
            // 
            // inventoriesTypesTableAdapter
            // 
            this.inventoriesTypesTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 462);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvInventoryType);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.btnDeleteT);
            this.Controls.Add(this.btnSaveR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryTypesForm";
            this.Load += new System.EventHandler(this.InventoryTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınventoriesTypesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınventoriesTypesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteT;
        private System.Windows.Forms.Button btnSaveR;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.DataGridView dgvInventoryType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrans;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnTypes;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        //private Data.DemirbasDbDataSet demirbasDbDataSet;
        private System.Windows.Forms.BindingSource ınventoriesTypesBindingSource;
        //private Data.DemirbasDbDataSetTableAdapters.InventoriesTypesTableAdapter inventoriesTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınventoriesTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınventoriesTypeNameDataGridViewTextBoxColumn;
        private DemirbasDbDataSet demirbasDbDataSet;
        private System.Windows.Forms.BindingSource ınventoriesTypesBindingSource1;
        private DemirbasDbDataSetTableAdapters.InventoriesTypesTableAdapter inventoriesTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoriesTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoriesTypeName;
    }
}