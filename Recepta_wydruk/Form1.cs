using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace Recepta_wydruk
{
    public partial class Recepta : Form
    {
        string Datawystawienia = DateTime.Now.ToShortDateString();
        string DataRealizacjiOd = "X";
        public Recepta()
        {
            InitializeComponent();
        }

        private void DrukPodglad_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f1 = new Font("Times New Roman", 12);
            Font f2 = new Font("Times New Roman Bold", 14);
            Font f3 = new Font("Times New Roman", 10);
            Font f4 = new Font("Times New Roman", 8);
            Pen p1 = new Pen(Color.Black, 5);
            Pen p2 = new Pen(Color.Black, 2);
            Pen p3 = new Pen(Color.Black, 2);
            p3.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Point[] point = { new Point(0, 0), new Point(400, 0), new Point(400, 800), new Point(0, 800), new Point(0, 0) };
            //rysowanie recepty
                g.DrawString(label1.Text, f1, Brushes.Black, 20, 20);
                g.DrawString(ReceptaPoleNumer.Text, f2, Brushes.Black, 120, 20);
                g.DrawString(SwiadczeniodawawcaNazwa.Text, f1, Brushes.Black, 20, 50);
                g.DrawString(label2.Text, f1, Brushes.Black, 20, 115);
                g.DrawString(NipPole.Text, f1, Brushes.Black, 60, 115);
                g.DrawString(label3.Text, f1, Brushes.Black, 20, 135);
                g.DrawString(RegonPole.Text, f1, Brushes.Black, 90, 135);
                g.DrawString(groupBox2.Text, f1, Brushes.Black, 20, 175);
            g.DrawImage(pictureBox2.Image, 200, 175);
            g.DrawLine(p2, 10, 225, 390, 225);
            g.DrawString(groupBox3.Text, f3, Brushes.Black, 20, 230);
            g.DrawString(PacjentPole.Text, f3, Brushes.Black, 20, 250);
            g.DrawString(label4.Text, f3, Brushes.Black, 20, 320);
            g.DrawString(PeselPole.Text, f3, Brushes.Black, 90, 320);
            g.DrawImage(pictureBox3.Image, 20, 340);
            g.DrawLine(p2, 300, 225, 300, 390);
            g.DrawLine(p2, 10, 390, 390, 390);
            g.DrawLine(p2, 300, 310, 390, 310);
            g.DrawString(groupBox4.Text, f3, Brushes.Black, 305, 230);
            g.DrawString(OdzialPole.Text, f2, Brushes.Black, 315, 250);
            g.DrawString("Uprawnienia", f3, Brushes.Black, 305, 315);
            g.DrawString("dodatkowe", f3, Brushes.Black, 305, 330);
            g.DrawString(UprawnieniaPole.Text, f2, Brushes.Black, 315, 355);
            g.DrawLine(p3, 10, 415, 390, 415);
            g.DrawString("Rp", f3, Brushes.Black, 20, 395);
            g.DrawString("Odpłatność", f3, Brushes.Black, 305, 395);
            g.DrawString(LekPozycja1.Text, f4, Brushes.Black, 20, 420);
            g.DrawString(OdplatnoscPoz1.Text, f3, Brushes.Black, 315, 430);
            g.DrawLine(p3, 10, 460, 390, 460);
            g.DrawString(LekPozycja2.Text, f4, Brushes.Black, 20, 465);
            g.DrawString(OdplatnoscPoz2.Text, f3, Brushes.Black, 315, 480);
            g.DrawLine(p3, 10, 505, 390, 505);
            g.DrawString(LekPozycja3.Text, f4, Brushes.Black, 20, 510);
            g.DrawString(OdplatnoscPoz3.Text, f3, Brushes.Black, 315, 520);
            g.DrawLine(p3, 10, 550, 390, 550);
            g.DrawString(LekPozycja4.Text, f4, Brushes.Black, 20, 555);
            g.DrawString(OdplatnoscPoz4.Text, f3, Brushes.Black, 315, 565);
            g.DrawLine(p3, 10, 595, 390, 595);
            g.DrawString(LekPozycja5.Text, f4, Brushes.Black, 20, 600);
            g.DrawString(OdplatnoscPoz5.Text, f3, Brushes.Black, 315, 610);
            g.DrawLine(p3, 10, 640, 390, 640);
            g.DrawLine(p3, 300, 390, 300, 640);
            g.DrawImage(pictureBox4.Image, 100, 645);
            g.DrawString(ReceptaPoleNumer.Text, f4, Brushes.Black, 120, 685);
            g.DrawLine(p2, 10, 700, 390, 700);
            g.DrawLine(p2, 10, 750, 140, 750);
            g.DrawLine(p2, 140, 700, 140, 795);
            g.DrawString(groupBox6.Text, f4, Brushes.Black, 15, 705);
            g.DrawString(Datawystawienia, f4, Brushes.Black, 20, 725);
            g.DrawString(groupBox7.Text, f4, Brushes.Black, 15, 755);
            g.DrawString(DataRealizacjiOd, f4, Brushes.Black, 20, 775);
            g.DrawString(groupBox8.Text, f4, Brushes.Black, 145, 705);
            g.DrawString(label6.Text, f4, Brushes.Black, 185, 715);
            g.DrawString(LekarzNazwa.Text, f4, Brushes.Black, 225, 715);
            g.DrawString(label5.Text, f4, Brushes.Black, 185, 730);
            g.DrawString(LekarzNumer.Text, f4, Brushes.Black, 225, 730);
            g.DrawImage(pictureBox5.Image, 200, 745);
            g.DrawString("Wydruk własny", f4, Brushes.Black, 200, 785);
            // linie wyznaczajce receptę
            g.DrawLines(p1, point);
            //g.Dispose();



        } 

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ReceptaPoleNumer_TextChanged(object sender, EventArgs e)
        {
            BarCode(ReceptaPoleNumer.Text, pictureBox4);
            DrukPodglad.Invalidate();
        }

        private void SwiadczeniodawawcaNazwa_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void NipPole_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void RegonPole_TextChanged(object sender, EventArgs e)
        {
            BarCode(RegonPole.Text, pictureBox2 );
            DrukPodglad.Invalidate();
        }

        void BarCode (string value, PictureBox image)
        {
            try
            {
                Code128BarcodeDraw code = BarcodeDrawFactory.Code128WithChecksum;
                System.Drawing.Image img = code.Draw(value, 40);
                image.Image = img;
            }
            catch (Exception)
            {
                image.Image = pictureBox1.Image;
            }
        }

        private void PacjentPole_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void PeselPole_TextChanged(object sender, EventArgs e)
        {
            BarCode(PeselPole.Text, pictureBox3);
            DrukPodglad.Invalidate();
        }

        private void OdzialPole_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void UprawnieniaPole_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void LekPozycja1_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void OdplatnoscPoz1_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void LekPozycja2_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void OdplatnoscPoz2_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void LekPozycja3_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void OdplatnoscPoz3_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void LekPozycja4_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void OdplatnoscPoz4_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void LekPozycja5_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void OdplatnoscPoz5_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void LekarzNazwa_TextChanged(object sender, EventArgs e)
        {
            DrukPodglad.Invalidate();
        }

        private void LekarzNumer_TextChanged(object sender, EventArgs e)
        {
            BarCode(LekarzNumer.Text, pictureBox5);
            DrukPodglad.Invalidate();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker2.Value;
            DataRealizacjiOd = dt.ToShortDateString();
            DrukPodglad.Invalidate();
        }

        private void Bdrukuj_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();

        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(DrukPodglad.Width, DrukPodglad.Height);
            DrukPodglad.DrawToBitmap(bm, new Rectangle(0, 0, DrukPodglad.Width, DrukPodglad.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bdrukuj_Click(sender, e);
        }
    }
}
