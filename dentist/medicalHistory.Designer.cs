namespace Clinic
{
    partial class frmMedicalHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvg2 = new System.Windows.Forms.DataGridView();
            this.privilegeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txthistname = new System.Windows.Forms.TextBox();
            this.txthistnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmessege = new System.Windows.Forms.Label();
            this.btndelete = new Clinic.MyTool();
            this.btnadd = new Clinic.MyTool();
            this.btnedit = new Clinic.MyTool();
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg2
            // 
            this.dvg2.AllowUserToAddRows = false;
            this.dvg2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dvg2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg2.BackgroundColor = System.Drawing.Color.White;
            this.dvg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.privilegeId,
            this.privilegeName});
            this.dvg2.Location = new System.Drawing.Point(455, 62);
            this.dvg2.Name = "dvg2";
            this.dvg2.ReadOnly = true;
            this.dvg2.RowTemplate.Height = 25;
            this.dvg2.Size = new System.Drawing.Size(431, 344);
            this.dvg2.TabIndex = 1;
            this.dvg2.SelectionChanged += new System.EventHandler(this.dvg2_SelectionChanged);
            // 
            // privilegeId
            // 
            this.privilegeId.DataPropertyName = "medicalHistoryId";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegeId.DefaultCellStyle = dataGridViewCellStyle2;
            this.privilegeId.HeaderText = "رقم التاريخ";
            this.privilegeId.Name = "privilegeId";
            this.privilegeId.ReadOnly = true;
            this.privilegeId.Width = 200;
            // 
            // privilegeName
            // 
            this.privilegeName.DataPropertyName = "medicalHistoryName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegeName.DefaultCellStyle = dataGridViewCellStyle3;
            this.privilegeName.HeaderText = "اسم التاريخ ";
            this.privilegeName.Name = "privilegeName";
            this.privilegeName.ReadOnly = true;
            this.privilegeName.Width = 180;
            // 
            // txthistname
            // 
            this.txthistname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthistname.Location = new System.Drawing.Point(12, 143);
            this.txthistname.Multiline = true;
            this.txthistname.Name = "txthistname";
            this.txthistname.Size = new System.Drawing.Size(160, 20);
            this.txthistname.TabIndex = 9;
            // 
            // txthistnum
            // 
            this.txthistnum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthistnum.Location = new System.Drawing.Point(12, 71);
            this.txthistnum.Name = "txthistnum";
            this.txthistnum.Size = new System.Drawing.Size(160, 27);
            this.txthistnum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "رقم الشكوى :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 23F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(296, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(409, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "الشكاوى المرضيه السابقه ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "محتوى الشكوى  :";
            // 
            // lblmessege
            // 
            this.lblmessege.AutoSize = true;
            this.lblmessege.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessege.Location = new System.Drawing.Point(31, 250);
            this.lblmessege.Name = "lblmessege";
            this.lblmessege.Size = new System.Drawing.Size(0, 23);
            this.lblmessege.TabIndex = 41;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.MediumBlue;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btndelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.btndelete.Location = new System.Drawing.Point(368, 501);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 53);
            this.btndelete.TabIndex = 40;
            this.btndelete.Text = "حذف*";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.MediumBlue;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(583, 442);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 53);
            this.btnadd.TabIndex = 39;
            this.btnadd.Text = "إضافة*";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.MediumBlue;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(149, 442);
            this.btnedit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(115, 53);
            this.btnedit.TabIndex = 38;
            this.btnedit.Text = "تعديل*";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // frmMedicalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 569);
            this.Controls.Add(this.lblmessege);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthistname);
            this.Controls.Add(this.txthistnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMedicalHistory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.medicalHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg2;
        private System.Windows.Forms.TextBox txthistname;
        private System.Windows.Forms.TextBox txthistnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MyTool btndelete;
        private MyTool btnadd;
        private MyTool btnedit;
        private System.Windows.Forms.Label lblmessege;
    }
}