namespace Clinic
{
    partial class frmExamination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamination));
            this.dgvExamination = new System.Windows.Forms.DataGridView();
            this.lblmessege = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEXaminationContent = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mybutton5 = new Clinic.mybutton();
            this.mybutton4 = new Clinic.mybutton();
            this.mybutton6 = new Clinic.mybutton();
            this.mybutton7 = new Clinic.mybutton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamination)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExamination
            // 
            resources.ApplyResources(this.dgvExamination, "dgvExamination");
            this.dgvExamination.AllowUserToAddRows = false;
            this.dgvExamination.AllowUserToDeleteRows = false;
            this.dgvExamination.AllowUserToOrderColumns = true;
            this.dgvExamination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExamination.BackgroundColor = System.Drawing.Color.White;
            this.dgvExamination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvExamination.Name = "dgvExamination";
            this.dgvExamination.ReadOnly = true;
            this.dgvExamination.Click += new System.EventHandler(this.dgvExamination_Click);
            // 
            // lblmessege
            // 
            resources.ApplyResources(this.lblmessege, "lblmessege");
            this.lblmessege.ForeColor = System.Drawing.Color.Red;
            this.lblmessege.Name = "lblmessege";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.lblmessege);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Name = "label5";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.txtEXaminationContent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // txtEXaminationContent
            // 
            resources.ApplyResources(this.txtEXaminationContent, "txtEXaminationContent");
            this.txtEXaminationContent.BackColor = System.Drawing.Color.White;
            this.txtEXaminationContent.Name = "txtEXaminationContent";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.mybutton5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mybutton4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.mybutton6, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.mybutton7, 6, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
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
            // mybutton7
            // 
            resources.ApplyResources(this.mybutton7, "mybutton7");
            this.mybutton7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mybutton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mybutton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.mybutton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.mybutton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mybutton7.Name = "mybutton7";
            this.mybutton7.UseVisualStyleBackColor = false;
            this.mybutton7.Click += new System.EventHandler(this.mybutton7_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "appointmentDate";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "examination";
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
            // Column5
            // 
            this.Column5.DataPropertyName = "SpecializationsName";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmExamination
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvExamination);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExamination";
            this.Load += new System.EventHandler(this.frmExamination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamination)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvExamination;
        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.GroupBox groupBox1;
        private mybutton mybutton7;
        private mybutton mybutton4;
        private System.Windows.Forms.Label label5;
        private mybutton mybutton5;
        private mybutton mybutton6;
        private System.Windows.Forms.TextBox txtEXaminationContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}