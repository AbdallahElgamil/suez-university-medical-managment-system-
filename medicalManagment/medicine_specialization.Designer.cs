namespace Clinic
{
    partial class medicine_specialization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicine_specialization));
            this.label1 = new System.Windows.Forms.Label();
            this.Pnlheader = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxmedicine = new System.Windows.Forms.ListBox();
            this.lblspecilization = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownamount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDowntime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmessege = new System.Windows.Forms.Label();
            this.btnAdd = new Clinic.mybutton();
            this.newMedicine = new System.Windows.Forms.TextBox();
            this.btnaddNew = new Clinic.mybutton();
            this.Pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pnlheader
            // 
            resources.ApplyResources(this.Pnlheader, "Pnlheader");
            this.Pnlheader.BackColor = System.Drawing.Color.DarkCyan;
            this.Pnlheader.Controls.Add(this.button4);
            this.Pnlheader.Controls.Add(this.button2);
            this.Pnlheader.Controls.Add(this.button1);
            this.Pnlheader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pnlheader.Name = "Pnlheader";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // lbxmedicine
            // 
            resources.ApplyResources(this.lbxmedicine, "lbxmedicine");
            this.lbxmedicine.FormattingEnabled = true;
            this.lbxmedicine.Name = "lbxmedicine";
            this.lbxmedicine.Click += new System.EventHandler(this.lbxmedicine_Click);
            this.lbxmedicine.SelectedIndexChanged += new System.EventHandler(this.lbxprivilege_SelectedIndexChanged);
            this.lbxmedicine.DoubleClick += new System.EventHandler(this.lbxmedicine_DoubleClick);
            // 
            // lblspecilization
            // 
            resources.ApplyResources(this.lblspecilization, "lblspecilization");
            this.lblspecilization.ForeColor = System.Drawing.Color.Blue;
            this.lblspecilization.Name = "lblspecilization";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Name = "label2";
            // 
            // numericUpDownamount
            // 
            resources.ApplyResources(this.numericUpDownamount, "numericUpDownamount");
            this.numericUpDownamount.Name = "numericUpDownamount";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Name = "label3";
            // 
            // numericUpDowntime
            // 
            resources.ApplyResources(this.numericUpDowntime, "numericUpDowntime");
            this.numericUpDowntime.Name = "numericUpDowntime";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // lblmessege
            // 
            resources.ApplyResources(this.lblmessege, "lblmessege");
            this.lblmessege.ForeColor = System.Drawing.Color.Red;
            this.lblmessege.Name = "lblmessege";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.ForeColor = System.Drawing.Color.Navy;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // newMedicine
            // 
            resources.ApplyResources(this.newMedicine, "newMedicine");
            this.newMedicine.Name = "newMedicine";
            this.newMedicine.TextChanged += new System.EventHandler(this.newMedicine_TextChanged);
            // 
            // btnaddNew
            // 
            resources.ApplyResources(this.btnaddNew, "btnaddNew");
            this.btnaddNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnaddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btnaddNew.ForeColor = System.Drawing.Color.Navy;
            this.btnaddNew.Name = "btnaddNew";
            this.btnaddNew.UseVisualStyleBackColor = false;
            this.btnaddNew.Click += new System.EventHandler(this.btngive_Click);
            // 
            // medicine_specialization
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.newMedicine);
            this.Controls.Add(this.lblmessege);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDowntime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblspecilization);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaddNew);
            this.Controls.Add(this.Pnlheader);
            this.Controls.Add(this.lbxmedicine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "medicine_specialization";
            this.Load += new System.EventHandler(this.medicine_specialization_Load);
            this.Pnlheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clinic.mybutton btnaddNew;
        private System.Windows.Forms.Panel Pnlheader;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxmedicine;
        private System.Windows.Forms.Label lblspecilization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDowntime;
        private System.Windows.Forms.Label label4;
        private mybutton btnAdd;
        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.TextBox newMedicine;
    }
}