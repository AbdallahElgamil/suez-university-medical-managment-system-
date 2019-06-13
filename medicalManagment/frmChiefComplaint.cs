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
    public partial class frmChiefComplaint : Form
    {
        public frmChiefComplaint()
        {
            InitializeComponent();
        }
        private void pereparedgvChiefComplaint()
        {
            // dgvChiefComplaint.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiefComplaint.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvChiefComplaint.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvChiefComplaint.BorderStyle = BorderStyle.None;
            dgvChiefComplaint.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvChiefComplaint.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChiefComplaint.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvChiefComplaint.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvChiefComplaint.BackgroundColor = Color.White;

            dgvChiefComplaint.EnableHeadersVisualStyles = false;
            dgvChiefComplaint.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvChiefComplaint.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvChiefComplaint.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        DB db = new DB();
        DataTable tbl = new DataTable();

        regularExpression rgx = new regularExpression();
        private void add()
        {
            object[] data = { mainfrorm.appointmentId, mainfrorm.appointmentDate,mainfrorm.specilization, txtEXaminationContent.Text, mainfrorm.patientName, mainfrorm.doctorName,  };
            tbl.Rows.Add(data);
        }
        private void Adding()
        {
            try
            {

                lblmessege.Text = "";

                db.run("update appointment set chiefcomplaint ='" + txtEXaminationContent.Text + "' where appointmentId =" + mainfrorm.appointmentId);
                add();
                tbl = new DataTable();
                db.fillTable("select appointment.appointmentId,appointment.appointmentDate,specializations.SpecializationsName,appointment.chiefcomplaint,patient.patientName,staff.staffName from appointment,specializations,patient,staff where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and chiefcomplaint  IS NOT NULL and appointment.active  =1 and appointment.appointmentId=" + mainfrorm.appointmentId, tbl);
                dgvChiefComplaint.DataSource = tbl;

            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void edit()
        {
            dgvChiefComplaint.CurrentRow.Cells[3].Value = txtEXaminationContent.Text;
        }
        private void Editing()
        {
            try
            {

                lblmessege.Text = "";

                db.run("update appointment set chiefcomplaint = '" + txtEXaminationContent.Text + "' where appointmentId = " + Int32.Parse(dgvChiefComplaint.CurrentRow.Cells[0].Value.ToString()));
                edit();

            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void delete()
        {

            if (dgvChiefComplaint.CurrentRow != null)
            {

                db.run("update appointment set chiefcomplaint=null where appointmentId= " + Int32.Parse(dgvChiefComplaint.CurrentRow.Cells[0].Value.ToString()));
                dgvChiefComplaint.Rows.Remove(dgvChiefComplaint.CurrentRow);
            }
        }
        private void frmChiefComplaint_Load(object sender, EventArgs e)
        {
            pereparedgvChiefComplaint();
            db.fillTable("select appointment.appointmentId,appointment.appointmentDate,specializations.SpecializationsName,appointment.chiefcomplaint,patient.patientName,staff.staffName from appointment,specializations,patient,staff where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and chiefcomplaint  IS NOT NULL and appointment.active  =1 and appointment.appointmentId=" + mainfrorm.appointmentId, tbl);


            dgvChiefComplaint.DataSource = tbl;
            dgvChiefComplaint.Columns["appointmentId"].Visible = false;



            txtEXaminationContent.Text = "";
            if (dgvChiefComplaint.Rows.Count < 1) mybutton5.Enabled = true;
            else mybutton5.Enabled = false;
        }






        private void mybutton4_Click(object sender, EventArgs e)
        {
            if (rgx.checkString(txtEXaminationContent.Text))
            {
                Editing();
            }
            else lblmessege.Text = "الرجاء ادخال الشكوى فى صوره حروف عربيه او انجليزيه فقط";
        }

        private void dgvChiefComplaint_Click_1(object sender, EventArgs e)
        {
            if (dgvChiefComplaint.CurrentRow != null)
            {

                txtEXaminationContent.Text = dgvChiefComplaint.CurrentRow.Cells[3].Value.ToString();

            }
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
    }
}
    


