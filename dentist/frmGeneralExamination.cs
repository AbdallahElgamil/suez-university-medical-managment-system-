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
    public partial class frmGeneralExamination : Form
    {
        frmMain fr;
        public frmGeneralExamination(frmMain fr)
        {
            InitializeComponent();
            this.fr = fr;
        }

        private void frmExamination_Load(object sender, EventArgs e)
        {
            lblpstientName.Text ="اسم المريض :"  +mainfrorm.patientName;
            frmChiefComplaint fr = new frmChiefComplaint();
            examinationPanel.Controls.Clear();
            fr.TopLevel = false;
            examinationPanel.Controls.Add(fr);
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

      

        private void complaintAndMedicalHistorybtn_Click(object sender, EventArgs e)
        {
            frmChiefComplaint fr = new frmChiefComplaint();
            examinationPanel.Controls.Clear();
            fr.TopLevel = false;
            examinationPanel.Controls.Add(fr);
            fr.FormBorderStyle = FormBorderStyle.None;
             fr.Dock = DockStyle.Fill;
            //+fr.Anchor = AnchorStyles.Right;
            fr.Show();
        }

        private void examinationbtn_Click(object sender, EventArgs e)
        {
            frmExamination fr = new frmExamination();
            examinationPanel.Controls.Clear();
            fr.TopLevel = false;
            examinationPanel.Controls.Add(fr);
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMedicine fr = new frmMedicine();
            examinationPanel.Controls.Clear();
            fr.TopLevel = false;
            examinationPanel.Controls.Add(fr);
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMedicalHistory fr = new frmMedicalHistory();
            examinationPanel.Controls.Clear();
            fr.TopLevel = false;
            examinationPanel.Controls.Add(fr);
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }
        private void formChange(Form f)
        {

            fr.mainpanel.Controls.Clear();
            f.TopLevel = false;
            fr.mainpanel.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mainfrorm fr = new mainfrorm(this.fr);
            formChange(fr);

        }

        private void mybutton1_Click(object sender, EventArgs e)
        {

            patient_history ph = new patient_history();
            C.runPerportPatient_history("select patientName,staffName , appointment.appointmentDate , appointment.chiefcomplaint,appointment.examination,appointment.medicalhistory,appointment.medicine,specializations.SpecializationsName , (select count(appointment.appointmentId ) from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and  patientName='" + mainfrorm.patientName + "'"+") as rowcount from appointment,staff,patient,specializations where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examined is not null and  patientName='" + mainfrorm.patientName+"'", ph);
            ph.Show();
        }

        private void mybutton2_Click(object sender, EventArgs e)
        {

            frmRosheta r = new frmRosheta();
            C.runReportRocheta(@"
select patientName, staffName, staff.phone as
staffphone, patient.phone as patientphone, patient.age,
patient.gender, patient.address, appointment.appointmentDate
, appointment.examination, appointment.medicine, specializations
.SpecializationsName from
appointment, staff, patient, specializations where
appointment.SpecializationsId = specializations.SpecializationsId
and appointment.patientId = patient.patientId and
appointment.staffId = staff.staffId and  appointmentId = "+mainfrorm.appointmentId, r);
            r.Show();
        }
    }
}
