namespace Clinic
{
    partial class patient_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient_history));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.report_patient_history = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.Pnlheader = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.combspecialization = new System.Windows.Forms.ComboBox();
            this.combdoctor = new System.Windows.Forms.ComboBox();
            this.combpatient = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxactive = new System.Windows.Forms.CheckBox();
            this.checkdoctor = new System.Windows.Forms.CheckBox();
            this.checkBoxexaminationType = new System.Windows.Forms.CheckBox();
            this.checkBoxpatient = new System.Windows.Forms.CheckBox();
            this.patient_historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_historyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // report_patient_history
            // 
            resources.ApplyResources(this.report_patient_history, "report_patient_history");
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.patient_historyBindingSource;
            this.report_patient_history.LocalReport.DataSources.Add(reportDataSource1);
            this.report_patient_history.LocalReport.ReportEmbeddedResource = "dentist.report_patient_History.rdlc";
            this.report_patient_history.Name = "report_patient_history";
            this.report_patient_history.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pnlheader
            // 
            resources.ApplyResources(this.Pnlheader, "Pnlheader");
            this.Pnlheader.BackColor = System.Drawing.Color.DodgerBlue;
            this.Pnlheader.Controls.Add(this.button2);
            this.Pnlheader.Controls.Add(this.button3);
            this.Pnlheader.Controls.Add(this.button4);
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
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // combspecialization
            // 
            resources.ApplyResources(this.combspecialization, "combspecialization");
            this.combspecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combspecialization.FormattingEnabled = true;
            this.combspecialization.Name = "combspecialization";
            this.combspecialization.SelectedIndexChanged += new System.EventHandler(this.combspecialization_SelectedIndexChanged);
            // 
            // combdoctor
            // 
            resources.ApplyResources(this.combdoctor, "combdoctor");
            this.combdoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combdoctor.FormattingEnabled = true;
            this.combdoctor.Name = "combdoctor";
            // 
            // combpatient
            // 
            resources.ApplyResources(this.combpatient, "combpatient");
            this.combpatient.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.combpatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combpatient.FormattingEnabled = true;
            this.combpatient.Name = "combpatient";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
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
            // checkdoctor
            // 
            resources.ApplyResources(this.checkdoctor, "checkdoctor");
            this.checkdoctor.Name = "checkdoctor";
            this.checkdoctor.UseVisualStyleBackColor = true;
            this.checkdoctor.CheckedChanged += new System.EventHandler(this.checkdoctor_CheckedChanged);
            // 
            // checkBoxexaminationType
            // 
            resources.ApplyResources(this.checkBoxexaminationType, "checkBoxexaminationType");
            this.checkBoxexaminationType.Name = "checkBoxexaminationType";
            this.checkBoxexaminationType.UseVisualStyleBackColor = true;
            this.checkBoxexaminationType.CheckedChanged += new System.EventHandler(this.checkBoxexaminationType_CheckedChanged);
            // 
            // checkBoxpatient
            // 
            resources.ApplyResources(this.checkBoxpatient, "checkBoxpatient");
            this.checkBoxpatient.Name = "checkBoxpatient";
            this.checkBoxpatient.UseVisualStyleBackColor = true;
            this.checkBoxpatient.CheckedChanged += new System.EventHandler(this.checkBoxpatient_CheckedChanged);
            // 
            // patient_history
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxactive);
            this.Controls.Add(this.checkdoctor);
            this.Controls.Add(this.checkBoxexaminationType);
            this.Controls.Add(this.checkBoxpatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combspecialization);
            this.Controls.Add(this.combdoctor);
            this.Controls.Add(this.combpatient);
            this.Controls.Add(this.Pnlheader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.report_patient_history);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "patient_history";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pnlheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patient_historyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public Microsoft.Reporting.WinForms.ReportViewer report_patient_history;
        private System.Windows.Forms.BindingSource patient_historyBindingSource;
        private System.Windows.Forms.Panel Pnlheader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox combspecialization;
        private System.Windows.Forms.ComboBox combdoctor;
        private System.Windows.Forms.ComboBox combpatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxactive;
        private System.Windows.Forms.CheckBox checkdoctor;
        private System.Windows.Forms.CheckBox checkBoxexaminationType;
        private System.Windows.Forms.CheckBox checkBoxpatient;
    }
}