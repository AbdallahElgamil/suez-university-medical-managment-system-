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
    public partial class mainfrorm : Form
    {
        frmMain fr;
        public mainfrorm(frmMain fr)
        {
            InitializeComponent();
            this.fr = fr;
        }
        private void pereparedgvpr()
        {
            // dgvpr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvMain.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvMain.BorderStyle = BorderStyle.None;
            dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvMain.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMain.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvMain.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMain.BackgroundColor = Color.White;

            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public static string patientName;
        public static string doctorName;
        public static string appointmentDate;
        public static int appointmentId;
        public static string specilization;
        public static string specilizationId;
        

        DB db = new DB();
        frmMain f = new frmMain();
        DataTable tbl = new DataTable();
        regularExpression rgx = new regularExpression();
        DataTable tblstaff = new DataTable();

        private void intializecombobox()
        {
         
            comboSearch.DataSource = db.fillTable("select staff.staffId,staff.staffName from staff,profession,specializations where staff.professionID=profession.professionId and specializations.specializationsId = staff.specializationsId and staff.active=1 and profession.professionName='دكتور' ", tblstaff);

            comboSearch.DisplayMember = "staffName";
            comboSearch.ValueMember = "staffId";
            
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






        private void mainfrorm_Load(object sender, EventArgs e)
        {
            intializecombobox();
            if (frmMain.systemuser == 2)
            {
                dgvMain.DataSource = db.fillTable("select  appointment.appointmentDate ,patient.patientName,staff.staffName ,appointment.appointmentId,appointment.examined,specializations.SpecializationsName,specializations.SpecializationsId  from appointment,patient,staff,specializations where appointment.patientId=patient.patientId and staff.staffId =appointment.staffId and appointment.SpecializationsId=staff.SpecializationsId and staff.SpecializationsId=specializations.SpecializationsId and appointment.active=1  and staffName='" + login.User + "' order by appointment.appointmentId", tbl);
                comboSearch.Visible = false;
                label1.Visible = false;
            }
            else
            {
                comboSearch.Visible = true;
                label1.Visible = true;
                  dgvMain.DataSource = db.fillTable("select  appointment.appointmentDate ,patient.patientName,staff.staffName ,appointment.appointmentId,appointment.examined,specializations.SpecializationsName,specializations.SpecializationsId  from appointment,patient,staff,specializations where appointment.patientId=patient.patientId and staff.staffId =appointment.staffId and appointment.SpecializationsId=staff.SpecializationsId and staff.SpecializationsId=specializations.SpecializationsId and appointment.active=1 order by appointment.appointmentId", tbl);
            }
                dgvMain.Columns["appointmentId"].Visible = false;
           
            dgvMain.Columns["SpecializationsId"].Visible = false;
            pereparedgvpr();
            if (frmMain.systemuser == 1) btnExamination.Enabled = false;
            
        }
        public void getAppointmentInformation()
        {
            if (dgvMain.CurrentRow != null)
            {
                patientName = dgvMain.CurrentRow.Cells[1].Value.ToString();
                appointmentDate = dgvMain.CurrentRow.Cells[0].Value.ToString();
                doctorName = dgvMain.CurrentRow.Cells[2].Value.ToString();
                appointmentId = Int32.Parse(dgvMain.CurrentRow.Cells[3].Value.ToString());
                specilization = dgvMain.CurrentRow.Cells[5].Value.ToString();
                specilizationId = dgvMain.CurrentRow.Cells[6].Value.ToString();
            }
        }
        private void dgvMain_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null) btnExamination.Visible = true;
        }

        

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//{
         //    appointmentId = Int32.Parse(dgvMain.Rows[e.RowIndex].Cells[3].Value.ToString());
         //}


        }

        private void mybutton2_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                getAppointmentInformation();

                frmGeneralExamination fr = new frmGeneralExamination(this.fr);
                formChange(fr);

                db.run("update appointment set examined ='تم الفحص'  where appointmentId =" + appointmentId);
                dgvMain.DataSource = db.fillTable("select  appointment.appointmentDate ,patient.patientName,staff.staffName ,appointment.appointmentId,appointment.examined  from appointment,patient,staff where appointment.patientId=patient.patientId and staff.staffId =appointment.staffId order by appointment.appointmentId DESC", new DataTable());
            }
            else lblmessege.Text = "اختر كشف اولا ";
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboSearch.GetItemText(comboSearch.SelectedItem);
          dgvMain.DataSource = db.fillTable("select  appointment.appointmentDate ,patient.patientName,staff.staffName ,appointment.appointmentId,appointment.examined,specializations.SpecializationsName,specializations.SpecializationsId  from appointment,patient,staff,specializations where appointment.patientId=patient.patientId and staff.staffId =appointment.staffId and appointment.SpecializationsId=staff.SpecializationsId and staff.SpecializationsId=specializations.SpecializationsId and appointment.active=1 and  staff.active=1 and  staff.staffName ='" + selected+"' order by appointment.appointmentId DESC", new DataTable());

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = tbl;
            dgvMain.Columns["appointmentId"].Visible = false;
            
            dgvMain.Columns["SpecializationsId"].Visible = false;
            btnback.Visible = false;
            btnsearch.Visible = true;
            txtsearch.Text = "";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            lblmessege.Text = "";
            if (rgx.checkName(txtsearch.Text))
            {
                DataTable tblSearch = new DataTable();
               db.fillTable("select  appointment.appointmentDate ,patient.patientName,staff.staffName ,appointment.appointmentId,appointment.examined,specializations.SpecializationsName,specializations.SpecializationsId  from appointment,patient,staff,specializations where appointment.patientId=patient.patientId and staff.staffId =appointment.staffId and appointment.SpecializationsId=staff.SpecializationsId and staff.SpecializationsId=specializations.SpecializationsId and appointment.active=1 and appointment.active=1 and patientName = '" + txtsearch.Text+"' order by appointment.appointmentId ", tblSearch);
                dgvMain.DataSource = tblSearch;
                dgvMain.Columns["appointmentId"].Visible = false;

                dgvMain.Columns["SpecializationsId"].Visible = false;
                
                btnback.Visible = true;
                btnsearch.Visible = false;
            }
            else lblmessege.Text = "الرجاء ادخال اسم المريض فى صوره حروف عربيه او انجليزيه فقط   ";
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text == "اسم الطالب ..")
            {
                txtsearch.Text = "";
                txtsearch.ForeColor = Color.Black;
            }
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                txtsearch.Text = "اسم الطالب ..";
                txtsearch.ForeColor = Color.DarkGray;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DataTable tblcheck = new DataTable();
                if (frmMain.systemuser == 2)
                {
                    db.fillTable("select  appointment.appointmentDate ,patient.patientName,staff.staffName ,appointment.appointmentId,appointment.examined,specializations.SpecializationsName,specializations.SpecializationsId  from appointment,patient,staff,specializations where appointment.patientId=patient.patientId and staff.staffId =appointment.staffId and appointment.SpecializationsId=staff.SpecializationsId and staff.SpecializationsId=specializations.SpecializationsId and appointment.active=1 and appointment.active=1 and examined IS NULL and staffName='" + login.User + "' order by appointment.appointmentId", tblcheck);
                }
                else
                    db.fillTable("select  appointment.appointmentDate ,patient.patientName,staff.staffName ,appointment.appointmentId,appointment.examined,specializations.SpecializationsName,specializations.SpecializationsId  from appointment,patient,staff,specializations where appointment.patientId=patient.patientId and staff.staffId =appointment.staffId and appointment.SpecializationsId=staff.SpecializationsId and staff.SpecializationsId=specializations.SpecializationsId and appointment.active=1 and appointment.active=1 and examined IS NULL  order by appointment.appointmentId ", tblcheck);

                dgvMain.DataSource = tblcheck;
            }
            else {
                dgvMain.DataSource = tbl;
                dgvMain.Columns["appointmentId"].Visible = false;

                dgvMain.Columns["SpecializationsId"].Visible = false;
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

