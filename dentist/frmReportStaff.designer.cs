namespace Clinic
{
    partial class frmReportStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportStaff));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Pnlheader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.reportStaff = new Microsoft.Reporting.WinForms.ReportViewer();
            this.checkBoxspecilization = new System.Windows.Forms.CheckBox();
            this.checkBoxprofession = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cspecilization = new System.Windows.Forms.ComboBox();
            this.cprofessioon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxactive = new System.Windows.Forms.CheckBox();
            this.btnload = new System.Windows.Forms.Button();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnlheader
            // 
            resources.ApplyResources(this.Pnlheader, "Pnlheader");
            this.Pnlheader.BackColor = System.Drawing.Color.DodgerBlue;
            this.Pnlheader.Controls.Add(this.button2);
            this.Pnlheader.Controls.Add(this.button1);
            this.Pnlheader.Controls.Add(this.button3);
            this.Pnlheader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pnlheader.Name = "Pnlheader";
            this.Pnlheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnlheader_MouseDown);
            this.Pnlheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnlheader_MouseMove);
            this.Pnlheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnlheader_MouseUp);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // reportStaff
            // 
            resources.ApplyResources(this.reportStaff, "reportStaff");
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.staffBindingSource;
            this.reportStaff.LocalReport.DataSources.Add(reportDataSource1);
            this.reportStaff.LocalReport.ReportEmbeddedResource = "dentist.ReportStaff.rdlc";
            this.reportStaff.Name = "reportStaff";
            this.reportStaff.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // checkBoxspecilization
            // 
            resources.ApplyResources(this.checkBoxspecilization, "checkBoxspecilization");
            this.checkBoxspecilization.Name = "checkBoxspecilization";
            this.checkBoxspecilization.UseVisualStyleBackColor = true;
            this.checkBoxspecilization.CheckedChanged += new System.EventHandler(this.checkBoxspecilization_CheckedChanged);
            // 
            // checkBoxprofession
            // 
            resources.ApplyResources(this.checkBoxprofession, "checkBoxprofession");
            this.checkBoxprofession.Name = "checkBoxprofession";
            this.checkBoxprofession.UseVisualStyleBackColor = true;
            this.checkBoxprofession.CheckedChanged += new System.EventHandler(this.checkBoxprofession_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Azure;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Name = "label17";
            // 
            // cspecilization
            // 
            resources.ApplyResources(this.cspecilization, "cspecilization");
            this.cspecilization.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cspecilization.BackColor = System.Drawing.Color.White;
            this.cspecilization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cspecilization.FormattingEnabled = true;
            this.cspecilization.Name = "cspecilization";
            // 
            // cprofessioon
            // 
            resources.ApplyResources(this.cprofessioon, "cprofessioon");
            this.cprofessioon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cprofessioon.BackColor = System.Drawing.Color.White;
            this.cprofessioon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cprofessioon.FormattingEnabled = true;
            this.cprofessioon.Name = "cprofessioon";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Name = "label4";
            // 
            // checkBoxactive
            // 
            resources.ApplyResources(this.checkBoxactive, "checkBoxactive");
            this.checkBoxactive.Name = "checkBoxactive";
            this.checkBoxactive.UseVisualStyleBackColor = true;
            // 
            // btnload
            // 
            resources.ApplyResources(this.btnload, "btnload");
            this.btnload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnload.Name = "btnload";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // frmReportStaff
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxactive);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.checkBoxspecilization);
            this.Controls.Add(this.checkBoxprofession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cspecilization);
            this.Controls.Add(this.cprofessioon);
            this.Controls.Add(this.reportStaff);
            this.Controls.Add(this.Pnlheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportStaff";
            this.Load += new System.EventHandler(this.frmReportStaff_Load);
            this.Pnlheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnlheader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public Microsoft.Reporting.WinForms.ReportViewer reportStaff;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.CheckBox checkBoxspecilization;
        private System.Windows.Forms.CheckBox checkBoxprofession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cspecilization;
        private System.Windows.Forms.ComboBox cprofessioon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxactive;
        private System.Windows.Forms.Button btnload;
    }
}