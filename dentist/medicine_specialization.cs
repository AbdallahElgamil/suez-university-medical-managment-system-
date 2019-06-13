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
    public partial class medicine_specialization : Form
    {
        frmMedicine m;
        public medicine_specialization(frmMedicine m)
        {
            InitializeComponent();
            this.m = m;
        }
        DB db = new DB();
        DataTable tbl = new DataTable();
        int id;
        string sid;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbxprivilege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btngive_Click(object sender, EventArgs e)
        {
            if (newMedicine.Text!="")
            {

                DataTable idtbl = db.getData("select max(medicine_specialization.medicineId) + 1 from medicine_specialization, specializations where specializations.SpecializationsId = medicine_specialization.SpecializationsId and specializations.SpecializationsId = " + mainfrorm.specilizationId);

                sid = idtbl.Rows[0][0].ToString();
                if (sid.Trim() == "") sid= "1";
                id = Int32.Parse(sid);


                db.run("insert into medicine_specialization values("+id+",'" + newMedicine.Text + "','"+mainfrorm.specilizationId+"')");
                lblspecilization.Text = mainfrorm.specilization;
                lbxmedicine.DataSource = db.fillTable("select medicineName from medicine_specialization,specializations where medicine_specialization.SpecializationsId = specializations.SpecializationsId and SpecializationsName = '" + mainfrorm.specilization + "'", tbl=new DataTable());
                lbxmedicine.DisplayMember = "medicineName";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void medicine_specialization_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon("dentist.exe");
            lblspecilization.Text = mainfrorm.specilization;
            lbxmedicine.DataSource = db.fillTable("select medicineName from medicine_specialization,specializations where medicine_specialization.SpecializationsId = specializations.SpecializationsId and SpecializationsName = '" + mainfrorm.specilization+  "'", tbl);
            lbxmedicine.DisplayMember = "medicineName";
        }

        private void lbxmedicine_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblmessege.Text = "";
            if (lbxmedicine.SelectedItem != null & numericUpDowntime.Value > 0 & numericUpDownamount.Value > 0)
            {
                m.txtMedicine.Text += lbxmedicine.GetItemText(lbxmedicine.SelectedItem) + "  الجرعه  " + numericUpDownamount.Value.ToString();
                m.txtMedicine.Text += "  لمده  " + numericUpDowntime.Value.ToString() + "  ايام  ";
                m.txtMedicine.Text += Environment.NewLine;
            }
            else lblmessege.Text = "الرجاء اختيار علاج والجرعه والمده  ";
        }

        private void lbxmedicine_Click(object sender, EventArgs e)
        {
            if (lbxmedicine.SelectedItem != null)
                btnAdd.Enabled = true;
            else btnAdd.Enabled = false;


        }

        private void newMedicine_TextChanged(object sender, EventArgs e)
        {
            if (newMedicine.Text=="")
            {
                btnaddNew.Enabled = false;
            }
            else btnaddNew.Enabled = true;
        }
    }
}
