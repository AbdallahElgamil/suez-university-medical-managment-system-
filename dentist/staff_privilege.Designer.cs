namespace Clinic
{
    partial class staff_privildge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staff_privildge));
            this.Pnlheader = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmessege = new System.Windows.Forms.Label();
            this.txtuserpass = new System.Windows.Forms.TextBox();
            this.btngive = new Clinic.mybutton();
            this.Pnlheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnlheader
            // 
            resources.ApplyResources(this.Pnlheader, "Pnlheader");
            this.Pnlheader.BackColor = System.Drawing.Color.CadetBlue;
            this.Pnlheader.Controls.Add(this.button3);
            this.Pnlheader.Controls.Add(this.button2);
            this.Pnlheader.Controls.Add(this.button1);
            this.Pnlheader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pnlheader.Name = "Pnlheader";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // txtusername
            // 
            resources.ApplyResources(this.txtusername, "txtusername");
            this.txtusername.Name = "txtusername";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // lblmessege
            // 
            resources.ApplyResources(this.lblmessege, "lblmessege");
            this.lblmessege.Name = "lblmessege";
            // 
            // txtuserpass
            // 
            resources.ApplyResources(this.txtuserpass, "txtuserpass");
            this.txtuserpass.Name = "txtuserpass";
            // 
            // btngive
            // 
            resources.ApplyResources(this.btngive, "btngive");
            this.btngive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btngive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btngive.ForeColor = System.Drawing.Color.Navy;
            this.btngive.Name = "btngive";
            this.btngive.UseVisualStyleBackColor = false;
            this.btngive.Click += new System.EventHandler(this.btngive_Click);
            // 
            // staff_privildge
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtuserpass);
            this.Controls.Add(this.lblmessege);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngive);
            this.Controls.Add(this.Pnlheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staff_privildge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.staff_privildge_FormClosing);
            this.Load += new System.EventHandler(this.staff_privilege_Load);
            this.Pnlheader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pnlheader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private mybutton btngive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.TextBox txtuserpass;
    }
}