namespace Clinic
{
    partial class frmReportPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportPatient));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportPatient = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Pnlheader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.cname = new System.Windows.Forms.ComboBox();
            this.clevel = new System.Windows.Forms.ComboBox();
            this.cgender = new System.Windows.Forms.ComboBox();
            this.cfaculty = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxname = new System.Windows.Forms.CheckBox();
            this.checkBoxfaculty = new System.Windows.Forms.CheckBox();
            this.checkBoxlevel = new System.Windows.Forms.CheckBox();
            this.checkBoxgender = new System.Windows.Forms.CheckBox();
            this.checkBoxactive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportPatient
            // 
            resources.ApplyResources(this.reportPatient, "reportPatient");
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.patientBindingSource;
            this.reportPatient.LocalReport.DataSources.Add(reportDataSource1);
            this.reportPatient.LocalReport.ReportEmbeddedResource = "dentist.Report1.rdlc";
            this.reportPatient.Name = "reportPatient";
            this.reportPatient.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
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
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnload
            // 
            resources.ApplyResources(this.btnload, "btnload");
            this.btnload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnload.Name = "btnload";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // cname
            // 
            resources.ApplyResources(this.cname, "cname");
            this.cname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cname.BackColor = System.Drawing.Color.White;
            this.cname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cname.FormattingEnabled = true;
            this.cname.Name = "cname";
            // 
            // clevel
            // 
            resources.ApplyResources(this.clevel, "clevel");
            this.clevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.clevel.BackColor = System.Drawing.Color.White;
            this.clevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clevel.FormattingEnabled = true;
            this.clevel.Name = "clevel";
            // 
            // cgender
            // 
            resources.ApplyResources(this.cgender, "cgender");
            this.cgender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cgender.BackColor = System.Drawing.Color.White;
            this.cgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cgender.FormattingEnabled = true;
            this.cgender.Name = "cgender";
            // 
            // cfaculty
            // 
            resources.ApplyResources(this.cfaculty, "cfaculty");
            this.cfaculty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cfaculty.BackColor = System.Drawing.Color.White;
            this.cfaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cfaculty.FormattingEnabled = true;
            this.cfaculty.Name = "cfaculty";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Azure;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Name = "label17";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Name = "label3";
            // 
            // checkBoxname
            // 
            resources.ApplyResources(this.checkBoxname, "checkBoxname");
            this.checkBoxname.Name = "checkBoxname";
            this.checkBoxname.UseVisualStyleBackColor = true;
            this.checkBoxname.CheckedChanged += new System.EventHandler(this.checkBoxname_CheckedChanged);
            // 
            // checkBoxfaculty
            // 
            resources.ApplyResources(this.checkBoxfaculty, "checkBoxfaculty");
            this.checkBoxfaculty.Name = "checkBoxfaculty";
            this.checkBoxfaculty.UseVisualStyleBackColor = true;
            this.checkBoxfaculty.CheckedChanged += new System.EventHandler(this.checkBoxfaculty_CheckedChanged);
            // 
            // checkBoxlevel
            // 
            resources.ApplyResources(this.checkBoxlevel, "checkBoxlevel");
            this.checkBoxlevel.Name = "checkBoxlevel";
            this.checkBoxlevel.UseVisualStyleBackColor = true;
            this.checkBoxlevel.CheckedChanged += new System.EventHandler(this.checkBoxlevel_CheckedChanged);
            // 
            // checkBoxgender
            // 
            resources.ApplyResources(this.checkBoxgender, "checkBoxgender");
            this.checkBoxgender.Name = "checkBoxgender";
            this.checkBoxgender.UseVisualStyleBackColor = true;
            this.checkBoxgender.CheckedChanged += new System.EventHandler(this.checkBoxgender_CheckedChanged);
            // 
            // checkBoxactive
            // 
            resources.ApplyResources(this.checkBoxactive, "checkBoxactive");
            this.checkBoxactive.Name = "checkBoxactive";
            this.checkBoxactive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Name = "label4";
            // 
            // frmReportPatient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxactive);
            this.Controls.Add(this.checkBoxgender);
            this.Controls.Add(this.checkBoxlevel);
            this.Controls.Add(this.checkBoxfaculty);
            this.Controls.Add(this.checkBoxname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cfaculty);
            this.Controls.Add(this.cgender);
            this.Controls.Add(this.clevel);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.Pnlheader);
            this.Controls.Add(this.reportPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportPatient";
            this.Load += new System.EventHandler(this.frmReportPatient_Load);
            this.Pnlheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource patientBindingSource;
        public Microsoft.Reporting.WinForms.ReportViewer reportPatient;
        private System.Windows.Forms.Panel Pnlheader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.ComboBox cname;
        private System.Windows.Forms.ComboBox clevel;
        private System.Windows.Forms.ComboBox cgender;
        private System.Windows.Forms.ComboBox cfaculty;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxname;
        private System.Windows.Forms.CheckBox checkBoxfaculty;
        private System.Windows.Forms.CheckBox checkBoxlevel;
        private System.Windows.Forms.CheckBox checkBoxgender;
        private System.Windows.Forms.CheckBox checkBoxactive;
        private System.Windows.Forms.Label label4;
    }
}