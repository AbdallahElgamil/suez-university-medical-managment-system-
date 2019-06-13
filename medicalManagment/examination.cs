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
    public partial class examination : Form
    {
        public examination()
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

        private void intialize()
        {
            strNum = examnum.Text;
            strName = examcont.Text;

        }

        private void add()
        {

            object[] data = { strNum, strName };
            dvg2.Rows.Add(data);

        }


        private void edit()
        {
            if (dvg2.CurrentRow != null)
            {
                dvg2.CurrentRow.Cells[0].Value = examnum.Text;
                dvg2.CurrentRow.Cells[1].Value = examcont.Text;


            }
        }
        private void delete()
        {

            if (dvg2.CurrentRow != null)
            {
                //هنا ناديت على الميثود اللى اسمها رن اهو اللى بتنفزلى امر فى الداتا بيز من غير ما ترجعلى حاجه 
                //وادتها جملت الدليت بتاعتى ودليت فروم كذا بحيث ال اى دى يبقىى بتاع الرو اللى انا واقف عليه 
                dentist.DB.run("delete from examination where examinationId =" + dvg2.CurrentRow.Cells[0].Value);
                dvg2.Rows.Remove(dvg2.CurrentRow);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            intialize();
            try
            {
                lblmessege.Text = "";

                dentist.DB.run("insert into examination values (" + strNum + ",'" + strName + "')");
                add();
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                lblmessege.Text = "";
                intialize();
                dentist.DB.run("update examination set examinationContent ='" + strName + "' where examinationId =" + strNum);
                edit();
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }

        private void examination_Load(object sender, EventArgs e)
        {
            pereparedgvpr();

            dvg2.DataSource = dentist.DB.fillTable("select * from examination");
        }
    }
}
