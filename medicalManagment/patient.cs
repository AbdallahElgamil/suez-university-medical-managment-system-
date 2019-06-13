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
    public partial class frmpatient : Form
    {
        public frmpatient()
        {
            InitializeComponent();
        }
        private void pereparedgv()
        {
            // dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 11);
            dgv.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 11);
            dgv.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 11);
            dgv.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 11);
            dgv.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 11);
            dgv.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 11);
            dgv.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 11);
            dgv.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 11);
            dgv.Columns[8].HeaderCell.Style.Font = new Font("Tahoma", 11);
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }







        string strNum ;
        string strName;
        string straddress;
        string stremail ;
        string strage ;
        string strphone;
        string strgender;
        string strfaculty;
        string strlevel;

        DB db = new DB();
        DataTable tbl = new DataTable();
        regularExpression rgx = new regularExpression();
        
         

        private void intialize()
        {
         strNum = txtnum.Text;
         strName = txtname.Text;
         straddress = txtadress.Text;
         stremail = txtemail.Text;
         strage = txtage.Text;
            strphone = txtphone.Text;
            strgender = txtgender.SelectedItem.ToString();
            strfaculty = comboFaculty.Text;
            strlevel = comboLevel.Text;
        }
       
        private void intializecombobox()
        {
            txtgender.Items.Add("male");
            txtgender.Items.Add("female");
            txtgender.SelectedIndex = 0;
            if (dgv.RowCount > 0) txtgender.SelectedItem = dgv.CurrentRow.Cells[6].Value.ToString();

            DataTable tblfaculty = new DataTable();
            comboFaculty.DataSource = db.fillTable("select * from faculty", tblfaculty);
            comboFaculty.DisplayMember = "facultyName";
            comboFaculty.ValueMember = "facultyId";

            DataTable tbllevel = new DataTable();
            comboLevel.DataSource = db.fillTable("select * from level", tbllevel);
            comboLevel.DisplayMember = "levelName";
            comboLevel.ValueMember = "levelId";


        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        DB.open();
            intializecombobox();
            dgv.DataSource = db.fillTable("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1  ", tbl);
            pereparedgv();
            GetAuto();
            if (frmMain.systemuser==2)
            {
                btnadd.Enabled = false;
                btndel.Enabled = false;
                btnedit.Enabled = false;
            }
            
        }

        private void add()
        {

            object[] data = { strNum, strName, strphone, stremail, strage, strgender, straddress,strfaculty,strlevel };

            tbl.Rows.Add(data);


        }
        private void Adding()
        {
            try
            {


                

                lblmessege.Text = "";

                db.run("insert into patient values (" + strNum + ",'" + strName + "','" + strphone + "','" + stremail + "','" + strage + "','" + strgender + "','" + straddress + "',"+comboFaculty.SelectedValue+","+comboLevel.SelectedValue+",1)");
                add();
                GetAuto();

            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void GetAuto()
        {
            DataTable GAtbl = db.getData("select max(patient.patientId)+1 from patient");
            txtnum.Text = GAtbl.Rows[0][0].ToString();
            if (txtnum.Text.Trim() == "") txtnum.Text = "1";

        }
        private void edit()
        {
            if (dgv.CurrentRow != null)
            {
                
                dgv.CurrentRow.Cells[1].Value = txtname.Text;
                dgv.CurrentRow.Cells[6].Value = txtadress.Text;
                dgv.CurrentRow.Cells[3].Value = txtemail.Text;
                dgv.CurrentRow.Cells[4].Value = txtage.Text;
                dgv.CurrentRow.Cells[2].Value = txtphone.Text;
                dgv.CurrentRow.Cells[5].Value = txtgender.Text;
                dgv.CurrentRow.Cells[7].Value = comboFaculty.Text;
                dgv.CurrentRow.Cells[8].Value = comboLevel.Text;

            }

        }
        private void Editing()
        {
            try
            {
                lblmessege.Text = "";
                
                db.run("update patient set patientName ='" + strName + "',address ='" + straddress
                    + "',email ='" + stremail + "',age ='" + strage
                    + "',phone ='" + strphone +"', facultyId ="+comboFaculty.SelectedValue+", levelId ="+comboLevel.SelectedValue
                    +", active=1"
                        + " where patientId =" + strNum);
                edit();
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void delete()
        {

            if (dgv.CurrentRow != null)
            {
                db.run("update appointment set active =0  where patientId =" + dgv.CurrentRow.Cells[0].Value);
                db.run("update  patient set active =0  where patientId =" + dgv.CurrentRow.Cells[0].Value);
                dgv.Rows.Remove(dgv.CurrentRow);
                //dgv.DataSource = db.fillTable("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1  ", tbl);
            }
        }
       

        


     
       

      
        
        

      
       
       

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            lblmessege.Text = "";
            if (rgx.checkphone(txtsearch.Text))
            {
                DataTable tblSearch = new DataTable();
                db.fillTable("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and phone='" + txtsearch.Text + "'", tblSearch);
                dgv.DataSource = tblSearch;
                btnback.Visible = true;
                btnsearch.Visible = false;
            }
           else if (rgx.checkBarCode(txtsearch.Text))
            {
                DataTable tblSearch = new DataTable();
                db.fillTable("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId='" + txtsearch.Text + "'", tblSearch);
                dgv.DataSource = tblSearch;
                btnback.Visible = true;
                btnsearch.Visible = false;
            }
            else lblmessege.Text = "الرجاء ادخل البار كود او رقم الهاتف فى صوره صحيحه وعدد ارقام صحيح   ";
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            dgv.DataSource = tbl;
            btnback.Visible = false;
            btnsearch.Visible = true;
            txtsearch.Text = "";
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            intialize();
            if (rgx.checkId(strNum))
            {
                if (rgx.checkName(strName) & rgx.checkString(straddress))
                {
                    if (rgx.checkphone(strphone))
                    {
                        if (rgx.checkemail(stremail))
                        {
                            if (rgx.checkage(strage))
                            {
                                Editing();
                                GetAuto();
                            }
                            else lblmessege.Text = "الرجاء ادخال السن فى صوره ارقام صحيحه لا تتجاوز الثلث خانات  ";
                        }
                        else lblmessege.Text = "قم بادخال بريد الكترونى صحيح او اتركه فارغا ";
                    }
                    else lblmessege.Text = "الرجاء ادخال رقم الهاتف فى صوره احدا عشر رقم   ";
                }
                else lblmessege.Text = "الرجاء ادخال اسم الطالب والعنوان فى صوره حروف عربيه او انجليزيه فقط ويسمح بلارقام فى العنوان   ";

            }
            else lblmessege.Text = "يرجى ادخال رقم صحيح فى خانه كود الطالب ";

        
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            intialize();
            if (rgx.checkId(strNum))
            {
                if (rgx.checkName(strName) & rgx.checkString(straddress))
                {
                    if (rgx.checkphone(strphone))
                    {
                        if (rgx.checkemail(stremail))
                        {
                            if (rgx.checkage(strage))
                            {
                                Adding();
                                GetAuto();
                            }
                            else lblmessege.Text = "الرجاء ادخال السن فى صوره اقام صحيحه لا تتجاوز الثلث خانات  ";
                        }
                        else lblmessege.Text = "قم بادخال بريد الكترونى صحيح او اتركه فارغا  ";
                    }
                    else lblmessege.Text = "الرجاء ادخال رقم الهاتف فى صوره احدا عشر رقم    ";
                }
                else lblmessege.Text = "الرجاء ادخال اسم الطالب  والعنوان فى صوره حروف عربيه او انجليزيه فقط ويسمح بلارقام فى العنوان   ";

            }
            else lblmessege.Text = "يرجى ادخال رقم الطالب فى خانه كود الطالب ";

           

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            delete();
            GetAuto();
        }

        private void dgv_Click_1(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {

                txtnum.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txtname.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txtadress.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                txtemail.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                txtage.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                txtphone.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txtgender.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                comboFaculty.Text = dgv.CurrentRow.Cells[7].Value.ToString();
                comboLevel.Text = dgv.CurrentRow.Cells[8].Value.ToString();
                btndel.Enabled = true;
                btnedit.Enabled = true;
            }
            else
            {
                btndel.Enabled = false;
                btnedit.Enabled = false;
            }
        }
        

        private void mybutton1_Click(object sender, EventArgs e)
        {
            frmReportPatient p = new frmReportPatient();
           
            Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId  ) as countpatient  from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId  ", p);
            p.Show();
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text== "رقم الهاتف/بار كود")
            {
                txtsearch.Text = "";
                txtsearch.ForeColor = Color.Black;
            }
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            if (txtsearch.Text =="")
            {
                txtsearch.Text = "رقم الهاتف/ بار كود";
                txtsearch.ForeColor = Color.DarkGray;
            }
        }
    }
}
