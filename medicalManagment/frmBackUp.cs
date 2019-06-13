using Clinic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clinic
{
    public partial class frmBackUp : Form
    {
        public frmBackUp()
        {
            InitializeComponent();
        }

        private bool mousdown = false;
        private Point lastLOcation;


        private void Pnlheader_MouseDown(object sender, MouseEventArgs e)
        {
            mousdown = true;
            Pnlheader.Cursor = Cursors.Hand;
            lastLOcation = e.Location;
        }

        private void Pnlheader_MouseUp(object sender, MouseEventArgs e)
        {
            mousdown = false;
            Pnlheader.Cursor = Cursors.Default;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTakeBackup_Click(object sender, EventArgs e)
        {
            DB.close();

            try
            {
                //محتاج اعرف مكان الفولدر لما اخد الباكاب
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "رجاء إختر مكان لأخذ النسخة الإحتياطية";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    DateTime Now = DateTime.Now;
                    string fileName = fbd.SelectedPath + "\\dentist_" + Now.Year + "_" + Now.Month + "_" + Now.Day + "___" + Now.Hour + "_" + Now.Minute + "_" + Now.Second + ".db";
                    File.Copy("dent.db", fileName);
                    MessageBox.Show("تم أخذ النسخة الإحتياطية" + "\n" + "المكان الذى تم الحفظ فيه بالسطر التالى" + "\n" + fileName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DB.open();
        }

        private void btnRestoreBackup_Click(object sender, EventArgs e)
        {

            //هتحقق من الملف قبل ما ارجعه
            DB.close();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = " Files|*.db";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    //هعمل تشنج دى بى فايل نيم عالملف اللى هو اختاره
                    //عشان اتحقق من كل حاجة فيه حسب رغبتى
                    DB.changDBFileName(ofd.FileName);
                    DB.open();
                    string strAllTables = @" select appointment.appointmentDate ,patient.patientName,staff.staffName ,appointment.appointmentId,appointment.examined  from appointment,patient,staff where appointment.patientId=patient.patientId and staff.staffId =appointment.staffId order by appointment.appointmentId DESC ";
                    DB.GetData(strAllTables);
                    DB.close();
                    File.Delete("dent.db");
                    File.Copy(ofd.FileName, "dent.db");
                    DB.changDBFileName("dent.db");
                    MessageBox.Show("تم إسترجاع النسخة الإحتياطية بنجاح وسوف يعاد تشغيل البرنامج");

                }


                catch (Exception ex)
                {
                    MessageBox.Show("الملف الذى اختارته تالف لا يصلح" + "\n" + "وسوف يعاد تشغيل البرنامج");
                    //MessageBox.Show(ex.Message);
                }



                finally
                {
                    Application.Restart();
                }
            }
        }

        private void frmBackUp_Load(object sender, EventArgs e)
        {
        
        }

        private void Pnlheader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
