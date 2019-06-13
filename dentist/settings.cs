using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class settings : Form
    {
        frmMain fr;
        DB db = new DB();
        public settings(frmMain fr)
        {
            InitializeComponent();
            this.fr = fr;
        }


        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controls.Clear();
            if (comboSearch.SelectedIndex == 1)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            }
            if (comboSearch.SelectedIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
            }
            if (comboSearch.SelectedIndex == 2)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
            }
            //InitializeComponent();
            fr.Hide();
            var frmMain = new frmMain();





            frmMain.Closed += (s, args) => fr.Close();
            frmMain.Show();
            var settings = new settings(frmMain);
            frmMain.mainpanel.Controls.Clear();
            settings.TopLevel = false;
            frmMain.mainpanel.Controls.Add(settings);
            settings.FormBorderStyle = FormBorderStyle.None;
            settings.Dock = DockStyle.Fill;
            settings.Show();

        }

        private void settings_Load(object sender, EventArgs e)
        {
            DataTable tblspec = new DataTable();
            tblspec = db.getData("select * from login where userName ='" + login.User + "' and password ='" + login.pass + "' and role =2");
            if (tblspec.Rows.Count > 0)
            {
                txtusername.Enabled = false;
                txtusername.Text = login.User;
            }

            else

                txtusername.Enabled = true;

            if (frmMain.systemuser == 2 | frmMain.systemuser == 3)
            {
                button1.Enabled = false;
            }
        }
        regularExpression g = new regularExpression();

        private void button3_Click(object sender, EventArgs e)
        {
            if (g.checkName(txtusername.Text) & g.checkString(txtpassword.Text))
            {
                DataTable tbl =
         db.getData("select * from login where userName ='" + txtusername.Text + "' and password ='" + txtpassword.Text + "'");
                if (tbl.Rows.Count == 0)
                {

                    db.run("update login set userName ='" + txtusername.Text + "' , password ='" + txtpassword.Text + "' where userName='" + login.User + "' and password ='" + login.pass + "'");

                    lblmessege.Text = "تم تغير بيانات الدخول";
                }
                else lblmessege.Text = "بيانات موجوده مسبقا ";
            }
            else lblmessege.Text = "تاكد من صحه البيانات";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmBackUp().Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
