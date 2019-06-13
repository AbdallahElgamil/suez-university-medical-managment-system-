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
    public partial class frmMedicalHistory : Form
    {
        public frmMedicalHistory()
        {
            InitializeComponent();
        }

        // متتخضش من الميثود دى دى بس بتظبط شكل الداتا جريد فيو سيبك منها الوقتى 
        private void pereparedgvpr()
        {
            // dgvpr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvg2.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dvg2.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dvg2.BorderStyle = BorderStyle.None;
            dvg2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dvg2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvg2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dvg2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dvg2.BackgroundColor = Color.White;

            dvg2.EnableHeadersVisualStyles = false;
            dvg2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dvg2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dvg2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        string strNum;
        string strName;
        DB db = new DB();
        DataTable tbl = new DataTable();
        private void intialize()
        {
            strNum = txthistnum.Text;
            strName = txthistname.Text;

        }

        private void add()
        {

            object[] data = { strNum, strName };
            tbl.Rows.Add(data);

        }

        private void edit()
        {
            if (dvg2.CurrentRow != null)
            {
               
                dvg2.CurrentRow.Cells[1].Value = txthistname.Text;


            }
        }
        private void delete()
        {

            if (dvg2.CurrentRow != null)
            {
                //هنا ناديت على الميثود اللى اسمها رن اهو اللى بتنفزلى امر فى الداتا بيز من غير ما ترجعلى حاجه 
                //وادتها جملت الدليت بتاعتى ودليت فروم كذا بحيث ال اى دى يبقىى بتاع الرو اللى انا واقف عليه 
                db.run("delete from medicalHistory where medicalHistoryId =" + dvg2.CurrentRow.Cells[0].Value);
                dvg2.Rows.Remove(dvg2.CurrentRow);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            intialize();
            try
            {
                lblmessege.Text = "";

                db.run("insert into medicalHistory values (" + strNum + ",'" + strName + "')");
                add();
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                lblmessege.Text = "";
                intialize();
                db.run("update medicalHistory set medicalHistoryName ='" + strName + "' where medicalHistoryId =" + strNum);
                edit();
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void medicalHistory_Load(object sender, EventArgs e)
        {
            DB.open();
            pereparedgvpr();

            dvg2.DataSource = db.fillTable("select * from medicalHistory",tbl);
        }

        private void dvg2_SelectionChanged(object sender, EventArgs e)
        {
            if (dvg2.RowCount > 0)
            {
                txthistnum.Text = dvg2.CurrentRow.Cells[0].Value.ToString();
                txthistname.Text = dvg2.CurrentRow.Cells[1].Value.ToString();

            }
            
        }
    }
}
