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
    public partial class frmExamination : Form
    {
        public frmExamination()
        {

            InitializeComponent();

        }
        private void pereparedgvExamination()
        {
            // dgvExamination.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExamination.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvExamination.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvExamination.BorderStyle = BorderStyle.None;
            dgvExamination.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvExamination.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvExamination.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvExamination.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvExamination.BackgroundColor = Color.White;

            dgvExamination.EnableHeadersVisualStyles = false;
            dgvExamination.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvExamination.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvExamination.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        DB db = new DB();
        DataTable tbl = new DataTable();

        regularExpression rgx = new regularExpression();
        private void add()
        {
            object[] data = { mainfrorm.appointmentId, mainfrorm.appointmentDate, mainfrorm.specilization, txtEXaminationContent.Text, mainfrorm.patientName, mainfrorm.doctorName, };
            tbl.Rows.Add(data);
        }
        private void Adding()
        {
            try
            {

                lblmessege.Text = "";

                db.run("update appointment set examination ='" + txtEXaminationContent.Text + "' where appointmentId =" + mainfrorm.appointmentId);
                add();
                tbl = new DataTable();
                db.fillTable("select appointment.appointmentId,appointment.appointmentDate,specializations.SpecializationsName,appointment.examination,patient.patientName,staff.staffName from appointment,specializations,patient,staff where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examination  IS NOT NULL and appointment.active  =1 and appointment.appointmentId=" + mainfrorm.appointmentId, tbl);
                dgvExamination.DataSource = tbl;

            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void edit()
        {
            dgvExamination.CurrentRow.Cells[3].Value = txtEXaminationContent.Text;
        }
        private void Editing()
        {
            try
            {

                lblmessege.Text = "";

                db.run("update appointment set examination = '" + txtEXaminationContent.Text + "' where appointmentId = " + Int32.Parse(dgvExamination.CurrentRow.Cells[0].Value.ToString()));
                edit();

            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void delete()
        {

            if (dgvExamination.CurrentRow != null)
            {

                db.run("update appointment set examination=null where appointmentId= " + Int32.Parse(dgvExamination.CurrentRow.Cells[0].Value.ToString()));
                dgvExamination.Rows.Remove(dgvExamination.CurrentRow);
            }
        }
     






        private void mybutton4_Click(object sender, EventArgs e)
        {
            if (rgx.checkString(txtEXaminationContent.Text))
            {
                Editing();
            }
            else lblmessege.Text = "الرجاء ادخال الشكوى فى صوره حروف عربيه او انجليزيه فقط";
        }

      

        private void mybutton5_Click(object sender, EventArgs e)
        {

            if (rgx.checkString(txtEXaminationContent.Text))
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

        private void dgvExamination_Click(object sender, EventArgs e)
        {
            if (dgvExamination.CurrentRow != null)
            {

                txtEXaminationContent.Text = dgvExamination.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void frmExamination_Load(object sender, EventArgs e)
        {
            pereparedgvExamination();
            db.fillTable("select appointment.appointmentId,appointment.appointmentDate,specializations.SpecializationsName,appointment.examination,patient.patientName,staff.staffName from appointment,specializations,patient,staff where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and examination  IS NOT NULL and appointment.active  =1 and appointment.appointmentId=" + mainfrorm.appointmentId, tbl);


            dgvExamination.DataSource = tbl;
            dgvExamination.Columns["appointmentId"].Visible = false;



            txtEXaminationContent.Text = "";
            if (dgvExamination.Rows.Count < 1) mybutton5.Enabled = true;
            else mybutton5.Enabled = false;
        }

        private void mybutton7_Click(object sender, EventArgs e)
        {
            new pictures().Show();
        }
    }
}
