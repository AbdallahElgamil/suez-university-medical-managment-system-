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
    public partial class patient_history : Form
    {
        public patient_history()
        {
            InitializeComponent();
        }
        private bool mousdown = false;
        private Point lastLOcation;
        DB db = new DB();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon("dentist.exe");
            Clinic.DB.open();
            intializecombobox();
            this.report_patient_history.RefreshReport();

        }
        private void intializecombobox()
        {




            DataTable tblCombDoctor = new DataTable();
            DataTable tblCombPatient = new DataTable();
            DataTable tblcombospecilaization = new DataTable();

            combspecialization.DataSource = db.fillTable("select specializations.specializationsId,specializations.specializationsName from specializations where specializationsId!=0", tblcombospecilaization);
            combdoctor.DataSource = db.fillTable("select staff.staffId,staff.staffName from staff,profession,specializations where staff.professionID=profession.professionId and specializations.specializationsId = staff.specializationsId and active=1 and profession.professionName='دكتور' ", tblCombDoctor);
            combpatient.DataSource = db.fillTable("select patient.patientId,patient.patientName from patient where active =1", tblCombPatient);

            combpatient.DisplayMember = "patientName";
            combpatient.ValueMember = "patientId";

            combdoctor.DisplayMember = "staffName";
            combdoctor.ValueMember = "staffId";

            combspecialization.DisplayMember = "specializationsName";
            combspecialization.ValueMember = "specializationsId";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBoxactive.Checked)
            {
                if (combpatient.Enabled == true & combdoctor.Enabled == true & combspecialization.Enabled == true)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=1 and patientName='" + combpatient.Text + "' and staffName ='" + combdoctor.Text + "' and SpecializationsName = '" + combspecialization.Text + "'" + ") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=1 and patientName='" + combpatient.Text + "' and staffName ='"+combdoctor.Text+ "' and SpecializationsName = '"+combspecialization.Text+"'", this);

                else if (combpatient.Enabled == true & combdoctor.Enabled == true & combspecialization.Enabled == false)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=1 and patientName='" + combpatient.Text + "' and staffName ='" + combdoctor.Text  + "') as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=1 and patientName='" + combpatient.Text + "' and staffName ='" + combdoctor.Text+"'" , this);

                else if (combpatient.Enabled == true & combdoctor.Enabled == false & combspecialization.Enabled == true)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=1 and patientName='" + combpatient.Text + "' and SpecializationsName = '" + combspecialization.Text + "'" + ") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=1 and patientName='" + combpatient.Text + "' and SpecializationsName = '" + combspecialization.Text + "'", this);

                else if (combpatient.Enabled == false & combdoctor.Enabled == true & combspecialization.Enabled == true)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=1  and staffName ='" + combdoctor.Text + "' and SpecializationsName = '" + combspecialization.Text + "'" + ") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=1  and staffName ='" + combdoctor.Text + "' and SpecializationsName = '" + combspecialization.Text + "'", this);

                else if (combpatient.Enabled == true & combdoctor.Enabled == false & combspecialization.Enabled == false)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=1 and patientName='" + combpatient.Text  + "') as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=1 and patientName='" + combpatient.Text +"'", this);

                else if (combpatient.Enabled == false & combdoctor.Enabled == true & combspecialization.Enabled == false)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=1  and staffName ='" + combdoctor.Text +  "') as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=1  and staffName ='" + combdoctor.Text +"'", this);

                else if (combpatient.Enabled == false & combdoctor.Enabled == false & combspecialization.Enabled == true)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=1  and SpecializationsName = '" + combspecialization.Text + "'" + ") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=1  and SpecializationsName = '" + combspecialization.Text + "'", this);

                else C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=1 "+ ") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=1  ", this);

            }
            else
            {
                if (combpatient.Enabled == true & combdoctor.Enabled == true & combspecialization.Enabled == true)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=0 and patientName='" + combpatient.Text + "' and staffName ='" + combdoctor.Text + "' and SpecializationsName = '" + combspecialization.Text + "'" + ") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=0 and patientName='" + combpatient.Text + "' and staffName ='" + combdoctor.Text + "' and SpecializationsName = '" + combspecialization.Text + "'", this);

                else if (combpatient.Enabled == true & combdoctor.Enabled == true & combspecialization.Enabled == false)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=0 and patientName='" + combpatient.Text + "' and staffName ='" + combdoctor.Text + "') as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=0 and patientName='" + combpatient.Text + "' and staffName ='" + combdoctor.Text + "'", this);


                else if (combpatient.Enabled == true & combdoctor.Enabled == false & combspecialization.Enabled == true)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=0 and patientName='" + combpatient.Text + "' and SpecializationsName = '" + combspecialization.Text + "'" + ") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=0 and patientName='" + combpatient.Text + "' and SpecializationsName = '" + combspecialization.Text + "'", this);

                else if (combpatient.Enabled == false & combdoctor.Enabled == true & combspecialization.Enabled == true)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=0  and staffName ='" + combdoctor.Text + "' and SpecializationsName = '" + combspecialization.Text + "'" + ") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=0  and staffName ='" + combdoctor.Text + "' and SpecializationsName = '" + combspecialization.Text + "'", this);

                else if (combpatient.Enabled == true & combdoctor.Enabled == false & combspecialization.Enabled == false)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=0 and patientName='" + combpatient.Text + "') as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=0 and patientName='" + combpatient.Text + "'", this);

                else if (combpatient.Enabled == false & combdoctor.Enabled == true & combspecialization.Enabled == false)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=0  and staffName ='" + combdoctor.Text + "') as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=0  and staffName ='" + combdoctor.Text + "'", this);

                else if (combpatient.Enabled == false & combdoctor.Enabled == false & combspecialization.Enabled == true)
                    C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=0 and SpecializationsName = '" + combspecialization.Text + "'" + ") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=0 and SpecializationsName = '" + combspecialization.Text + "'", this);

                else C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null  and appointment.active=0 " + ") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and appointment.active=0  ", this);

            }

            this.report_patient_history.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pnlheader_MouseUp(object sender, MouseEventArgs e)
        {
            mousdown = false;
            Pnlheader.Cursor = Cursors.Default;
        }

        private void Pnlheader_MouseDown(object sender, MouseEventArgs e)
        {
            mousdown = true;
            Pnlheader.Cursor = Cursors.Hand;
            lastLOcation = e.Location;
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

        private void checkBoxpatient_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpatient.Checked) combpatient.Enabled = true;
            else combpatient.Enabled = false;
        }

        private void checkBoxexaminationType_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxexaminationType.Checked) combspecialization.Enabled = true;
            else combspecialization.Enabled = false;
        }

        private void checkdoctor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkdoctor.Checked) combdoctor.Enabled = true;
            else combdoctor.Enabled = false;
        }

        private void combspecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            combdoctor.DataSource = db.fillTable("select staff.staffId,staff.staffName from staff,profession,specializations where staff.professionID=profession.professionId and specializations.specializationsId = staff.specializationsId and profession.professionName='دكتور' and staff.active=1 and  specializations.specializationsName = '" + combspecialization.Text + "'", new DataTable());

            combdoctor.DisplayMember = "staffName";
            combdoctor.ValueMember = "staffId";
        }
    }
}
