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
    public partial class frmReportStaff : Form
    {
        public frmReportStaff()
        {
            InitializeComponent();
        }
        DB db = new DB();
        private void frmReportStaff_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon("dentist.exe");
            intilizecomboboxes();
            this.reportStaff.RefreshReport();
      
        }

        private bool mousdown = false;
        private Point lastLOcation;


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

        private void Pnlheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousdown)
            {
                int newX = (this.Location.X - lastLOcation.X) + e.X;
                int newY = (this.Location.Y - lastLOcation.Y) + e.Y;
                this.Location = new Point(newX, newY);
            }
        }
        private void intilizecomboboxes()
        {

            DataTable tblprof = new DataTable();
            cprofessioon.DataSource = db.fillTable("select * from profession where professionId!=0", tblprof);
            cprofessioon.DisplayMember = "professionName";
            cprofessioon.ValueMember = "professionId";

            DataTable tblspec = new DataTable();
            cspecilization.DataSource = db.fillTable("select * from specializations where SpecializationsId!=0", tblspec);
            cspecilization.DisplayMember = "specializationsName";
            cspecilization.ValueMember = "specializationsId";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxprofession_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxprofession.Checked) cprofessioon.Enabled = true;
            else cprofessioon.Enabled = false;
        }

        private void checkBoxspecilization_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxspecilization.Checked) cspecilization.Enabled = true;
            else cspecilization.Enabled = false;
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            if (checkBoxactive.Checked)
            {
                if(cprofessioon.Enabled==true & cspecilization.Enabled==true)
                    Clinic.C.RunReportstaff("select staff.staffId,staff.staffName,profession.professionName,staff.phone,staff.email,staff.age,staff.gender,staff.address,specializations.SpecializationsName , (select count(staffId) from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=1 and staff.professionId =" + cprofessioon.SelectedValue + " and staff.SpecializationsId =" + cspecilization.SelectedValue+") as countstaff  from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=1 and staff.professionId =" + cprofessioon.SelectedValue+ " and staff.SpecializationsId ="+cspecilization.SelectedValue, this);

                else if (cprofessioon.Enabled == true & cspecilization.Enabled == false)
                    Clinic.C.RunReportstaff("select staff.staffId,staff.staffName,profession.professionName,staff.phone,staff.email,staff.age,staff.gender,staff.address,specializations.SpecializationsName, (select count(staffId) from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=1 and staff.professionId =" + cprofessioon.SelectedValue+") as countstaff   from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=1 and staff.professionId =" + cprofessioon.SelectedValue , this);

                else if (cprofessioon.Enabled == false & cspecilization.Enabled == true)
                    Clinic.C.RunReportstaff("select staff.staffId,staff.staffName,profession.professionName,staff.phone,staff.email,staff.age,staff.gender,staff.address,specializations.SpecializationsName, (select count(staffId) from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=1 and staff.SpecializationsId =" + cspecilization.SelectedValue+") as countstaff   from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=1 and staff.SpecializationsId =" + cspecilization.SelectedValue, this);

                else Clinic.C.RunReportstaff("select staff.staffId, staff.staffName, profession.professionName, staff.phone, staff.email, staff.age, staff.gender, staff.address, specializations.SpecializationsName, (select count(staffId) from profession, staff left join specializations  on specializations.SpecializationsId = staff.SpecializationsId where  staff.staffId != 0 and staff.professionId = profession.professionId and active = 1" + ") as countstaff   from profession, staff left join specializations  on specializations.SpecializationsId = staff.SpecializationsId where  staff.staffId != 0 and staff.professionId = profession.professionId and active = 1", this);



            }

            else
            {
                if (cprofessioon.Enabled == true & cspecilization.Enabled == true)
                    Clinic.C.RunReportstaff("select staff.staffId,staff.staffName,profession.professionName,staff.phone,staff.email,staff.age,staff.gender,staff.address,specializations.SpecializationsName, (select count(staffId)   from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=0 and staff.professionId =" + cprofessioon.SelectedValue + " and staff.SpecializationsId =" + cspecilization.SelectedValue+") as countstaff   from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=0 and staff.professionId =" + cprofessioon.SelectedValue + " and staff.SpecializationsId =" + cspecilization.SelectedValue, this);

                else if (cprofessioon.Enabled == true & cspecilization.Enabled == false)
                    Clinic.C.RunReportstaff("select staff.staffId,staff.staffName,profession.professionName,staff.phone,staff.email,staff.age,staff.gender,staff.address,specializations.SpecializationsName, (select count(staffId) from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=0 and staff.professionId =" + cprofessioon.SelectedValue+") as countstaff   from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=0 and staff.professionId =" + cprofessioon.SelectedValue, this);

                else if (cprofessioon.Enabled == false & cspecilization.Enabled == true)
                    Clinic.C.RunReportstaff("select staff.staffId,staff.staffName,profession.professionName,staff.phone,staff.email,staff.age,staff.gender,staff.address,specializations.SpecializationsName, (select count(staffId) from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=0 and staff.SpecializationsId =" + cspecilization.SelectedValue+") as countstaff   from profession,staff left join specializations  on specializations.SpecializationsId =staff.SpecializationsId where  staff.staffId!=0 and staff.professionId =profession.professionId and active=0 and staff.SpecializationsId =" + cspecilization.SelectedValue, this);




                else Clinic.C.RunReportstaff("select staff.staffId, staff.staffName, profession.professionName, staff.phone, staff.email, staff.age, staff.gender, staff.address, specializations.SpecializationsName, (select count(staffId) from profession, staff left join specializations  on specializations.SpecializationsId = staff.SpecializationsId where  staff.staffId != 0 and staff.professionId = profession.professionId and active = 0"+") as countstaff   from profession, staff left join specializations  on specializations.SpecializationsId = staff.SpecializationsId where  staff.staffId != 0 and staff.professionId = profession.professionId and active = 0", this);

            }
            this.reportStaff.RefreshReport();

        }
    }
}
