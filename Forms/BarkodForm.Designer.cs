namespace KücükPrensManagment.Forms
{
    partial class BarkodForm
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
            this.btnBarkod = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.picBarkod = new System.Windows.Forms.PictureBox();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnYaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBarkod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBarkod
            // 
            this.btnBarkod.BackColor = System.Drawing.Color.Orange;
            this.btnBarkod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarkod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBarkod.ForeColor = System.Drawing.Color.White;
            this.btnBarkod.Location = new System.Drawing.Point(43, 98);
            this.btnBarkod.Name = "btnBarkod";
            this.btnBarkod.Size = new System.Drawing.Size(136, 32);
            this.btnBarkod.TabIndex = 45;
            this.btnBarkod.Text = "Barkod Oluştur";
            this.btnBarkod.UseVisualStyleBackColor = false;
            this.btnBarkod.Click += new System.EventHandler(this.btnBarkod_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(43, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 1);
            this.panel1.TabIndex = 47;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtBarkodNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarkodNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.ForeColor = System.Drawing.Color.Orange;
            this.txtBarkodNo.Location = new System.Drawing.Point(43, 45);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(136, 19);
            this.txtBarkodNo.TabIndex = 43;
            this.txtBarkodNo.Text = "Barkod No";
            // 
            // picBarkod
            // 
            this.picBarkod.Location = new System.Drawing.Point(47, 158);
            this.picBarkod.Name = "picBarkod";
            this.picBarkod.Size = new System.Drawing.Size(127, 62);
            this.picBarkod.TabIndex = 48;
            this.picBarkod.TabStop = false;
            // 
            // btnExist
            // 
            this.btnExist.FlatAppearance.BorderSize = 0;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExist.ForeColor = System.Drawing.Color.White;
            this.btnExist.Location = new System.Drawing.Point(206, -2);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(20, 28);
            this.btnExist.TabIndex = 49;
            this.btnExist.Text = "X";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnYaz
            // 
            this.btnYaz.BackColor = System.Drawing.Color.Orange;
            this.btnYaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYaz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYaz.ForeColor = System.Drawing.Color.White;
            this.btnYaz.Location = new System.Drawing.Point(43, 247);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(136, 32);
            this.btnYaz.TabIndex = 50;
            this.btnYaz.Text = "Yazdır";
            this.btnYaz.UseVisualStyleBackColor = false;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // BarkodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(227, 322);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.picBarkod);
            this.Controls.Add(this.btnBarkod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBarkodNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarkodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarkodForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBarkod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBarkod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.PictureBox picBarkod;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnYaz;
    }
}