using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Clinic
{
    public partial class frmTreatmentPlan : Form
    {
        public frmTreatmentPlan()
        {
            InitializeComponent();
        }
        


        // متتخضش من الميثود دى دى بس بتظبط شكل الداتا جريد فيو سيبك منها الوقتى 
        private void pereparedgvpr()
        {
            // dgvpr.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvg2.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dvg2.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 12);
            dvg2.BorderStyle = BorderStyle.None;
            dvg2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dvg2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvg2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dvg2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dvg2.BackgroundColor = Color.White;

            dvg2.EnableHeadersVisualStyles = false;
            dvg2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dvg2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dvg2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        string strNum;
        string strName;
        DB db = new DB();
        DataTable tbl = new DataTable();
        regularExpression rg = new regularExpression();
        private void intialize()
        {
            strNum = txtMedicineId.Text;
            strName = txtMedicineName.Text;

        }

        private void add()
        {

            object[] data = { strNum, strName };
            tbl.Rows.Add(data);

        }

        private void edit()
        {
            if (dvg2.CurrentRow != null)
            {
                
                dvg2.CurrentRow.Cells[1].Value = txtMedicineName.Text;


            }
        }
        private void delete()
        {

            if (dvg2.CurrentRow != null)
            {
                db.run("delete from medicine_specialization where medicineId =" + dvg2.CurrentRow.Cells[0].Value + " and SpecializationsId ="+combspecialization.SelectedValue);
                dvg2.Rows.Remove(dvg2.CurrentRow);
              
            }
        }

     
   

        private void btndelete_Click(object sender, EventArgs e)
        {

            delete();
        }

        private void intializecombobox()
        {
            DataTable tblspec = new DataTable();
           
            combspecialization.DataSource = db.fillTable("select * from specializations where SpecializationsId!=0", tblspec);
            combspecialization.DisplayMember = "SpecializationsName";
            combspecialization.ValueMember = "SpecializationsId";
         
        }

        private void treatmentPlan_Load(object sender, EventArgs e)
        {
            DB.open();
            pereparedgvpr();
            intializecombobox();

          
          

        }



        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = combspecialization.GetItemText(combspecialization.SelectedItem);
            dvg2.DataSource = db.fillTable("select medicineId,medicineName from medicine_specialization , specializations where medicine_specialization.SpecializationsId=specializations.SpecializationsId and specializations.SpecializationsName= '" + selected + "'", tbl=new DataTable());
        }

        private void dvg2_Click(object sender, EventArgs e)
        {
                        if (dvg2.CurrentRow !=null)
            {

                txtMedicineId.Text = dvg2.CurrentRow.Cells[0].Value.ToString();
                txtMedicineName.Text = dvg2.CurrentRow.Cells[1].Value.ToString();
                mybutton2.Enabled = true;
                mybutton3.Enabled = true;


            }
            else
            {
                mybutton2.Enabled = false;
                mybutton3.Enabled = false;

            }
        }

        private void mybutton3_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void mybutton1_Click(object sender, EventArgs e)
        {
            intialize();
            if (rg.checkId(strNum))
            {
            if (rg.checkName(strName))
            {
                    try
                    {
                        lblmessege.Text = "";
                    
                    db.run("insert into medicine_specialization values (" + strNum + ",'" + strName + "'," + combspecialization.SelectedValue + ")");
                    add();


                    }
                    catch (Exception ex)
                    {
                        lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

                    }
                }
            else lblmessege.Text = "تاكد ان الاسم والمسافات صحيحه";
            }
            else lblmessege.Text = "يسمح فقط بلارقام";
        }

        private void mybutton2_Click(object sender, EventArgs e)
        {
            try
            {

                lblmessege.Text = "";
                intialize();
                db.run("update medicine_specialization set medicineName ='" + strName + "' where medicineId =" + strNum + " and SpecializationsId =" + combspecialization.SelectedValue);
                edit();
            }
            catch (Exception ex)
            {
                lblmessege.Text = "حدث خطا :" + "\t" + ex.Message + " !";

            }
        }

        
    }
}