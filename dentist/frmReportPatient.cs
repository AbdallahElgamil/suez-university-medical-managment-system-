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
    public partial class frmReportPatient : Form
    {
        public frmReportPatient()
        {
            InitializeComponent();
        }
        DB db = new DB();

        private bool mousdown = false;
        private Point lastLOcation;

        private void intializecombooboxes()
        {
            DataTable tblname = new DataTable();
            cname.DataSource = db.fillTable("select distinct patient.patientId,patient.patientName from patient ", tblname);
            cname.DisplayMember = "patientName";
            cname.ValueMember = "patientId";

            DataTable tblfaculty = new DataTable();
            cfaculty.DataSource = db.fillTable("select faculty.facultyId,faculty.facultyName from faculty ", tblfaculty);
            cfaculty.DisplayMember = "facultyName";
            cfaculty.ValueMember = "facultyId";

            DataTable tbllevel = new DataTable();
            clevel.DataSource = db.fillTable("select level.levelId,level.levelName from level ", tbllevel);
            clevel.DisplayMember = "levelName";
            clevel.ValueMember = "levelId";

            cgender.Items.Add("male");
            cgender.Items.Add("female");
            cgender.SelectedIndex = 0;
        }

        private void frmReportPatient_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon("dentist.exe");
            intializecombooboxes();
            this.reportPatient.RefreshReport();
           
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            if (checkBoxactive.Checked)
            {
                if (cname.Enabled == true & cfaculty.Enabled == true & clevel.Enabled == true & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient ,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);

                else if (cname.Enabled == true & cfaculty.Enabled == false & clevel.Enabled == false & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue, this);

                else if (cname.Enabled == false & cfaculty.Enabled == true & clevel.Enabled == false & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patient.facultyId=" + cfaculty.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patient.facultyId=" + cfaculty.SelectedValue, this);

                else if (cname.Enabled == false & cfaculty.Enabled == false & clevel.Enabled == true & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patient.levelId=" + clevel.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patient.levelId=" + clevel.SelectedValue, this);

                else if (cname.Enabled == false & cfaculty.Enabled == false & clevel.Enabled == false & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and gender = '" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and gender = '" + cgender.SelectedItem.ToString() + "'", this);


                else if (cname.Enabled == true & cfaculty.Enabled == true & clevel.Enabled == false & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue, this);


                else if (cname.Enabled == true & cfaculty.Enabled == false & clevel.Enabled == true & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and patient.levelId =" + clevel.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and patient.levelId =" + clevel.SelectedValue, this);


                else if (cname.Enabled == true & cfaculty.Enabled == false & clevel.Enabled == false & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId)  from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);


                else if (cname.Enabled == false & cfaculty.Enabled == true & clevel.Enabled == true & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patient.facultyId=" + cfaculty.SelectedValue + " and patient.levelId =" + clevel.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patient.facultyId=" + cfaculty.SelectedValue + " and patient.levelId =" + clevel.SelectedValue, this);

                else if (cname.Enabled == false & cfaculty.Enabled == true & clevel.Enabled == false & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patient.facultyId=" + cfaculty.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patient.facultyId=" + cfaculty.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);



                else if (cname.Enabled == false & cfaculty.Enabled == false & clevel.Enabled == true & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);

                else if (cname.Enabled == true & cfaculty.Enabled == true & clevel.Enabled == true & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue, this);

                else if (cname.Enabled == false & cfaculty.Enabled == true & clevel.Enabled == true & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId  and active=1 and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId  and active=1 and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);

                else if (cname.Enabled == true & cfaculty.Enabled == false & clevel.Enabled == true & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);

                else if (cname.Enabled == true & cfaculty.Enabled == true & clevel.Enabled == false & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =1 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);
                else Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active=1 ) as countpatient  from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active=1 ", this);
            }

            else
            {

                if (cname.Enabled == true & cfaculty.Enabled == true & clevel.Enabled == true & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId)  from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);

                else if (cname.Enabled == true & cfaculty.Enabled == false & clevel.Enabled == false & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue, this);

                else if (cname.Enabled == false & cfaculty.Enabled == true & clevel.Enabled == false & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patient.facultyId=" + cfaculty.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patient.facultyId=" + cfaculty.SelectedValue, this);

                else if (cname.Enabled == false & cfaculty.Enabled == false & clevel.Enabled == true & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patient.levelId=" + clevel.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patient.levelId=" + clevel.SelectedValue, this);

                else if (cname.Enabled == false & cfaculty.Enabled == false & clevel.Enabled == false & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and gender = '" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and gender = '" + cgender.SelectedItem.ToString() + "'", this);


                else if (cname.Enabled == true & cfaculty.Enabled == true & clevel.Enabled == false & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue, this);


                else if (cname.Enabled == true & cfaculty.Enabled == false & clevel.Enabled == true & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and patient.levelId =" + clevel.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and patient.levelId =" + clevel.SelectedValue, this);


                else if (cname.Enabled == true & cfaculty.Enabled == false & clevel.Enabled == false & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId)  from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);


                else if (cname.Enabled == false & cfaculty.Enabled == true & clevel.Enabled == true & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patient.facultyId=" + cfaculty.SelectedValue + " and patient.levelId =" + clevel.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patient.facultyId=" + cfaculty.SelectedValue + " and patient.levelId =" + clevel.SelectedValue, this);

                else if (cname.Enabled == false & cfaculty.Enabled == true & clevel.Enabled == false & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patient.facultyId=" + cfaculty.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patient.facultyId=" + cfaculty.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);



                else if (cname.Enabled == false & cfaculty.Enabled == false & clevel.Enabled == true & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);

                else if (cname.Enabled == true & cfaculty.Enabled == true & clevel.Enabled == true & cgender.Enabled == false)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue, this);

                else if (cname.Enabled == false & cfaculty.Enabled == true & clevel.Enabled == true & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId  and active=0 and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId  and active=0 and patient.facultyId =" + cfaculty.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);

                else if (cname.Enabled == true & cfaculty.Enabled == false & clevel.Enabled == true & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and  patient.levelId=" + clevel.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);

                else if (cname.Enabled == true & cfaculty.Enabled == true & clevel.Enabled == false & cgender.Enabled == true)
                    Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'" + ")as countpatient from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active =0 and patientId=" + cname.SelectedValue + " and patient.facultyId =" + cfaculty.SelectedValue + " and gender ='" + cgender.SelectedItem.ToString() + "'", this);
                else Clinic.C.RunReportpatient("select patient.patientId,patient.patientName,patient.phone,patient.email,patient.age,patient.gender,patient.address,faculty.facultyName,level.levelName, (select count(patientId) from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active=0 ) as countpatient  from patient,faculty,level where patient.facultyId=faculty.facultyId and patient.levelId=level.levelId and active=0 ", this);

            }
            this.reportPatient.RefreshReport();

        }

        private void checkBoxname_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxname.Checked) cname.Enabled = true;
            else cname.Enabled = false;
        }

        private void checkBoxfaculty_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxfaculty.Checked) cfaculty.Enabled = true;
            else cfaculty.Enabled = false;
        }

        private void checkBoxlevel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxlevel.Checked) clevel.Enabled = true;
            else clevel.Enabled = false;
        }

        private void checkBoxgender_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxgender.Checked) cgender.Enabled = true;
            else cgender.Enabled = false;
        }

        private void Pnlheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousdown)
            {
                int newX = (this.Location.X - lastLOcation.X) + e.X;
                int newY = (this.Location.Y - lastLOcation.Y) + e.Y;
                this.Location = new Point(newX, newY);
            }
        }

        private void Pnlheader_MouseDown(object sender, MouseEventArgs e)
        {
            mousdown = true;
            Pnlheader.Cursor = Cursors.Hand;
            lastLOcation = e.Location;
        }

        private void Pnlheader_MouseUp(object sender, MouseEventArgs e)
        {
            mousdown = false;
            Pnlheader.Cursor = Cursors.Default;
        }
    }
}
