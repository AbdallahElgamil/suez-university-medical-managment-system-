using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class staff_privildge : Form
    {
        public staff_privildge()
        {
            InitializeComponent();
        }
        public int staffMemberId;
        public string stafmemberjob;
        private  int jobId;
        DB db = new DB();
     
      
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void staff_privilege_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon("dentist.exe");
            if (stafmemberjob == "دكتور")
            {
                txtusername.Text = frmStaff.staffName;
                txtusername.Enabled = false;
            }
            else
            {
                txtusername.Text = "";
                txtusername.Enabled = true;
            }


        }
        regularExpression g = new regularExpression();
        private void btngive_Click(object sender, EventArgs e)
        {
            lblmessege.Text = "";
            if (g.checkName(txtusername.Text) & g.checkString(txtuserpass.Text))
            {
                DataTable tbl =
            db.getData("select * from login where userName ='" + txtusername.Text + "' and password ='" + txtuserpass.Text + "'");
                if (tbl.Rows.Count == 0)
                {

                    jobId = int.Parse((db.getData("select profession.professionId from profession where profession.professionName= '" + stafmemberjob + "'")).Rows[0][0].ToString());
                    db.run("insert into login values ('" + txtusername.Text + "','" + txtuserpass.Text + "'," + staffMemberId + "," + jobId + ")");
                    lblmessege.Text = "تم حفظ البيانات";
                }
                else lblmessege.Text = "بيانات موجوده مسبقا ";
            }
            else   lblmessege.Text = "تاكد من صحه البيانات";
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void staff_privildge_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
