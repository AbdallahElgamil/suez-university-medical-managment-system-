namespace Clinic
{
    partial class frmMedicalHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalHistory));
            this.medicalHistoryComplaint = new System.Windows.Forms.DataGridView();
            this.lblmessege = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMedicalHistoryContent = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.mybutton4 = new Clinic.mybutton();
            this.mybutton6 = new Clinic.mybutton();
            this.mybutton5 = new Clinic.mybutton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medicalHistoryComplaint)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicalHistoryComplaint
            // 
            resources.ApplyResources(this.medicalHistoryComplaint, "medicalHistoryComplaint");
            this.medicalHistoryComplaint.AllowUserToAddRows = false;
            this.medicalHistoryComplaint.AllowUserToDeleteRows = false;
            this.medicalHistoryComplaint.AllowUserToOrderColumns = true;
            this.medicalHistoryComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicalHistoryComplaint.BackgroundColor = System.Drawing.Color.White;
            this.medicalHistoryComplaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicalHistoryComplaint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.medicalHistoryComplaint.Name = "medicalHistoryComplaint";
            this.medicalHistoryComplaint.ReadOnly = true;
            this.medicalHistoryComplaint.Click += new System.EventHandler(this.medicalHistoryComplaint_Click);
            // 
            // lblmessege
            // 
            resources.ApplyResources(this.lblmessege, "lblmessege");
            this.lblmessege.ForeColor = System.Drawing.Color.Red;
            this.lblmessege.Name = "lblmessege";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.lblmessege);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.txtMedicalHistoryContent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // txtMedicalHistoryContent
            // 
            resources.ApplyResources(this.txtMedicalHistoryContent, "txtMedicalHistoryContent");
            this.txtMedicalHistoryContent.BackColor = System.Drawing.Color.White;
            this.txtMedicalHistoryContent.Name = "txtMedicalHistoryContent";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.mybutton4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.mybutton6, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.mybutton5, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Name = "label1";
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
            // Column1
            // 
            this.Column1.DataPropertyName = "appointmentDate";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SpecializationsName";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "medicalhistory";
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
            // frmMedicalHistory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.medicalHistoryComplaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMedicalHistory";
            this.Load += new System.EventHandler(this.frmMedicalHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalHistoryComplaint)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView medicalHistoryComplaint;
        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtMedicalHistoryContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private mybutton mybutton4;
        private mybutton mybutton6;
        private mybutton mybutton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}