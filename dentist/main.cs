using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            
        }
        public void refrech()
        {
            InitializeComponent();
        }

        DataTable tbl = new DataTable();
        DB db = new DB();
        public static int systemuser;
        private const int CGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - CGrip && pos.Y >= this.ClientSize.Height - CGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }

            }
            base.WndProc(ref m);
        }
        private bool mousdown = false;
        private Point lastLOcation;
        private  bool labelClicked=false;
        string labelSelected;

        private void formChange(Form fr)
        {
           
            mainpanel.Controls.Clear();
            fr.TopLevel = false;
            mainpanel.Controls.Add(fr);
            fr.FormBorderStyle = FormBorderStyle.None;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }
        private void oldColor(Label lbl)
        {
            lbl.BackColor = Color.Navy;
        }
        private void newColor(Label lbl)
        {
            lbl.BackColor = Color.LightSkyBlue;
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon("dentist.exe");
            DB.open();
            label.BackColor =Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            
             tbl =db.getData("select role from login where userName ='" + login.User + "' and password ='" + login.pass + "'");
            if (int.Parse(tbl.Rows[0][0].ToString()) == 0)
            {
                systemuser = 0;
                lblPatient.Enabled = true;
                lblsettings.Enabled = true;
                lblStaff.Enabled = true;
                lblProfessio.Enabled = true; 
                lblappointment.Enabled = true;
                lblmedicines.Enabled = true;
                lblSpecilization.Enabled = true;
                lblusers.Enabled = true;
                lblMian.Enabled = true;

            }
            if (int.Parse(tbl.Rows[0][0].ToString())==1)
            {
                systemuser = 1;
                lblPatient.Enabled = true;
                lblsettings.Enabled = true;
                lblStaff.Enabled = true;
                lblProfessio.Enabled = true;
                lblappointment.Enabled = true;
                lblmedicines.Enabled = true;
                lblSpecilization.Enabled = true;
                lblusers.Enabled = true;
                lblMian.Enabled = true;

            }
            if (int.Parse(tbl.Rows[0][0].ToString()) == 2)
            {
                systemuser = 2;
                lblMian.Enabled = true;
                lblsettings.Enabled = true;
                lblPatient.Enabled = true;
            }
            if (int.Parse(tbl.Rows[0][0].ToString()) == 3)
            {
                systemuser = 3;
                lblPatient.Enabled = true;
                lblsettings.Enabled = true;
                lblStaff.Enabled = true;
                lblProfessio.Enabled = true;
                lblappointment.Enabled = true;
                lblmedicines.Enabled = true;
                lblSpecilization.Enabled = true;


            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Clinic.DB.cmd.CommandText = "insert into profession values(1,'doctor')";
            Clinic.DB.cmd.ExecuteNonQuery();

        }

      

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clinic.DB.close();


        }

      

       



     
     

       

     

       
      

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (this.WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

       


       

        private void lblMian_Click(object sender, EventArgs e)
        {
            mainfrorm fr = new mainfrorm(this);
            formChange(fr);
            labelClicked = true;
            labelSelected = "lblmain";
            newColor((Label)sender);
            oldColor(lblPatient);
            oldColor(lblStaff);
            oldColor(lblappointment);
            oldColor(lblProfessio);
            oldColor(lblSpecilization);
            oldColor(lblsettings);
            oldColor(lblmedicines);
            oldColor(lblusers);
            oldColor(lblout);

        }

        private void lblMian_MouseLeave(object sender, EventArgs e)
        {
            if (labelSelected != "lblmain" )
            {
                oldColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Arrow;
                
            }
        }

        private void lblMian_MouseHover(object sender, EventArgs e)
        {
           
                newColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Hand;
        }

        private void lblPatient_Click(object sender, EventArgs e)
        {
            frmpatient fr =new frmpatient();
            formChange(fr);
            newColor((Label)sender);
            labelClicked = true;
            labelSelected = "lblPatient";
            oldColor(lblMian);
            oldColor(lblStaff);
            oldColor(lblappointment);
            oldColor(lblProfessio);
            oldColor(lblSpecilization);
            oldColor(lblsettings);
            oldColor(lblmedicines);
            oldColor(lblusers);
            oldColor(lblout);

        }

        private void lblPatient_MouseHover(object sender, EventArgs e)
        {
            newColor((Label)sender);
            ((Label)sender).Cursor = Cursors.Hand;
        }

        private void lblPatient_MouseLeave(object sender, EventArgs e)
        {
            if (labelSelected != "lblPatient" )
            {
                oldColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Arrow;
                
            }
        }

        private void lblStaff_Click(object sender, EventArgs e)
        {
            frmStaff fr = new frmStaff();
            formChange(fr);
            newColor((Label)sender);
            labelClicked = true;
            labelSelected = "lblstaff";
            oldColor(lblMian);
            oldColor(lblPatient);
            oldColor(lblappointment);
            oldColor(lblProfessio);
            oldColor(lblSpecilization);
            oldColor(lblsettings);
            oldColor(lblmedicines);
            oldColor(lblusers);
            oldColor(lblout);

        }

        private void lblStaff_MouseHover(object sender, EventArgs e)
        {
            newColor((Label)sender);
            ((Label)sender).Cursor = Cursors.Hand;
        }

        private void lblStaff_MouseLeave(object sender, EventArgs e)
        {
            if (labelSelected != "lblstaff")
            {
                oldColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Arrow;

            }
        }

        private void lblappointment_Click(object sender, EventArgs e)
        {
            frmappoinment fr = new frmappoinment();
            formChange(fr);
            newColor((Label)sender);
            labelClicked = true;
            labelSelected = "lblappointment";
            oldColor(lblMian);
            oldColor(lblPatient);
            oldColor(lblStaff);
            oldColor(lblProfessio);
            oldColor(lblSpecilization);
            oldColor(lblsettings);
            oldColor(lblmedicines);
            oldColor(lblusers);
            oldColor(lblout);

        }

        private void lblappointment_MouseHover(object sender, EventArgs e)
        {
            newColor((Label)sender);
            ((Label)sender).Cursor = Cursors.Hand;
        }

        private void lblappointment_MouseLeave(object sender, EventArgs e)
        {
            if (labelSelected != "lblappointment")
            {
                oldColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Arrow;

            }
        }

        private void lblProfessio_Click(object sender, EventArgs e)
        {

            frmprofession fr = new frmprofession();
            formChange(fr);
            newColor((Label)sender);
            labelClicked = true;
            labelSelected = "lblprofession";
            oldColor(lblMian);
            oldColor(lblPatient);
            oldColor(lblappointment);
            oldColor(lblStaff);
            oldColor(lblSpecilization);
            oldColor(lblsettings);
            oldColor(lblmedicines);
            oldColor(lblusers);
            oldColor(lblout);

        }

        private void lblProfessio_MouseHover(object sender, EventArgs e)
        {
            newColor((Label)sender);
            ((Label)sender).Cursor = Cursors.Hand;
        }

        private void lblProfessio_MouseLeave(object sender, EventArgs e)
        {
            if (labelSelected != "lblprofession")
            {
                oldColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Arrow;

            }
        }

        private void lblSpecilization_Click(object sender, EventArgs e)
        {
            frmSpecialization fr = new frmSpecialization();
            formChange(fr);
            newColor((Label)sender);
            labelClicked = true;
            labelSelected = "lblspecilization";
            oldColor(lblMian);
            oldColor(lblPatient);
            oldColor(lblappointment);
            oldColor(lblProfessio);
            oldColor(lblStaff);
            oldColor(lblsettings);
            oldColor(lblmedicines);
            oldColor(lblusers);
            oldColor(lblout);


        }

        private void lblSpecilization_MouseHover(object sender, EventArgs e)
        {
            newColor((Label)sender);
            ((Label)sender).Cursor = Cursors.Hand;
        }

        private void lblSpecilization_MouseLeave(object sender, EventArgs e)
        {
            if (labelSelected != "lblspecilization")
            {
                oldColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Arrow;

            }
        }

        //private void lblPrivilege_Click(object sender, EventArgs e)
        //{
        //    frmPriviledge fr = new frmPriviledge();
        //    formChange(fr);
        //    newColor((Label)sender);
        //    labelClicked = true;
        //    labelSelected = "Priviledge";
        //    oldColor(lblMian);
        //    oldColor(lblPatient);
        //    oldColor(lblappointment);
        //    oldColor(lblProfessio);
        //    oldColor(lblSpecilization);
        //    oldColor(lblStaff);
        //}

        private void mainpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            settings fr = new settings(this);
            formChange(fr);
            newColor((Label)sender);
            labelClicked = true;
            labelSelected = "lblsettings";
            oldColor(lblMian);
            oldColor(lblPatient);
            oldColor(lblappointment);
            oldColor(lblProfessio);
            oldColor(lblSpecilization);
            oldColor(lblStaff);
            oldColor(lblmedicines);
            oldColor(lblusers);
            oldColor(lblout);


        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            newColor((Label)sender);
            ((Label)sender).Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (labelSelected != "lblsettings")
            {
                oldColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Arrow;

            }
        }

        private void Pnlheader_Paint(object sender, PaintEventArgs e)
        {

        }

        

       

        private void Pnlheader_MouseDown_1(object sender, MouseEventArgs e)
        {
            mousdown = true;
            Pnlheader.Cursor = Cursors.Hand;
            lastLOcation = e.Location;
        }

        private void Pnlheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousdown)
            {
                int newX = (this.Location.X - lastLOcation.X) + e.X;
                int newY = (this.Location.Y - lastLOcation.Y) + e.Y;
                this.Location = new Point(newX, newY);
            }
        }

        private void Pnlheader_MouseUp(object sender, MouseEventArgs e)
        {
            mousdown = false;
            Pnlheader.Cursor = Cursors.Default;
        }

     

        private void lblmedicines_Click(object sender, EventArgs e)
        {
            frmTreatmentPlan fr = new frmTreatmentPlan();
            formChange(fr);
            newColor((Label)sender);
            labelClicked = true;
            labelSelected = "TreatmentPlan";
            oldColor(lblMian);
            oldColor(lblPatient);
            oldColor(lblappointment);
            oldColor(lblProfessio);
            oldColor(lblSpecilization);
            oldColor(lblStaff);
            oldColor(lblsettings);
            oldColor(lblusers);
            oldColor(lblout);
        }

        private void lblmedicines_MouseHover(object sender, EventArgs e)
        {
            newColor((Label)sender);
            ((Label)sender).Cursor = Cursors.Hand;
        }

        private void lblmedicines_MouseLeave(object sender, EventArgs e)
        {
            if (labelSelected != "TreatmentPlan")
            {
                oldColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Arrow;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new login();
            login.Closed += (s, args) => this.Close();
            login.Show();

            labelClicked = true;
            labelSelected = "lblusers";
            oldColor(lblMian);
            oldColor(lblPatient);
            oldColor(lblappointment);
            oldColor(lblProfessio);
            oldColor(lblSpecilization);
            oldColor(lblStaff);
            oldColor(lblsettings);
            oldColor(lblmedicines);
            oldColor(lblusers);
            
        }

     

        private void lblusers_MouseHover(object sender, EventArgs e)
        {
            newColor((Label)sender);
            ((Label)sender).Cursor = Cursors.Hand;
        }

        private void lblusers_MouseLeave(object sender, EventArgs e)
        {
            if (labelSelected != "lblusers")
            {
                oldColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Arrow;

            }
        }

        private void lblout_MouseLeave(object sender, EventArgs e)
        {
            if (labelSelected != "lblout")
            {
                oldColor((Label)sender);
                ((Label)sender).Cursor = Cursors.Arrow;

            }
        }

        private void lblout_MouseHover(object sender, EventArgs e)
        {
            newColor((Label)sender);
            ((Label)sender).Cursor = Cursors.Hand;
        }

        private void lblusers_Click(object sender, EventArgs e)
        {
            frmPriviledge fr = new frmPriviledge();
            formChange(fr);
            newColor((Label)sender);
            labelClicked = true;
            labelSelected = "lblusers";
            oldColor(lblMian);
            oldColor(lblPatient);
            oldColor(lblappointment);
            oldColor(lblProfessio);
            oldColor(lblSpecilization);
            oldColor(lblStaff);
            oldColor(lblsettings);
            oldColor(lblmedicines);
            oldColor(lblout);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
