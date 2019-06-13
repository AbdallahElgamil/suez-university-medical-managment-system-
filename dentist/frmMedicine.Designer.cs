namespace Clinic
{
    partial class frmMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicine));
            this.lblmessege = new System.Windows.Forms.Label();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblmessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mybutton4 = new Clinic.mybutton();
            this.mybutton1 = new Clinic.mybutton();
            this.mybutton5 = new Clinic.mybutton();
            this.mybutton6 = new Clinic.mybutton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmessege
            // 
            resources.ApplyResources(this.lblmessege, "lblmessege");
            this.lblmessege.Name = "lblmessege";
            // 
            // dgvMedicine
            // 
            resources.ApplyResources(this.dgvMedicine, "dgvMedicine");
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AllowUserToDeleteRows = false;
            this.dgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicine.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.x,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.Click += new System.EventHandler(this.dgvMedicine_Click_2);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.lblmessage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.txtMedicine, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // txtMedicine
            // 
            resources.ApplyResources(this.txtMedicine, "txtMedicine");
            this.txtMedicine.BackColor = System.Drawing.Color.White;
            this.txtMedicine.Name = "txtMedicine";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.mybutton4, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.mybutton1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mybutton5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.mybutton6, 6, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lblmessage
            // 
            resources.ApplyResources(this.lblmessage, "lblmessage");
            this.lblmessage.ForeColor = System.Drawing.Color.Red;
            this.lblmessage.Name = "lblmessage";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mybutton4
            // 
            resources.ApplyResources(this.mybutton4, "mybutton4");
            this.mybutton4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mybutton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mybutton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.mybutton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.mybutton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mybutton4.Name = "mybutton4";
            this.mybutton4.UseVisualStyleBackColor = false;
            this.mybutton4.Click += new System.EventHandler(this.mybutton4_Click);
            // 
            // mybutton1
            // 
            resources.ApplyResources(this.mybutton1, "mybutton1");
            this.mybutton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mybutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mybutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.mybutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.mybutton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mybutton1.Name = "mybutton1";
            this.mybutton1.UseVisualStyleBackColor = false;
            this.mybutton1.Click += new System.EventHandler(this.mybutton1_Click);
            // 
            // mybutton5
            // 
            resources.ApplyResources(this.mybutton5, "mybutton5");
            this.mybutton5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mybutton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mybutton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.mybutton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.mybutton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mybutton5.Name = "mybutton5";
            this.mybutton5.UseVisualStyleBackColor = false;
            this.mybutton5.Click += new System.EventHandler(this.mybutton5_Click);
            // 
            // mybutton6
            // 
            resources.ApplyResources(this.mybutton6, "mybutton6");
            this.mybutton6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mybutton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mybutton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.mybutton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.mybutton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mybutton6.Name = "mybutton6";
            this.mybutton6.UseVisualStyleBackColor = false;
            this.mybutton6.Click += new System.EventHandler(this.mybutton6_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "appointmentDate";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // x
            // 
            this.x.DataPropertyName = "SpecializationsName";
            resources.ApplyResources(this.x, "x");
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "medicine";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "patientName";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "staffName";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmMedicine
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblmessege);
            this.Controls.Add(this.dgvMedicine);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMedicine";
            this.Load += new System.EventHandler(this.frmMedicine_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private mybutton mybutton4;
        private mybutton mybutton5;
        private mybutton mybutton6;
        private mybutton mybutton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}