namespace Clinic
{
    partial class examination
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.examcont = new System.Windows.Forms.TextBox();
            this.examnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmessege = new System.Windows.Forms.Label();
            this.btndelete = new Clinic.MyTool();
            this.btnadd = new Clinic.MyTool();
            this.btnedit = new Clinic.MyTool();
            this.dvg2 = new System.Windows.Forms.DataGridView();
            this.privilegeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 23F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(378, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(124, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "الفحص";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(761, 185);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "محتوى العلاج :";
            // 
            // examcont
            // 
            this.examcont.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examcont.Location = new System.Drawing.Point(567, 181);
            this.examcont.Name = "examcont";
            this.examcont.Size = new System.Drawing.Size(160, 27);
            this.examcont.TabIndex = 27;
            // 
            // examnum
            // 
            this.examnum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examnum.Location = new System.Drawing.Point(567, 109);
            this.examnum.Name = "examnum";
            this.examnum.Size = new System.Drawing.Size(160, 27);
            this.examnum.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 113);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "رقم الفحص :";
            // 
            // lblmessege
            // 
            this.lblmessege.AutoSize = true;
            this.lblmessege.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessege.Location = new System.Drawing.Point(723, 474);
            this.lblmessege.Name = "lblmessege";
            this.lblmessege.Size = new System.Drawing.Size(0, 23);
            this.lblmessege.TabIndex = 45;
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
            this.btndelete.Location = new System.Drawing.Point(331, 485);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 53);
            this.btndelete.TabIndex = 44;
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
            this.btnadd.Location = new System.Drawing.Point(546, 426);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 53);
            this.btnadd.TabIndex = 43;
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
            this.btnedit.Location = new System.Drawing.Point(112, 426);
            this.btnedit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(115, 53);
            this.btnedit.TabIndex = 42;
            this.btnedit.Text = "تعديل*";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // dvg2
            // 
            this.dvg2.AllowUserToAddRows = false;
            this.dvg2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dvg2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dvg2.BackgroundColor = System.Drawing.Color.White;
            this.dvg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.privilegeId,
            this.privilegeName});
            this.dvg2.Location = new System.Drawing.Point(23, 75);
            this.dvg2.Name = "dvg2";
            this.dvg2.ReadOnly = true;
            this.dvg2.RowTemplate.Height = 25;
            this.dvg2.Size = new System.Drawing.Size(431, 344);
            this.dvg2.TabIndex = 46;
            // 
            // privilegeId
            // 
            this.privilegeId.DataPropertyName = "examinationId";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegeId.DefaultCellStyle = dataGridViewCellStyle17;
            this.privilegeId.HeaderText = "رقم الفحص";
            this.privilegeId.Name = "privilegeId";
            this.privilegeId.ReadOnly = true;
            this.privilegeId.Width = 200;
            // 
            // privilegeName
            // 
            this.privilegeName.DataPropertyName = "examinationContent";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegeName.DefaultCellStyle = dataGridViewCellStyle18;
            this.privilegeName.HeaderText = "محتوى الفحص";
            this.privilegeName.Name = "privilegeName";
            this.privilegeName.ReadOnly = true;
            this.privilegeName.Width = 180;
            // 
            // examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 569);
            this.Controls.Add(this.dvg2);
            this.Controls.Add(this.lblmessege);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.examcont);
            this.Controls.Add(this.examnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "examination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "examination";
            this.Load += new System.EventHandler(this.examination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox examcont;
        private System.Windows.Forms.TextBox examnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmessege;
        private MyTool btndelete;
        private MyTool btnadd;
        private MyTool btnedit;
        private System.Windows.Forms.DataGridView dvg2;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegeName;
    }
}