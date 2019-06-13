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
        private void pereparemedicalHistoryComplaint()
        {
            // medicalHistoryComplaint.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            medicalHistoryComplaint.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);
            medicalHistoryComplaint.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12);
            medicalHistoryComplaint.BorderStyle = BorderStyle.None;
            medicalHistoryComplaint.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            medicalHistoryComplaint.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            medicalHistoryComplaint.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            medicalHistoryComplaint.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            medicalHistoryComplaint.BackgroundColor = Color.White;

            medicalHistoryComplaint.EnableHeadersVisualStyles = false;
            medicalHistoryComplaint.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            medicalHistoryComplaint.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            medicalHistoryComplaint.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        DB db = new DB();
        DataTable tbl = new DataTable();

        regularExpression rgx = new regularExpression();
        private void add()
        {
            object[] data = { mainfrorm.appointmentId, mainfrorm.appointmentDate, mainfrorm.specilization, txtMedicalHistoryContent.Text, mainfrorm.patientName, mainfrorm.doctorName, };
            tbl.Rows.Add(data);
        }
        private void Adding()
        {
            try
            {

                lblmessege.Text = "";

                db.run("update appointment set medicalhistory ='" + txtMedicalHistoryContent.Text + "' where appointmentId =" + mainfrorm.appointmentId);
                add();
                tbl = new DataTable();
                db.fillTable("select appointment.appointmentId,appointment.appointmentDate,specializations.SpecializationsName,appointment.medicalhistory,patient.patientName,staff.staffName from appointment,specializations,patient,staff where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and medicalhistory  IS NOT NULL and appointment.active  =1 and appointment.appointmentId=" + mainfrorm.appointmentId, tbl);
                medicalHistoryComplaint.DataSource = tbl;

            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void edit()
        {
            medicalHistoryComplaint.CurrentRow.Cells[3].Value = txtMedicalHistoryContent.Text;
        }
        private void Editing()
        {
            try
            {

                lblmessege.Text = "";

                db.run("update appointment set medicalhistory = '" + txtMedicalHistoryContent.Text + "' where appointmentId = " + Int32.Parse(medicalHistoryComplaint.CurrentRow.Cells[0].Value.ToString()));
                edit();

            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void delete()
        {

            if (medicalHistoryComplaint.CurrentRow != null)
            {

                db.run("update appointment set medicalhistory=null where appointmentId= " + Int32.Parse(medicalHistoryComplaint.CurrentRow.Cells[0].Value.ToString()));
                medicalHistoryComplaint.Rows.Remove(medicalHistoryComplaint.CurrentRow);
            }
        }
        





        private void mybutton4_Click(object sender, EventArgs e)
        {
            if (rgx.checkString(txtMedicalHistoryContent.Text))
            {
                Editing();
            }
            else lblmessege.Text = "الرجاء ادخال الشكوى فى صوره حروف عربيه او انجليزيه فقط";
        }

      
        private void mybutton5_Click(object sender, EventArgs e)
        {

            if (rgx.checkString(txtMedicalHistoryContent.Text))
            {

                {
                    Adding();
                    mybutton5.Enabled = false;
                }

            }
            else lblmessege.Text = "الرجاء ادخال الشكوى فى صوره حروف عربيه او انجليزيه فقط";
        }

        private void mybutton6_Click(object sender, EventArgs e)
        {
            delete();
            mybutton5.Enabled = true;
        }

        private void frmMedicalHistory_Load(object sender, EventArgs e)
        {
            pereparemedicalHistoryComplaint();
            db.fillTable("select appointment.appointmentId,appointment.appointmentDate,specializations.SpecializationsName,appointment.medicalhistory,patient.patientName,staff.staffName from appointment,specializations,patient,staff where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and medicalhistory  IS NOT NULL and appointment.active  =1 and appointment.appointmentId=" + mainfrorm.appointmentId, tbl);


            medicalHistoryComplaint.DataSource = tbl;
            medicalHistoryComplaint.Columns["appointmentId"].Visible = false;



            txtMedicalHistoryContent.Text = "";
            if (medicalHistoryComplaint.Rows.Count < 1) mybutton5.Enabled = true;
            else mybutton5.Enabled = false;
        }

        private void medicalHistoryComplaint_Click(object sender, EventArgs e)
        {
            if (medicalHistoryComplaint.CurrentRow != null)
            {

                txtMedicalHistoryContent.Text = medicalHistoryComplaint.CurrentRow.Cells[3].Value.ToString();

            }
        }
    }
}
