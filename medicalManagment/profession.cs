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
    public partial class frmprofession : Form
    {
        public frmprofession()
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
        regularExpression rgx = new regularExpression();
        private void intialize()
        {
            strNum = profid.Text;
            strName = profname.Text;
          
        }

        private void add()
        {

            object[] data = { strNum, strName};
            tbl.Rows.Add(data);

        }
        private void Adding()
        {
            try
            {
                lblmessege.Text = "";

                db.run("insert into profession values (" + strNum + ",'" + strName + "')");
                add();
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }

        private void edit()
        {
            if (dvg2.CurrentRow != null)
            {
                
                dvg2.CurrentRow.Cells[1].Value = profname.Text;


            }
        }
        private void Editing()
        {
            try
            {
                lblmessege.Text = "";
                
                db.run("update profession set professionName ='" + strName + "' where professionId =" + strNum);
                edit();
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void delete()
        {

            if (dvg2.CurrentRow != null)
            {
             
                db.run("delete from profession where professionId =" + dvg2.CurrentRow.Cells[0].Value);
                dvg2.Rows.Remove(dvg2.CurrentRow);
            }
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      

        private void profession_Load(object sender, EventArgs e)

        {
            
            pereparedgvpr();

            dvg2.DataSource = db.fillTable("select * from profession where profession.professionId!=0 ", tbl);
            GetAuto();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            delete();

        }
       

        private void frmprofession_FormClosing(object sender, FormClosingEventArgs e)
        {
           DB.close();
        }

      

        private void lblprofession_Click(object sender, EventArgs e)
        {

        }
        private void GetAuto()
        {
            DataTable GAtbl = db.getData("select max(profession.professionId)+1 from profession");
            profid.Text = GAtbl.Rows[0][0].ToString();
            if (profid.Text.Trim() == "") profid.Text = "1";

        }
      
      

        private void dvg2_Click(object sender, EventArgs e)
        {
            if (dvg2.CurrentRow !=null)
            {

                profid.Text = dvg2.CurrentRow.Cells[0].Value.ToString();
                profname.Text = dvg2.CurrentRow.Cells[1].Value.ToString();
                mybutton2.Enabled = true;
                mybutton3.Enabled = true;

            }
            else
            {
                mybutton2.Enabled = false;
                mybutton3.Enabled = false;

            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mybutton2_Click_1(object sender, EventArgs e)
        {
            intialize();
            if (rgx.checkId(strNum))
            {
                if (rgx.checkName(strName))
                {

                    Editing();

                }
                else lblmessege.Text = "الرجاء ادخال اسم الوظيفه فى صوره حروف عربيه او انجليزيه فقط  ";

            }
            else lblmessege.Text = "يرجى ادخال رقم صحيح فى خانه رقم الوظيفه ";
            GetAuto();
        }

        private void mybutton1_Click(object sender, EventArgs e)
        {
            intialize();
            if (rgx.checkId(strNum))
            {
                if (rgx.checkName(strName))
                {

                    Adding();

                }
                else lblmessege.Text = "الرجاء ادخال اسم الوظيفه فى صوره حروف عربيه او انجليزيه فقط  ";

            }
            else lblmessege.Text = "يرجى ادخال رقم صحيح فى خانه رقم الوظيفه ";
            GetAuto();
        }

        private void mybutton3_Click_1(object sender, EventArgs e)
        {
            if (dvg2.CurrentCell.RowIndex > 2)
                delete();
            else lblmessege.Text = "لا يمكن حذف الوظائف الاساسيه ";
        }
    }
}
