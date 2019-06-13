using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class pictures : Form
    {
        public pictures()
        {
            InitializeComponent();
        }
        DB db = new DB();
        OpenFileDialog ofd = new OpenFileDialog();
        string filename;
        string imageName;
        DataTable tbl = new DataTable();
        Image image;
        private void pereparedataGridView()
        {
            dataGridView.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 12);


            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void pictures_Load(object sender, EventArgs e)
        {
            pereparedataGridView();

            pictureBox1.AllowDrop = true;
            tbl = db.fillTable("select DISTINCT fileName,name from picture,patient,appointment where appointment.patientId=patient.patientId and picture.appointmentId = " + mainfrorm.appointmentId, tbl);
            dataGridView.DataSource = tbl;
            dataGridView.Columns["fileName"].Visible = false;



        }








        private void add()
        {
            object[] data = { ofd.FileName, imageName };
            tbl.Rows.Add(data);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ofd.FileName != "")
            {
                DB.cmd.CommandText = "insert into picture(appointmentId,pictureId,picturePath,fileName,name) values (" + mainfrorm.appointmentId + ",NULL,@img,'" + ofd.FileName + "','" + imageName + "')";
                DB.cmd.Parameters.AddWithValue("@img", File.ReadAllBytes(ofd.FileName));
                DB.cmd.ExecuteNonQuery();
                if (!Directory.Exists("img"))
                    Directory.CreateDirectory("img");
                if (!Directory.Exists("img/" + mainfrorm.patientName))
                    Directory.CreateDirectory("img/" + mainfrorm.patientName);
                pictureBox1.Image.Save("img/" + mainfrorm.patientName + "/" + imageName + ".jpg");
                add();
            }

        }

        private void btnopen_Click_1(object sender, EventArgs e)
        {
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Filter = "*.jpg|*.png";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    Bitmap bm = new Bitmap(Image.FromFile(ofd.FileName), new Size(682, 403));
                    pictureBox1.Image = bm;
                    filename = ofd.FileName;
                    imageName = Path.GetFileNameWithoutExtension(ofd.FileName.ToString());


                    image = Image.FromFile(ofd.FileName);
                    btnback.Enabled = true;
                    trackBar.Enabled = true;
                    btnSave.Enabled = true;
                }

            }
        }
        Image Zoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }
        private void pictureBox1_DragEnter_1(object sender, DragEventArgs e)
        {

            btnopen.Enabled = false;
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_DragDrop_1(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);

            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    pictureBox1.Image = new Bitmap(Image.FromFile(fileNames[0]), new Size(500, 400));
                filename = fileNames[0];
            }
        }



        private void dataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            DataTable tblimg = new DataTable();
            db.fillTable("select picturePath from picture where fileName='" + dataGridView.CurrentRow.Cells[0].Value.ToString() + "'", tblimg);
            byte[] img = (byte[])tblimg.Rows[0][0];

            MemoryStream ms = new MemoryStream(img);

            pictureBox1.Image = Image.FromStream(ms);
            image = pictureBox1.Image;
            btnback.Enabled = true;
            trackBar.Enabled = true;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (trackBar.Value > 0 & image != null)
            {
                panel1.AutoScroll = true;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = Zoom(image
                   , new Size(trackBar.Value, trackBar.Value));
                pictureBox1.Dock = DockStyle.None;



            }
        }

        private void pictures_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)

            {
                pictureBox1.Dispose();
            }
       
        }

        private void mybutton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = image;
            panel1.AutoScroll = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void delete()
        {

            if (dataGridView.CurrentRow != null)
            {
                db.run("delete from picture where picture.fileName ='" + dataGridView.CurrentRow.Cells[0].Value + "'");

                dataGridView.Rows.Remove(dataGridView.CurrentRow);
            }
        }
       

       
        private void btndel_Click_1(object sender, EventArgs e)
        {
            delete();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            btndel.Enabled = true;

        }
    }
}
