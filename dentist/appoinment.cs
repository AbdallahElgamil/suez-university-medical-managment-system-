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
    public partial class frmappoinment : Form
    {
        public frmappoinment()
        {
            InitializeComponent();
        }
        private void pereparedgvpr()
        {
            // dgvpr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAppoinment.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvAppoinment.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dgvAppoinment.BorderStyle = BorderStyle.None;
            dgvAppoinment.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvAppoinment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAppoinment.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvAppoinment.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvAppoinment.BackgroundColor = Color.White;

            dgvAppoinment.EnableHeadersVisualStyles = false;
            dgvAppoinment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAppoinment.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvAppoinment.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
          
        }


        string strRegestaion;
        string strDoctorName;
        string strPatientName;
        
        DB db = new DB();
        DataTable tbl = new DataTable();
        DataTable tblCombDoctor = new DataTable();
        regularExpression rgx = new regularExpression() ;
        private void intialize()
        {
            strRegestaion = txtregestrationNo.Text;

            strDoctorName = combdoctor.Text; 
            
            strPatientName = combpatient.Text;

        }
        private void intializecombobox()
        {
            

            //if (dgvAppoinment.RowCount > 0) staffgender.SelectedItem = dgvpr.CurrentRow.Cells[6].Value.ToString();

            
            DataTable tblCombPatient = new DataTable();
            DataTable tblcombospecilaization = new DataTable();
            combspecialization.DataSource = db.fillTable("select specializations.specializationsId,specializations.specializationsName from specializations where specializationsId!=0", tblcombospecilaization);
            combspecialization.DisplayMember = "specializationsName";
            combspecialization.ValueMember = "specializationsId";
            combdoctor.DataSource = db.fillTable("select staff.staffId,staff.staffName from staff,profession,specializations where staff.professionID=profession.professionId and specializations.specializationsId = staff.specializationsId and active=1 and profession.professionName='دكتور' and specializations.specializationsName = '" + combspecialization.Text+"'", tblCombDoctor);
            comboSearch.DataSource = db.fillTable("select staff.staffId,staff.staffName from staff,profession,specializations where staff.professionID=profession.professionId and specializations.specializationsId = staff.specializationsId and active=1 and profession.professionName='دكتور' ", new DataTable());

            combpatient.DataSource = db.fillTable("select patient.patientId,patient.patientName from patient where active =1", tblCombPatient);

          


            combpatient.DisplayMember = "patientName";
            combpatient.ValueMember = "patientId";

            combdoctor.DisplayMember = "staffName";
            combdoctor.ValueMember = "staffId";
            comboSearch.DisplayMember = "staffName";
            comboSearch.ValueMember = "staffId";

        }
       
        private void add()
        {

            object[] data = { strRegestaion, strPatientName, strDoctorName,dt.Value.ToString(),combspecialization.Text };
            tbl.Rows.Add(data);

        }
        private void Adding()
        {
            try
            {
                lblmessege.Text = "";

                db.run("insert into appointment(appointmentId,patientId,staffId,appointmentDate ,active,SpecializationsId) values (" + strRegestaion + "," + combpatient.SelectedValue + "," + combdoctor.SelectedValue + ",'" + dt.Value.ToString() + "',1,"+ combspecialization.SelectedValue +")");
                add();
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }

        }
        private void edit()
        {
            if (dgvAppoinment.CurrentRow != null)
            {

                dgvAppoinment.CurrentRow.Cells[1].Value = combpatient.Text;
                dgvAppoinment.CurrentRow.Cells[2].Value = combdoctor.Text;
                dgvAppoinment.CurrentRow.Cells[3].Value = dt.Value.ToString();



            }
        }
        private void Editing()
        {
            try
            {
                
                lblmessege.Text = "";
                db.run("update appointment set patientId =" + combpatient.SelectedValue + " ,staffId =" + combdoctor.SelectedValue + " ,appointmentDate ='" + dt.Value.ToString() + "', SpecializationsId =" + combspecialization.SelectedValue +" where appointmentId =" + strRegestaion);
                edit();
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }
        private void GetAuto()
        {
            DataTable GAtbl = db.getData("select max(appointment.appointmentId)+1 from appointment");
            txtregestrationNo.Text = GAtbl.Rows[0][0].ToString();
            if (txtregestrationNo.Text.Trim() == "") txtregestrationNo.Text = "1";

        }

        private void appoinment_Load(object sender, EventArgs e)
        {
            pereparedgvpr();
            dt.Value=DateTime.Now;
           
            intializecombobox();
            dgvAppoinment.DataSource = db.fillTable("select appointment.appointmentId,patient.patientName,staff.staffName,appointment.appointmentDate ,specializations.SpecializationsName from appointment,patient,staff,specializations where appointment.staffId=staff.staffId and appointment.patientId=patient.patientId and specializations.SpecializationsId=appointment.SpecializationsId and appointment.active =1", tbl); 
            
            GetAuto();
            
        }

        
        private void delete()
        {

            if (dgvAppoinment.CurrentRow != null)
            {

                db.run("update appointment set active=0 appointmentId =" + dgvAppoinment.CurrentRow.Cells[0].Value);
                dgvAppoinment.Rows.Remove(dgvAppoinment.CurrentRow);
            }
        }

       

        

        private void mybutton2_Click(object sender, EventArgs e)
        {
            GetAuto();
            intialize();
            if (rgx.checkId(strRegestaion))
            {

                Adding();
            }
            else lblmessege.Text = "يرجى ادخال رقم صحيح فى خانه رقم الحجز ";
            GetAuto();
        }

        private void mybutton1_Click(object sender, EventArgs e)
        {
            intialize();
            if (rgx.checkId(strRegestaion))
            {

                Editing();
            }
            else lblmessege.Text = "يرجى ادخال رقم صحيح فى خانه رقم الحجز ";
            GetAuto();
        }

        private void mybutton3_Click(object sender, EventArgs e)
        {
            delete();
            GetAuto();
        }

        private void dgvAppoinment_Click(object sender, EventArgs e)
        {
            if (dgvAppoinment.CurrentRow != null)
            {
                txtregestrationNo.Text = dgvAppoinment.CurrentRow.Cells[0].Value.ToString();
                combpatient.Text = dgvAppoinment.CurrentRow.Cells[1].Value.ToString();
                combdoctor.Text = dgvAppoinment.CurrentRow.Cells[2].Value.ToString();
                mybutton1.Enabled = true;
                mybutton3.Enabled = true;


            }
            else
            {
                mybutton1.Enabled = false;
                mybutton3.Enabled = false;
            }
        }

        private void combspecialization_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void combspecialization_SelectedIndexChanged(object sender, EventArgs e)
        {
            combdoctor.DataSource = db.fillTable("select staff.staffId,staff.staffName from staff,profession,specializations where staff.professionID=profession.professionId and specializations.specializationsId = staff.specializationsId and profession.professionName='دكتور' and staff.active=1 and  specializations.specializationsName = '" + combspecialization.Text + "'", new DataTable());

            combdoctor.DisplayMember = "staffName";
            combdoctor.ValueMember = "staffId";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            dgvAppoinment.DataSource = tbl;
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
                db.fillTable("select appointment.appointmentId,patient.patientName,staff.staffName,appointment.appointmentDate ,specializations.SpecializationsName from appointment,patient,staff,specializations where appointment.staffId=staff.staffId and appointment.patientId=patient.patientId and specializations.SpecializationsId=appointment.SpecializationsId and appointment.active =1 "+ " and patientName = '"+txtsearch.Text+"'", tblSearch);
                dgvAppoinment.DataSource = tblSearch;
                btnback.Visible = true;
                btnsearch.Visible = false;
            }
            else lblmessege.Text = "الرجاء ادخال اسم المريض فى صوره حروف عربيه او انجليزيه فقط   ";
        }

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboSearch.GetItemText(comboSearch.SelectedItem);
            dgvAppoinment.DataSource = db.fillTable("select appointment.appointmentId,patient.patientName,staff.staffName,appointment.appointmentDate ,specializations.SpecializationsName from appointment,patient,staff,specializations where appointment.staffId=staff.staffId and appointment.patientId=patient.patientId and specializations.SpecializationsId=appointment.SpecializationsId and appointment.active =1 and  staff.staffName = '" + selected+"'", new DataTable());
            
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
    }
}


