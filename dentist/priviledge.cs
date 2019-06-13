using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class frmPriviledge : Form
    {
        public frmPriviledge()
        {
            InitializeComponent();
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        string olduser;
        string oldpass;
        private void pereparedgvpr()
        {
            dgvpr.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvpr.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvpr.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvpr.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvpr.BorderStyle = BorderStyle.None;
            dgvpr.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvpr.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvpr.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvpr.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvpr.BackgroundColor = Color.White;

            dgvpr.EnableHeadersVisualStyles = false;
            dgvpr.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvpr.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvpr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        
        private void form2_Load(object sender, EventArgs e)
        {
            DB.open();
            
            pereparedgvpr();

            dgvpr.DataSource = db.fillTable("select login.userName,login.password,staff.staffName,profession.professionName,login.staffId from login,profession,staff where staff.staffId=login.staffId and profession.professionId=login.role and profession.professionId!=0", tbl);
            dgvpr.Columns["staffId"].Visible = false;


        }

        


    
    
       
   
        private void delete()
        {

            if (dgvpr.CurrentRow != null)
            {
                db.run("delete from login where staffId =" + dgvpr.CurrentRow.Cells[4].Value);
                dgvpr.Rows.Remove(dgvpr.CurrentRow);
            }
        }


        

       
      
        
        private void dgvpr_Click(object sender, EventArgs e)
        {
            if (dgvpr.CurrentRow.Cells[3].Value.ToString()=="دكتور")
            {
                txtname.Enabled = false;
            }

            else txtname.Enabled = true;

            if (dgvpr.CurrentRow != null)
            {
                txtname.Text = dgvpr.CurrentRow.Cells[0].Value.ToString();
                txtpass.Text = dgvpr.CurrentRow.Cells[1].Value.ToString();
               olduser = dgvpr.CurrentRow.Cells[0].Value.ToString();
               oldpass = dgvpr.CurrentRow.Cells[1].Value.ToString();
                btndelete.Enabled = true;
                btnedit.Enabled = true;
            }
            else { 
            btndelete.Enabled = false;
            btnedit.Enabled = false;
        }
    }

        private void mybutton3_Click_1(object sender, EventArgs e)
        {
            delete();

        }
        private void edit()
        {
            if (dgvpr.CurrentRow != null)
            {
                dgvpr.CurrentRow.Cells[0].Value = txtname.Text;
                dgvpr.CurrentRow.Cells[1].Value = txtpass.Text;


            }
        }
        private void Editing()
        {
            try
            {
                lblmessege.Text = "";

                DataTable tbl =
         db.getData("select * from login where userName ='" + txtname.Text + "' and password ='" + txtpass.Text + "'");

                if (tbl.Rows.Count == 0)
                {
                    db.run("update login set userName ='" + txtname.Text + "' , password ='" + txtpass.Text + "' where userName='" + olduser + "' and password ='" + oldpass + "'");
                    edit();
                }

                else lblmessege.Text = "بيانات موجوده مسبقا ";
                
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        regularExpression rgx = new regularExpression();
        private void btnedit_Click(object sender, EventArgs e)
        {
            
            if (rgx.checkName(txtname.Text))
            {
                if (rgx.checkString(txtpass.Text))
                {

                    Editing();

                }
               

            }
            else lblmessege.Text = "تاكد من صحه البيانات ";
        }
    }
}
