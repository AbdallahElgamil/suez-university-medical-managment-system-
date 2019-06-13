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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }
        Clinic.C c = new Clinic.C();

        // متتخضش من الميثود دى دى بس بتظبط شكل الداتا جريد فيو سيبك منها الوقتى 
        private void pereparedgvpr()
        {
            // dgvpr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvpr.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvpr.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12);
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


        string strNum;
        string strName;
        string strphone;
        string stremail;
        string strage;
        string straddress;
        string strgender;
        string strprofession;
        string strspecilizaion;
        object specilizationValue;
        public static string  staffName;
   
        DB db = new DB();
        DataTable tbl = new DataTable();
        regularExpression rgx = new regularExpression();

        private void intialize()
        {
            strNum = staffid.Text;
            strName = staffname.Text;
            straddress = staffaddress.Text;
            stremail = staffemail.Text;
            strage = staffage.Text;
            strgender = staffgender.SelectedItem.ToString();
            strphone = staffphone.Text;
            strprofession = staffprofession.Text;
            strspecilizaion = txtspecialization.Text;

        }
        public void getpatientformation()
        {
            if (dgvpr.CurrentRow != null)
            {
                staffName = dgvpr.CurrentRow.Cells[1].Value.ToString();
             

            }
        }
        private void intializecombobox()
        {

            staffgender.Items.Add("male");
            staffgender.Items.Add("female");
            staffgender.SelectedIndex = 0;

            if (dgvpr.RowCount > 0) staffgender.SelectedItem = dgvpr.CurrentRow.Cells[6].Value.ToString();

            DataTable tblprof = new DataTable();
            staffprofession.DataSource = db.fillTable("select * from profession where professionId!=0", tblprof);
            staffprofession.DisplayMember = "professionName";
            staffprofession.ValueMember = "professionId";

            DataTable tblspec = new DataTable();
            txtspecialization.DataSource = db.fillTable("select * from specializations where SpecializationsId!=0", tblspec);
            txtspecialization.DisplayMember = "specializationsName";
            txtspecialization.ValueMember = "specializationsId";


        }
        private void add()
        {

            object[] data = { strNum, strName, strprofession, strphone, stremail, strage, strgender, straddress, strspecilizaion };
            tbl.Rows.Add(data);

        }
        private void Adding()
        {
            //try
           // {


                lblmessege.Text = "";
                if (staffprofession.Text == "دكتور")
                    specilizationValue = txtspecialization.SelectedValue;
                else { specilizationValue = 0; strspecilizaion = ""; strspecilizaion = "------"; };





                db.run("insert into staff(staffId,staffName,professionId,address,email,age,gender,phone,SpecializationsId,active) values (" + strNum + ",'" + strName + "'," + staffprofession.SelectedValue + ",'" + straddress + "','" + stremail + "','" + strage + "','" + strgender + "','" + strphone + "'," + specilizationValue + ",1)");
                add();
                GetAuto();

            //}
            //catch (Exception ex)
            //{
            //    lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            //}
        }

        private void edit()
        {
            if (dgvpr.CurrentRow != null)
            {

                dgvpr.CurrentRow.Cells[1].Value = staffname.Text;
                dgvpr.CurrentRow.Cells[7].Value = staffaddress.Text;
                dgvpr.CurrentRow.Cells[4].Value = staffemail.Text;
                dgvpr.CurrentRow.Cells[5].Value = staffage.Text;
                dgvpr.CurrentRow.Cells[6].Value = staffgender.Text;
                dgvpr.CurrentRow.Cells[3].Value = staffphone.Text;
                dgvpr.CurrentRow.Cells[2].Value = staffprofession.Text;
                dgvpr.CurrentRow.Cells[8].Value = strspecilizaion;


            }

        }
        private void Editing()
        {
            try
            {

                if (staffprofession.Text == "دكتور")
                {
                    specilizationValue = txtspecialization.SelectedValue;

                }
                else { specilizationValue = 0; strspecilizaion = ""; strspecilizaion = "------"; };

                lblmessege.Text = "";

                db.run("update staff set staffName ='" + strName + "' ,phone ='" + strphone + "',email='" + stremail + "',age='" + strage + "',gender='" + strgender + "',professionID='" + staffprofession.SelectedValue + "',address='" + straddress + "',SpecializationsId='" + specilizationValue + "' where staffId =" + strNum);
                edit();
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void delete()
        {

            if (dgvpr.CurrentRow != null)
            {
                db.run("update appointment set active =0  where patientId =" + dgvpr.CurrentRow.Cells[0].Value);

                db.run("update  staff set active =0 where staffId =" + dgvpr.CurrentRow.Cells[0].Value);
                //dgvpr.DataSource = db.fillTable("select staff.staffId,staff.staffName,profession.professionName,staff.phone,staff.email,staff.age,staff.gender,staff.address,specializations.SpecializationsName from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where staff.professionId =profession.professionId and active =1", tbl);

                dgvpr.Rows.Remove(dgvpr.CurrentRow);
            }
        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetAuto()
        {
            DataTable GAtbl = db.getData("select max(staff.staffId)+1 from staff");
            staffid.Text = GAtbl.Rows[0][0].ToString();
            if (staffid.Text.Trim() == "") staffid.Text = "1";

        }
        private void Staff_Load(object sender, EventArgs e)
        {


            pereparedgvpr();

            dgvpr.DataSource = db.fillTable("select staff.staffId,staff.staffName,profession.professionName,staff.phone,staff.email,staff.age,staff.gender,staff.address,specializations.SpecializationsName from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where staff.professionId =profession.professionId and profession.professionId!=0 and active =1", tbl);
            intializecombobox();
            GetAuto();

        }


      
     

      



        
       

        private void btnadd_Click(object sender, EventArgs e)
        {
            GetAuto();
            intialize();
            if (rgx.checkId(strNum))
            {
                if (rgx.checkName(strName) & rgx.checkString(straddress))
                {
                    if (rgx.checkphone(strphone))
                    {
                        if (rgx.checkemail(stremail))
                        {
                            Adding();
                        }
                        else lblmessege.Text = "قم بادخال بريد الكترونى صحيح او اتركه فارغا  ";
                    }
                    else lblmessege.Text = "الرجاء ادخال رقم الهاتف فى صوره احدا عشر رقم   ";
                }
                else lblmessege.Text = "الرجاء ادخال اسم الموظف والعنوان فى صوره حروف عربيه او انجليزيه فقط ويسمح بلارقام فى العنوان  ";

            }
           

        }

        private void btnedit_Click_1(object sender, EventArgs e)
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
                            Editing();
                        }
                        else lblmessege.Text = "قم بادخال بريد الكترونى صحيح او اتركه فارغا ";
                    }
                    else lblmessege.Text = "الرجاء ادخال رقم الهاتف فى صوره احدا عشر رقم   ";
                }
                else lblmessege.Text = "الرجاء ادخال اسم الموظف والعنوان فى صوره حروف عربيه او انجليزيه فقط ويسمح بلارقام فى العنوان  ";

            }
            

        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            delete();
        }

        private void dgvpr_Click_1(object sender, EventArgs e)
        {
            if (dgvpr.CurrentRow != null & dgvpr.CurrentCell != null)
            {

                staffid.Text = dgvpr.CurrentRow.Cells[0].Value.ToString();
                staffname.Text = dgvpr.CurrentRow.Cells[1].Value.ToString();
                staffaddress.Text = dgvpr.CurrentRow.Cells[7].Value.ToString();
                staffemail.Text = dgvpr.CurrentRow.Cells[4].Value.ToString();
                staffage.Text = dgvpr.CurrentRow.Cells[5].Value.ToString();
                staffgender.Text = dgvpr.CurrentRow.Cells[6].Value.ToString();
                staffphone.Text = dgvpr.CurrentRow.Cells[3].Value.ToString();
                staffprofession.Text = dgvpr.CurrentRow.Cells[2].Value.ToString();
                txtspecialization.Text = dgvpr.CurrentRow.Cells[8].Value.ToString();
                btnedit.Enabled = true;
                btndelete.Enabled = true;



            }
            else
            {
                btnedit.Enabled = false;
                btndelete.Enabled = false;

            }
        }

        private void btnprivilege_Click(object sender, EventArgs e)
        {

            if (dgvpr.CurrentRow != null)
            {
                getpatientformation();
                staff_privildge sp = new staff_privildge();
                sp.staffMemberId = Int32.Parse(dgvpr.CurrentRow.Cells[0].Value.ToString());
                sp.stafmemberjob = dgvpr.CurrentRow.Cells[2].Value.ToString();
                sp.Show();

            }
        }

        private void staffprofession_TextChanged(object sender, EventArgs e)
        {
            if (staffprofession.Text == "دكتور")
            {
                lblspecialization.Visible = true;
                txtspecialization.Visible = true;
            }
            else
            {

                lblspecialization.Visible = false;
                txtspecialization.Visible = false;
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            dgvpr.DataSource = tbl;
            btnback.Visible = false;
            btnsearch.Visible = true;
            txtsearch.Text = "";
        }

     

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            lblmessege.Text = "";
            if (rgx.checkphone(txtsearch.Text))
            {
                DataTable tblSearch = new DataTable();
                db.fillTable("select staff.staffId,staff.staffName,profession.professionName,staff.phone,staff.email,staff.age,staff.gender,staff.address,specializations.SpecializationsName from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where staff.professionId =profession.professionId and active=1 and phone='" + txtsearch.Text + "'", tblSearch);
                dgvpr.DataSource = tblSearch;
                btnback.Visible = true;
                btnsearch.Visible = false;
            }
            else lblmessege.Text = "الرجاء ادخال رقم الهاتف فى صوره احدا عشر رقم   ";

        }

        private void mybutton1_Click(object sender, EventArgs e)
        {
            frmReportStaff f = new frmReportStaff();
            Clinic.C.RunReportstaff("select staff.staffId,staff.staffName,profession.professionName,staff.phone,staff.email,staff.age,staff.gender,staff.address,specializations.SpecializationsName, (select count(staffId) from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId ) as countstaff  from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId ", f);
            f.Show();
        }

        private void staffprofession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (staffprofession.SelectedIndex == 0 | staffprofession.SelectedIndex == 2 | staffprofession.SelectedIndex == 1)
                btnprivilege.Enabled = true;
            else
                btnprivilege.Enabled = false;
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text == "رقم الهاتف 00")
            {
                txtsearch.Text = "";
                txtsearch.ForeColor = Color.Black;
            }
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                txtsearch.Text = "رقم الهاتف 00";
                txtsearch.ForeColor = Color.DarkGray;
            }
        }

     
    }
}
