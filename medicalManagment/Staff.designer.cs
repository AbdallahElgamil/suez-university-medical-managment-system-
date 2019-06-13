namespace Clinic
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.staffphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.staffaddress = new System.Windows.Forms.TextBox();
            this.staffage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.staffid = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.staffemail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.staffname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.staffprofession = new System.Windows.Forms.ComboBox();
            this.lblspecialization = new System.Windows.Forms.Label();
            this.txtspecialization = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.staffgender = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btndelete = new Clinic.mybutton();
            this.btnedit = new Clinic.mybutton();
            this.btnadd = new Clinic.mybutton();
            this.btnprivilege = new Clinic.mybutton();
            this.dgvpr = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new Clinic.mybutton();
            this.btnsearch = new Clinic.mybutton();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblmessege = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mybutton1 = new Clinic.mybutton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpr)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackColor = System.Drawing.Color.MediumBlue;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.tableLayoutPanel3.Controls.Add(this.staffphone, 7, 5);
            this.tableLayoutPanel3.Controls.Add(this.label4, 5, 7);
            this.tableLayoutPanel3.Controls.Add(this.label12, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.label9, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.staffaddress, 7, 7);
            this.tableLayoutPanel3.Controls.Add(this.staffage, 7, 3);
            this.tableLayoutPanel3.Controls.Add(this.label15, 5, 5);
            this.tableLayoutPanel3.Controls.Add(this.staffid, 3, 9);
            this.tableLayoutPanel3.Controls.Add(this.label17, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.staffemail, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.label16, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.staffname, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label13, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.staffprofession, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblspecialization, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtspecialization, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.staffgender, 3, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // staffphone
            // 
            resources.ApplyResources(this.staffphone, "staffphone");
            this.staffphone.Name = "staffphone";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Name = "label4";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Name = "label12";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Name = "label9";
            // 
            // staffaddress
            // 
            resources.ApplyResources(this.staffaddress, "staffaddress");
            this.staffaddress.Name = "staffaddress";
            // 
            // staffage
            // 
            resources.ApplyResources(this.staffage, "staffage");
            this.staffage.Name = "staffage";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.Azure;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Name = "label15";
            // 
            // staffid
            // 
            resources.ApplyResources(this.staffid, "staffid");
            this.staffid.Name = "staffid";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Azure;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Name = "label17";
            // 
            // staffemail
            // 
            resources.ApplyResources(this.staffemail, "staffemail");
            this.staffemail.Name = "staffemail";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Azure;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Name = "label16";
            // 
            // staffname
            // 
            resources.ApplyResources(this.staffname, "staffname");
            this.staffname.Name = "staffname";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Name = "label13";
            // 
            // staffprofession
            // 
            resources.ApplyResources(this.staffprofession, "staffprofession");
            this.staffprofession.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.staffprofession.BackColor = System.Drawing.Color.White;
            this.staffprofession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffprofession.FormattingEnabled = true;
            this.staffprofession.Name = "staffprofession";
            this.staffprofession.SelectedIndexChanged += new System.EventHandler(this.staffprofession_SelectedIndexChanged);
            this.staffprofession.TextChanged += new System.EventHandler(this.staffprofession_TextChanged);
            // 
            // lblspecialization
            // 
            resources.ApplyResources(this.lblspecialization, "lblspecialization");
            this.lblspecialization.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblspecialization.Name = "lblspecialization";
            // 
            // txtspecialization
            // 
            resources.ApplyResources(this.txtspecialization, "txtspecialization");
            this.txtspecialization.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.txtspecialization.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtspecialization.BackColor = System.Drawing.Color.White;
            this.txtspecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtspecialization.FormattingEnabled = true;
            this.txtspecialization.Name = "txtspecialization";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            // 
            // staffgender
            // 
            resources.ApplyResources(this.staffgender, "staffgender");
            this.staffgender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.staffgender.BackColor = System.Drawing.Color.White;
            this.staffgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffgender.FormattingEnabled = true;
            this.staffgender.Name = "staffgender";
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
            this.tableLayoutPanel4.Controls.Add(this.btndelete, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.btnedit, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnadd, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnprivilege, 1, 7);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // btndelete
            // 
            resources.ApplyResources(this.btndelete, "btndelete");
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndelete.Name = "btndelete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnedit
            // 
            resources.ApplyResources(this.btnedit, "btnedit");
            this.btnedit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnedit.Name = "btnedit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click_1);
            // 
            // btnadd
            // 
            resources.ApplyResources(this.btnadd, "btnadd");
            this.btnadd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnadd.Name = "btnadd";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnprivilege
            // 
            resources.ApplyResources(this.btnprivilege, "btnprivilege");
            this.btnprivilege.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprivilege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprivilege.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnprivilege.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnprivilege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnprivilege.Name = "btnprivilege";
            this.btnprivilege.UseVisualStyleBackColor = false;
            this.btnprivilege.Click += new System.EventHandler(this.btnprivilege_Click);
            // 
            // dgvpr
            // 
            resources.ApplyResources(this.dgvpr, "dgvpr");
            this.dgvpr.AllowUserToAddRows = false;
            this.dgvpr.AllowUserToDeleteRows = false;
            this.dgvpr.AllowUserToOrderColumns = true;
            this.dgvpr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpr.BackgroundColor = System.Drawing.Color.White;
            this.dgvpr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column5,
            this.Column4,
            this.Column3});
            this.dgvpr.GridColor = System.Drawing.Color.White;
            this.dgvpr.Name = "dgvpr";
            this.dgvpr.ReadOnly = true;
            this.dgvpr.Click += new System.EventHandler(this.dgvpr_Click_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "staffId";
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "staffName";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "professionName";
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SpecializationsName";
            resources.ApplyResources(this.Column9, "Column9");
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "phone";
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "gender";
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "age";
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "email";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "address";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtsearch, 3, 0);
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
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
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
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
            // 
            // txtsearch
            // 
            resources.ApplyResources(this.txtsearch, "txtsearch");
            this.txtsearch.ForeColor = System.Drawing.Color.Silver;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            this.txtsearch.Leave += new System.EventHandler(this.txtsearch_Leave);
            // 
            // lblmessege
            // 
            resources.ApplyResources(this.lblmessege, "lblmessege");
            this.lblmessege.ForeColor = System.Drawing.Color.Red;
            this.lblmessege.Name = "lblmessege";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Name = "label2";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
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
            // frmStaff
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mybutton1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmessege);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvpr);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpr)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtspecialization;
        private System.Windows.Forms.TextBox staffphone;
        private System.Windows.Forms.ComboBox staffgender;
        private System.Windows.Forms.ComboBox staffprofession;
        private System.Windows.Forms.TextBox staffname;
        private System.Windows.Forms.TextBox staffid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox staffaddress;
        private System.Windows.Forms.TextBox staffage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox staffemail;
        private System.Windows.Forms.GroupBox groupBox3;
        private mybutton btnedit;
        private mybutton btnadd;
        private mybutton btndelete;
        private System.Windows.Forms.DataGridView dgvpr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private mybutton btnback;
        private mybutton btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblspecialization;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private mybutton mybutton1;
        private mybutton btnprivilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}