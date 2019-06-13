namespace Clinic
{
    partial class frmBackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackUp));
            this.Pnlheader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTakeBackup = new System.Windows.Forms.Button();
            this.btnRestoreBackup = new System.Windows.Forms.Button();
            this.Pnlheader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnlheader
            // 
            resources.ApplyResources(this.Pnlheader, "Pnlheader");
            this.Pnlheader.BackColor = System.Drawing.Color.DodgerBlue;
            this.Pnlheader.Controls.Add(this.button1);
            this.Pnlheader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pnlheader.Name = "Pnlheader";
            this.Pnlheader.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlheader_Paint);
            this.Pnlheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnlheader_MouseDown);
            this.Pnlheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnlheader_MouseMove);
            this.Pnlheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnlheader_MouseUp);
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Name = "label4";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnTakeBackup, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRestoreBackup, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.Color.Navy;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // btnTakeBackup
            // 
            resources.ApplyResources(this.btnTakeBackup, "btnTakeBackup");
            this.btnTakeBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTakeBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeBackup.ForeColor = System.Drawing.Color.Navy;
            this.btnTakeBackup.Name = "btnTakeBackup";
            this.btnTakeBackup.UseVisualStyleBackColor = false;
            this.btnTakeBackup.Click += new System.EventHandler(this.btnTakeBackup_Click);
            // 
            // btnRestoreBackup
            // 
            resources.ApplyResources(this.btnRestoreBackup, "btnRestoreBackup");
            this.btnRestoreBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestoreBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoreBackup.ForeColor = System.Drawing.Color.Navy;
            this.btnRestoreBackup.Name = "btnRestoreBackup";
            this.btnRestoreBackup.UseVisualStyleBackColor = false;
            this.btnRestoreBackup.Click += new System.EventHandler(this.btnRestoreBackup_Click);
            // 
            // frmBackUp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Pnlheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackUp";
            this.Load += new System.EventHandler(this.frmBackUp_Load);
            this.Pnlheader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnlheader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTakeBackup;
        private System.Windows.Forms.Button btnRestoreBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}