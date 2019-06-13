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
    public partial class frmMedicine : Form
    {
        public frmMedicine()
        {
            InitializeComponent();
        }
        private void pereparedgvMedicine()
        {
            // dgvMedicine.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMedicine.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvMedicine.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvMedicine.BorderStyle = BorderStyle.None;
            dgvMedicine.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvMedicine.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMedicine.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvMedicine.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMedicine.BackgroundColor = Color.White;

            dgvMedicine.EnableHeadersVisualStyles = false;
            dgvMedicine.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMedicine.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvMedicine.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        DB db = new DB();
        DataTable tbl = new DataTable();

        regularExpression rgx = new regularExpression();
        private void add()
        {
            object[] data = { mainfrorm.appointmentId, mainfrorm.appointmentDate, mainfrorm.specilization, txtMedicine.Text, mainfrorm.patientName, mainfrorm.doctorName, };
            tbl.Rows.Add(data);
        }
        private void Adding()
        {
            try
            {

                lblmessege.Text = "";

                db.run("update appointment set medicine ='" + txtMedicine.Text + "' where appointmentId =" + mainfrorm.appointmentId);
                add();
                tbl = new DataTable();
                db.fillTable("select appointment.appointmentId,appointment.appointmentDate,specializations.SpecializationsName,appointment.medicine,patient.patientName,staff.staffName from appointment,specializations,patient,staff where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and medicine  IS NOT NULL and appointment.active  =1 and appointment.appointmentId=" + mainfrorm.appointmentId, tbl);
                dgvMedicine.DataSource = tbl;

            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void edit()
        {
            dgvMedicine.CurrentRow.Cells[3].Value = txtMedicine.Text;
        }
        private void Editing()
        {
            try
            {

                lblmessege.Text = "";

                db.run("update appointment set medicine = '" + txtMedicine.Text + "' where appointmentId = " + Int32.Parse(dgvMedicine.CurrentRow.Cells[0].Value.ToString()));
                edit();

            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void delete()
        {

            if (dgvMedicine.CurrentRow != null)
            {

                db.run("update appointment set medicine=null where appointmentId= " + Int32.Parse(dgvMedicine.CurrentRow.Cells[0].Value.ToString()));
                dgvMedicine.Rows.Remove(dgvMedicine.CurrentRow);
            }
        }
       





        private void mybutton4_Click(object sender, EventArgs e)
        {
            if (rgx.checkString(txtMedicine.Text))
            {
                Editing();
            }
            else lblmessege.Text = "الرجاء ادخال الشكوى فى صوره حروف عربيه او انجليزيه فقط";
        }

       

        private void mybutton5_Click(object sender, EventArgs e)
        {

            if (rgx.checkString(txtMedicine.Text))
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

        private void mybutton1_Click(object sender, EventArgs e)
        {
            medicine_specialization ms = new medicine_specialization(this);
            ms.Show();
        }

      

        private void frmMedicine_Load_1(object sender, EventArgs e)
        {
            pereparedgvMedicine();
            db.fillTable("select appointment.appointmentId,appointment.appointmentDate,specializations.SpecializationsName,appointment.medicine,patient.patientName,staff.staffName from appointment,specializations,patient,staff where appointment.SpecializationsId=specializations.SpecializationsId and appointment.patientId=patient.patientId and appointment.staffId=staff.staffId and medicine  IS NOT NULL and appointment.active  =1 and appointment.appointmentId=" + mainfrorm.appointmentId, tbl);


            dgvMedicine.DataSource = tbl;
            dgvMedicine.Columns["appointmentId"].Visible = false;



            txtMedicine.Text = "";
            if (dgvMedicine.Rows.Count < 1) mybutton5.Enabled = true;
            else mybutton5.Enabled = false;
        }

        private void dgvMedicine_Click_2(object sender, EventArgs e)
        {
            if (dgvMedicine.CurrentRow != null)
            {

                txtMedicine.Text = dgvMedicine.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
