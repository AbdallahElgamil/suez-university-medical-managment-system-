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
    public partial class frmSpecialization : Form
    {
        public frmSpecialization()
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
            strNum = spenum.Text;
            strName = spename.Text;

        }

        private void add()
        {

            object[] data = { strNum, strName };
            tbl.Rows.Add(data);

        }
        private void Adding()
        {
            try
            {
                lblmessege.Text = "";

                db.run("insert into specializations values (" + strNum + ",'" + strName + "')");
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
                dvg2.CurrentRow.Cells[0].Value = spenum.Text;
                dvg2.CurrentRow.Cells[1].Value = spename.Text;


            }
        }
        private void Editing()
        {
            try
            {
                lblmessege.Text = "";
               
                db.run("update specializations set specializationsName ='" + strName + "' where specializationsId =" + strNum);
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
                db.run("delete from specializations where specializationsId =" + dvg2.CurrentRow.Cells[0].Value);
                dvg2.Rows.Remove(dvg2.CurrentRow);
            }
        }

        

      

        private void Specialization_Load(object sender, EventArgs e)
        {
            pereparedgvpr();

            dvg2.DataSource = db.fillTable("select * from specializations where SpecializationsId!=0", tbl);
            GetAuto();
        }
        private void GetAuto()
        {
            DataTable GAtbl = db.getData("select max(specializations.specializationsId)+1 from specializations");
            spenum.Text = GAtbl.Rows[0][0].ToString();
            if (spenum.Text.Trim() == "") spenum.Text = "1";

        }
        
        private void dvg2_Click(object sender, EventArgs e)
        {
            if (dvg2.CurrentRow != null)
            {
                spenum.Text = dvg2.CurrentRow.Cells[0].Value.ToString();
                spename.Text = dvg2.CurrentRow.Cells[1].Value.ToString();
                mybutton1.Enabled = true;
                mybutton3.Enabled = true;
            }
            else
            {
                mybutton1.Enabled = false;
                mybutton3.Enabled = false;

            }
        }

        private void mybutton2_Click(object sender, EventArgs e)
        {
            intialize();
            if (rgx.checkId(strNum))
            {
                if (rgx.checkName(strName))
                {

                    Adding();

                }
                else lblmessege.Text = "الرجاء ادخال اسم التخصص فى صوره حروف عربيه او انجليزيه فقط  ";

            }
            else lblmessege.Text = "يرجى ادخال رقم صحيح فى خانه رقم التخصص ";
            GetAuto();
        }

        private void mybutton1_Click(object sender, EventArgs e)
        {
            intialize();
            if (rgx.checkId(strNum))
            {
                if (rgx.checkName(strName))
                {

                    Editing();

                }
                else lblmessege.Text = "الرجاء ادخال اسم التخصص فى صوره حروف عربيه او انجليزيه فقط  ";

            }
            else lblmessege.Text = "يرجى ادخال رقم صحيح فى خانه رقم التخصص ";
            GetAuto();
        }

        private void mybutton3_Click(object sender, EventArgs e)
        {
            delete();
            GetAuto();
        }

        private void spenum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
