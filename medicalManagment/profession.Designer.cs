namespace Clinic
{
    partial class frmprofession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprofession));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvg2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mybutton3 = new Clinic.mybutton();
            this.mybutton2 = new Clinic.mybutton();
            this.mybutton1 = new Clinic.mybutton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profid = new System.Windows.Forms.TextBox();
            this.profname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmessege = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dvg2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg2.BackgroundColor = System.Drawing.Color.White;
            this.dvg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dvg2.GridColor = System.Drawing.Color.White;
            this.dvg2.Name = "dvg2";
            this.dvg2.ReadOnly = true;
            this.dvg2.RowTemplate.Height = 25;
            this.dvg2.Click += new System.EventHandler(this.dvg2_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "professionId";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "professionName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.Azure;
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.mybutton3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.mybutton2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.mybutton1, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
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
            this.mybutton3.Click += new System.EventHandler(this.mybutton3_Click_1);
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
            this.mybutton2.Click += new System.EventHandler(this.mybutton2_Click_1);
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
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.profid, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.profname, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // profid
            // 
            resources.ApplyResources(this.profid, "profid");
            this.profid.Name = "profid";
            // 
            // profname
            // 
            resources.ApplyResources(this.profname, "profname");
            this.profname.Name = "profname";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Name = "label3";
            // 
            // lblmessege
            // 
            resources.ApplyResources(this.lblmessege, "lblmessege");
            this.lblmessege.ForeColor = System.Drawing.Color.Red;
            this.lblmessege.Name = "lblmessege";
            // 
            // frmprofession
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblmessege);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dvg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmprofession";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmprofession_FormClosing);
            this.Load += new System.EventHandler(this.profession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvg2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox profname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox profid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private mybutton mybutton3;
        private mybutton mybutton2;
        private mybutton mybutton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}