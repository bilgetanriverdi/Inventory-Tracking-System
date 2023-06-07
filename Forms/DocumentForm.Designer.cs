namespace KücükPrensManagment.Forms
{
    partial class DocumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentForm));
            this.dgvFatura = new System.Windows.Forms.DataGridView();
            this.DocumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoriesTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasDbDataSet = new KücükPrensManagment.DemirbasDbDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdateF = new System.Windows.Forms.Button();
            this.btnSaveF = new System.Windows.Forms.Button();
            this.btnDeleteF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFaturaID = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.btnDemirbas = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExist = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.documentsTableAdapter = new KücükPrensManagment.DemirbasDbDataSetTableAdapters.DocumentsTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFatura
            // 
            this.dgvFatura.AllowUserToAddRows = false;
            this.dgvFatura.AllowUserToDeleteRows = false;
            this.dgvFatura.AutoGenerateColumns = false;
            this.dgvFatura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFatura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvFatura.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvFatura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFatura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocumentId,
            this.Column1,
            this.InventoriesTypeId,
            this.DocumentsDate,
            this.DocumentPrice,
            this.DocumentCompany});
            this.dgvFatura.DataSource = this.documentsBindingSource;
            this.dgvFatura.GridColor = System.Drawing.Color.Lavender;
            this.dgvFatura.Location = new System.Drawing.Point(434, 85);
            this.dgvFatura.MultiSelect = false;
            this.dgvFatura.Name = "dgvFatura";
            this.dgvFatura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFatura.Size = new System.Drawing.Size(406, 314);
            this.dgvFatura.TabIndex = 122;
            this.dgvFatura.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFatura_RowEnter);
            // 
            // DocumentId
            // 
            this.DocumentId.DataPropertyName = "DocumentId";
            this.DocumentId.HeaderText = "ID";
            this.DocumentId.Name = "DocumentId";
            this.DocumentId.ReadOnly = true;
            this.DocumentId.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "InventoriesTypeName";
            this.Column1.HeaderText = "Demirbaş";
            this.Column1.Name = "Column1";
            // 
            // InventoriesTypeId
            // 
            this.InventoriesTypeId.DataPropertyName = "InventoriesTypeId";
            this.InventoriesTypeId.HeaderText = "InventoriesTypeId";
            this.InventoriesTypeId.Name = "InventoriesTypeId";
            this.InventoriesTypeId.Visible = false;
            // 
            // DocumentsDate
            // 
            this.DocumentsDate.DataPropertyName = "DocumentsDate";
            this.DocumentsDate.HeaderText = "Alış Tarihi";
            this.DocumentsDate.Name = "DocumentsDate";
            // 
            // DocumentPrice
            // 
            this.DocumentPrice.DataPropertyName = "DocumentPrice";
            this.DocumentPrice.HeaderText = "Adet";
            this.DocumentPrice.Name = "DocumentPrice";
            // 
            // DocumentCompany
            // 
            this.DocumentCompany.DataPropertyName = "DocumentCompany";
            this.DocumentCompany.HeaderText = "Şirket";
            this.DocumentCompany.Name = "DocumentCompany";
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = this.demirbasDbDataSet;
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
            this.panel4.Location = new System.Drawing.Point(410, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 342);
            this.panel4.TabIndex = 121;
            // 
            // btnUpdateF
            // 
            this.btnUpdateF.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateF.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateF.ForeColor = System.Drawing.Color.White;
            this.btnUpdateF.Location = new System.Drawing.Point(136, 255);
            this.btnUpdateF.Name = "btnUpdateF";
            this.btnUpdateF.Size = new System.Drawing.Size(87, 32);
            this.btnUpdateF.TabIndex = 119;
            this.btnUpdateF.Text = "Güncelle";
            this.btnUpdateF.UseVisualStyleBackColor = false;
            this.btnUpdateF.Click += new System.EventHandler(this.btnUpdateF_Click);
            // 
            // btnSaveF
            // 
            this.btnSaveF.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveF.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveF.ForeColor = System.Drawing.Color.White;
            this.btnSaveF.Location = new System.Drawing.Point(315, 254);
            this.btnSaveF.Name = "btnSaveF";
            this.btnSaveF.Size = new System.Drawing.Size(80, 32);
            this.btnSaveF.TabIndex = 118;
            this.btnSaveF.Text = "Kaydet";
            this.btnSaveF.UseVisualStyleBackColor = false;
            this.btnSaveF.Click += new System.EventHandler(this.btnSaveF_Click);
            // 
            // btnDeleteF
            // 
            this.btnDeleteF.BackColor = System.Drawing.Color.White;
            this.btnDeleteF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteF.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteF.Location = new System.Drawing.Point(229, 254);
            this.btnDeleteF.Name = "btnDeleteF";
            this.btnDeleteF.Size = new System.Drawing.Size(80, 32);
            this.btnDeleteF.TabIndex = 120;
            this.btnDeleteF.Text = "Sil";
            this.btnDeleteF.UseVisualStyleBackColor = false;
            this.btnDeleteF.Click += new System.EventHandler(this.btnDeleteF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(140, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 115;
            this.label2.Text = "Alış Tarihi:";
            // 
            // txtFaturaID
            // 
            this.txtFaturaID.BackColor = System.Drawing.Color.Lavender;
            this.txtFaturaID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFaturaID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtFaturaID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFaturaID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtFaturaID.Location = new System.Drawing.Point(143, 70);
            this.txtFaturaID.Name = "txtFaturaID";
            this.txtFaturaID.Size = new System.Drawing.Size(250, 19);
            this.txtFaturaID.TabIndex = 113;
            this.txtFaturaID.Text = "Fatura ID";
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.dateTime.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.dateTime.CalendarTitleBackColor = System.Drawing.Color.MidnightBlue;
            this.dateTime.CalendarTitleForeColor = System.Drawing.Color.Lavender;
            this.dateTime.CalendarTrailingForeColor = System.Drawing.Color.MidnightBlue;
            this.dateTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTime.Location = new System.Drawing.Point(220, 136);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(173, 20);
            this.dateTime.TabIndex = 112;
            this.dateTime.Value = new System.DateTime(2023, 5, 7, 22, 21, 11, 0);
            // 
            // btnDemirbas
            // 
            this.btnDemirbas.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDemirbas.FlatAppearance.BorderSize = 0;
            this.btnDemirbas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemirbas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemirbas.ForeColor = System.Drawing.Color.White;
            this.btnDemirbas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemirbas.Location = new System.Drawing.Point(8, 199);
            this.btnDemirbas.Name = "btnDemirbas";
            this.btnDemirbas.Size = new System.Drawing.Size(86, 31);
            this.btnDemirbas.TabIndex = 50;
            this.btnDemirbas.Text = "Demirbaş";
            this.btnDemirbas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemirbas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDemirbas.UseVisualStyleBackColor = false;
            this.btnDemirbas.Click += new System.EventHandler(this.btnDemirbas_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnArchive.FlatAppearance.BorderSize = 0;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArchive.ForeColor = System.Drawing.Color.White;
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.Location = new System.Drawing.Point(7, 162);
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
            this.panel2.Location = new System.Drawing.Point(7, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 3);
            this.panel2.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnDemirbas);
            this.panel1.Controls.Add(this.btnArchive);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMain);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 468);
            this.panel1.TabIndex = 110;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(7, 125);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(86, 31);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Ana Sayfa";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "Fatura";
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExist.FlatAppearance.BorderSize = 0;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExist.ForeColor = System.Drawing.Color.White;
            this.btnExist.Location = new System.Drawing.Point(731, 2);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(20, 28);
            this.btnExist.TabIndex = 44;
            this.btnExist.Text = "X";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnExist);
            this.panel3.Location = new System.Drawing.Point(123, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(879, 35);
            this.panel3.TabIndex = 111;
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.Lavender;
            this.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompany.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCompany.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCompany.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCompany.Location = new System.Drawing.Point(145, 208);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(250, 19);
            this.txtCompany.TabIndex = 123;
            this.txtCompany.Text = "Şirket";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Lavender;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPrice.Location = new System.Drawing.Point(145, 174);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(250, 19);
            this.txtPrice.TabIndex = 125;
            this.txtPrice.Text = "Adet";
            // 
            // comboType
            // 
            this.comboType.BackColor = System.Drawing.Color.Lavender;
            this.comboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(142, 100);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(250, 25);
            this.comboType.TabIndex = 126;
            this.comboType.Text = "Demirbaş";
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(720, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 22);
            this.btnSearch.TabIndex = 128;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(434, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 22);
            this.txtSearch.TabIndex = 127;
            this.txtSearch.Text = "Ara";
//            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // DocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 441);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.dgvFatura);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnUpdateF);
            this.Controls.Add(this.btnSaveF);
            this.Controls.Add(this.btnDeleteF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFaturaID);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocumentForm";
            this.Load += new System.EventHandler(this.DocumentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFatura;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdateF;
        private System.Windows.Forms.Button btnSaveF;
        private System.Windows.Forms.Button btnDeleteF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFaturaID;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button btnDemirbas;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comboType;
        private DemirbasDbDataSet demirbasDbDataSet;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private DemirbasDbDataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoriesTypeName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoriesTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentCompany;
    }
}