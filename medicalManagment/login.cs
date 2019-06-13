using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Clinic
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        DB db =new DB();
        public static string User;
        public static string pass;

        private bool mousdown = false;
        private Point lastLOcation;


        public static String DBFileName = "dent.db";

        private void login_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon("dentist.exe");

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=" + DBFileName))
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from login where userName like @username and password = @password");
                cmd.Parameters.AddWithValue("@username", txtname.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                cmd.Connection = con;
                con.Open();

                DataSet ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                if (loginSuccessful)
                {
                    User = txtname.Text;
                    pass = txtpass.Text;


                    this.Hide();
                    var frmMain = new frmMain();
                    frmMain.Closed += (s, args) => this.Close();
                    frmMain.Show();

                }
                else
                    lblmessege.Text = "بيانات خاطئه ";
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousdown = false;
            panel1.Cursor = Cursors.Default;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousdown = true;
            panel1.Cursor = Cursors.Hand;
            lastLOcation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousdown)
            {
                int newX = (this.Location.X - lastLOcation.X) + e.X;
                int newY = (this.Location.Y - lastLOcation.Y) + e.Y;
                this.Location = new Point(newX, newY);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
