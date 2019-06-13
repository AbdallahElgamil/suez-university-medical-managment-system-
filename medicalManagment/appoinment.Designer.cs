namespace Clinic
{
    partial class frmappoinment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmappoinment));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtregestrationNo = new System.Windows.Forms.TextBox();
            this.combpatient = new System.Windows.Forms.ComboBox();
            this.combdoctor = new System.Windows.Forms.ComboBox();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.lblmessege = new System.Windows.Forms.Label();
            this.dgvAppoinment = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.mybutton3 = new Clinic.mybutton();
            this.mybutton1 = new Clinic.mybutton();
            this.mybutton2 = new Clinic.mybutton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.combspecialization = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new Clinic.mybutton();
            this.btnsearch = new Clinic.mybutton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoinment)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtregestrationNo
            // 
            resources.ApplyResources(this.txtregestrationNo, "txtregestrationNo");
            this.txtregestrationNo.Name = "txtregestrationNo";
            // 
            // combpatient
            // 
            resources.ApplyResources(this.combpatient, "combpatient");
            this.combpatient.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.combpatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combpatient.FormattingEnabled = true;
            this.combpatient.Name = "combpatient";
            // 
            // combdoctor
            // 
            resources.ApplyResources(this.combdoctor, "combdoctor");
            this.combdoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combdoctor.FormattingEnabled = true;
            this.combdoctor.Name = "combdoctor";
            // 
            // dt
            // 
            resources.ApplyResources(this.dt, "dt");
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt.Name = "dt";
            // 
            // lblmessege
            // 
            resources.ApplyResources(this.lblmessege, "lblmessege");
            this.lblmessege.Name = "lblmessege";
            // 
            // dgvAppoinment
            // 
            resources.ApplyResources(this.dgvAppoinment, "dgvAppoinment");
            this.dgvAppoinment.AllowUserToAddRows = false;
            this.dgvAppoinment.AllowUserToDeleteRows = false;
            this.dgvAppoinment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppoinment.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppoinment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppoinment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvAppoinment.Name = "dgvAppoinment";
            this.dgvAppoinment.ReadOnly = true;
            this.dgvAppoinment.Click += new System.EventHandler(this.dgvAppoinment_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "appointmentId";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "appointmentDate";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "patientName";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "staffName";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SpecializationsName";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.Azure;
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.mybutton3, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.mybutton1, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.mybutton2, 1, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // mybutton3
            // 
            resources.ApplyResources(this.mybutton3, "mybutton3");
            this.mybutton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mybutton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mybutton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.mybutton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.mybutton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mybutton3.Name = "mybutton3";
            this.mybutton3.UseVisualStyleBackColor = false;
            this.mybutton3.Click += new System.EventHandler(this.mybutton3_Click);
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
            // mybutton2
            // 
            resources.ApplyResources(this.mybutton2, "mybutton2");
            this.mybutton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mybutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mybutton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.mybutton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.mybutton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mybutton2.Name = "mybutton2";
            this.mybutton2.UseVisualStyleBackColor = false;
            this.mybutton2.Click += new System.EventHandler(this.mybutton2_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.combspecialization, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.dt, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.label13, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label17, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtregestrationNo, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.label3, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.combdoctor, 7, 3);
            this.tableLayoutPanel3.Controls.Add(this.combpatient, 7, 1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // combspecialization
            // 
            resources.ApplyResources(this.combspecialization, "combspecialization");
            this.combspecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combspecialization.FormattingEnabled = true;
            this.combspecialization.Name = "combspecialization";
            this.combspecialization.SelectedIndexChanged += new System.EventHandler(this.combspecialization_SelectedIndexChanged);
            this.combspecialization.TextChanged += new System.EventHandler(this.combspecialization_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Name = "label13";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Azure;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Name = "label17";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Name = "label5";
            // 
            // txtsearch
            // 
            resources.ApplyResources(this.txtsearch, "txtsearch");
            this.txtsearch.ForeColor = System.Drawing.Color.Silver;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            this.txtsearch.Leave += new System.EventHandler(this.txtsearch_Leave);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Name = "label7";
            // 
            // comboSearch
            // 
            resources.ApplyResources(this.comboSearch, "comboSearch");
            this.comboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtsearch, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboSearch, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Name = "panel1";
            // 
            // btnback
            // 
            resources.ApplyResources(this.btnback, "btnback");
            this.btnback.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnback.Name = "btnback";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnsearch
            // 
            resources.ApplyResources(this.btnsearch, "btnsearch");
            this.btnsearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // frmappoinment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvAppoinment);
            this.Controls.Add(this.lblmessege);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmappoinment";
            this.Load += new System.EventHandler(this.appoinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoinment)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtregestrationNo;
        private System.Windows.Forms.ComboBox combpatient;
        private System.Windows.Forms.ComboBox combdoctor;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.DataGridView dgvAppoinment;
        private System.Windows.Forms.GroupBox groupBox3;
        private mybutton mybutton1;
        private mybutton mybutton2;
        private mybutton mybutton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combspecialization;
        private mybutton btnback;
        private System.Windows.Forms.TextBox txtsearch;
        private mybutton btnsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}