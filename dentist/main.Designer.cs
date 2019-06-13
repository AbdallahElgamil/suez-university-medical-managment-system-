namespace Clinic
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pnlheader = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblout = new System.Windows.Forms.Label();
            this.lblusers = new System.Windows.Forms.Label();
            this.lblMian = new System.Windows.Forms.Label();
            this.lblSpecilization = new System.Windows.Forms.Label();
            this.lblProfessio = new System.Windows.Forms.Label();
            this.lblappointment = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblsettings = new System.Windows.Forms.Label();
            this.lblmedicines = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.Pnlheader.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.Pnlheader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Pnlheader
            // 
            resources.ApplyResources(this.Pnlheader, "Pnlheader");
            this.Pnlheader.BackColor = System.Drawing.Color.RoyalBlue;
            this.Pnlheader.Controls.Add(this.button3);
            this.Pnlheader.Controls.Add(this.pictureBox1);
            this.Pnlheader.Controls.Add(this.button2);
            this.Pnlheader.Controls.Add(this.button1);
            this.Pnlheader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pnlheader.Name = "Pnlheader";
            this.Pnlheader.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlheader_Paint);
            this.Pnlheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnlheader_MouseDown_1);
            this.Pnlheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnlheader_MouseMove);
            this.Pnlheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnlheader_MouseUp);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mainpanel, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel3.Controls.Add(this.lblout, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.lblusers, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.lblMian, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSpecilization, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblProfessio, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblappointment, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblPatient, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblStaff, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblsettings, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblmedicines, 0, 6);
            this.tableLayoutPanel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblout
            // 
            resources.ApplyResources(this.lblout, "lblout");
            this.lblout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblout.Name = "lblout";
            this.lblout.Click += new System.EventHandler(this.label3_Click);
            this.lblout.MouseLeave += new System.EventHandler(this.lblout_MouseLeave);
            this.lblout.MouseHover += new System.EventHandler(this.lblout_MouseHover);
            // 
            // lblusers
            // 
            resources.ApplyResources(this.lblusers, "lblusers");
            this.lblusers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblusers.Name = "lblusers";
            this.lblusers.Click += new System.EventHandler(this.lblusers_Click);
            this.lblusers.MouseLeave += new System.EventHandler(this.lblusers_MouseLeave);
            this.lblusers.MouseHover += new System.EventHandler(this.lblusers_MouseHover);
            // 
            // lblMian
            // 
            resources.ApplyResources(this.lblMian, "lblMian");
            this.lblMian.BackColor = System.Drawing.Color.Navy;
            this.lblMian.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMian.Name = "lblMian";
            this.lblMian.Click += new System.EventHandler(this.lblMian_Click);
            this.lblMian.MouseLeave += new System.EventHandler(this.lblMian_MouseLeave);
            this.lblMian.MouseHover += new System.EventHandler(this.lblMian_MouseHover);
            // 
            // lblSpecilization
            // 
            resources.ApplyResources(this.lblSpecilization, "lblSpecilization");
            this.lblSpecilization.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSpecilization.Name = "lblSpecilization";
            this.lblSpecilization.Click += new System.EventHandler(this.lblSpecilization_Click);
            this.lblSpecilization.MouseLeave += new System.EventHandler(this.lblSpecilization_MouseLeave);
            this.lblSpecilization.MouseHover += new System.EventHandler(this.lblSpecilization_MouseHover);
            // 
            // lblProfessio
            // 
            resources.ApplyResources(this.lblProfessio, "lblProfessio");
            this.lblProfessio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProfessio.Name = "lblProfessio";
            this.lblProfessio.Click += new System.EventHandler(this.lblProfessio_Click);
            this.lblProfessio.MouseLeave += new System.EventHandler(this.lblProfessio_MouseLeave);
            this.lblProfessio.MouseHover += new System.EventHandler(this.lblProfessio_MouseHover);
            // 
            // lblappointment
            // 
            resources.ApplyResources(this.lblappointment, "lblappointment");
            this.lblappointment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblappointment.Name = "lblappointment";
            this.lblappointment.Click += new System.EventHandler(this.lblappointment_Click);
            this.lblappointment.MouseLeave += new System.EventHandler(this.lblappointment_MouseLeave);
            this.lblappointment.MouseHover += new System.EventHandler(this.lblappointment_MouseHover);
            // 
            // lblPatient
            // 
            resources.ApplyResources(this.lblPatient, "lblPatient");
            this.lblPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Click += new System.EventHandler(this.lblPatient_Click);
            this.lblPatient.MouseLeave += new System.EventHandler(this.lblPatient_MouseLeave);
            this.lblPatient.MouseHover += new System.EventHandler(this.lblPatient_MouseHover);
            // 
            // lblStaff
            // 
            resources.ApplyResources(this.lblStaff, "lblStaff");
            this.lblStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Click += new System.EventHandler(this.lblStaff_Click);
            this.lblStaff.MouseLeave += new System.EventHandler(this.lblStaff_MouseLeave);
            this.lblStaff.MouseHover += new System.EventHandler(this.lblStaff_MouseHover);
            // 
            // lblsettings
            // 
            resources.ApplyResources(this.lblsettings, "lblsettings");
            this.lblsettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsettings.Name = "lblsettings";
            this.lblsettings.Click += new System.EventHandler(this.label1_Click_2);
            this.lblsettings.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.lblsettings.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // lblmedicines
            // 
            resources.ApplyResources(this.lblmedicines, "lblmedicines");
            this.lblmedicines.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmedicines.Name = "lblmedicines";
            this.lblmedicines.Click += new System.EventHandler(this.lblmedicines_Click);
            this.lblmedicines.MouseLeave += new System.EventHandler(this.lblmedicines_MouseLeave);
            this.lblmedicines.MouseHover += new System.EventHandler(this.lblmedicines_MouseHover);
            // 
            // mainpanel
            // 
            resources.ApplyResources(this.mainpanel, "mainpanel");
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainpanel.Controls.Add(this.label2);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Controls.Add(this.label);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Name = "label1";
            // 
            // label
            // 
            resources.ApplyResources(this.label, "label");
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Name = "label";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Navy;
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Pnlheader.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel Pnlheader;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblMian;
        private System.Windows.Forms.Label lblsettings;
        private System.Windows.Forms.Label lblSpecilization;
        private System.Windows.Forms.Label lblProfessio;
        private System.Windows.Forms.Label lblappointment;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblmedicines;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.Label lblusers;
        private System.Windows.Forms.Label label2;
    }
}

