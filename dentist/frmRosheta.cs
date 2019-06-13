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
    public partial class frmRosheta : Form
    {
        public frmRosheta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool mousdown = false;
        private Point lastLOcation;

        private void Pnlheader_MouseUp(object sender, MouseEventArgs e)
        {
            mousdown = false;
            Pnlheader.Cursor = Cursors.Default;

        }

        private void Pnlheader_MouseDown(object sender, MouseEventArgs e)
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

        private void frmRosheta_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon("dentist.exe");

            this.reportViewer1.RefreshReport();
        }
    }
}
