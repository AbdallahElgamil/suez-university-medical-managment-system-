namespace Clinic
{
    partial class frmSpecialization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecialization));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvg2 = new System.Windows.Forms.DataGridView();
            this.lblmessege = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.spenum = new System.Windows.Forms.TextBox();
            this.spename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.mybutton3 = new Clinic.mybutton();
            this.mybutton2 = new Clinic.mybutton();
            this.mybutton1 = new Clinic.mybutton();
            this.privilegeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvg2
            // 
            resources.ApplyResources(this.dvg2, "dvg2");
            this.dvg2.AllowUserToAddRows = false;
            this.dvg2.AllowUserToDeleteRows = false;
            this.dvg2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dvg2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg2.BackgroundColor = System.Drawing.Color.White;
            this.dvg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.privilegeId,
            this.privilegeName});
            this.dvg2.Name = "dvg2";
            this.dvg2.ReadOnly = true;
            this.dvg2.RowTemplate.Height = 25;
            this.dvg2.Click += new System.EventHandler(this.dvg2_Click);
            // 
            // lblmessege
            // 
            resources.ApplyResources(this.lblmessege, "lblmessege");
            this.lblmessege.ForeColor = System.Drawing.Color.Red;
            this.lblmessege.Name = "lblmessege";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.Azure;
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.spenum, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.spename, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // spenum
            // 
            resources.ApplyResources(this.spenum, "spenum");
            this.spenum.Name = "spenum";
            this.spenum.TextChanged += new System.EventHandler(this.spenum_TextChanged);
            // 
            // spename
            // 
            resources.ApplyResources(this.spename, "spename");
            this.spename.Name = "spename";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.mybutton3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.mybutton2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.mybutton1, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Name = "label4";
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
            // privilegeId
            // 
            this.privilegeId.DataPropertyName = "specializationsId";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegeId.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.privilegeId, "privilegeId");
            this.privilegeId.Name = "privilegeId";
            this.privilegeId.ReadOnly = true;
            // 
            // privilegeName
            // 
            this.privilegeName.DataPropertyName = "specializationsName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegeName.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.privilegeName, "privilegeName");
            this.privilegeName.Name = "privilegeName";
            this.privilegeName.ReadOnly = true;
            // 
            // frmSpecialization
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblmessege);
            this.Controls.Add(this.dvg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSpecialization";
            this.Load += new System.EventHandler(this.Specialization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvg2;
        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.GroupBox groupBox3;
        private mybutton mybutton1;
        private mybutton mybutton2;
        private mybutton mybutton3;
        private System.Windows.Forms.TextBox spename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox spenum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegeName;
    }
}