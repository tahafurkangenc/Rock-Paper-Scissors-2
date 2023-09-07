using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            hamleyapPictureBox.Visible = false;
            //Nesne Box 1 için
            if (Program.kullanicikartlariList[0].nesneadi.Equals("Tas"))
            {
                NesneBox1.Image = kartImageList.Images[0];
            }
            if (Program.kullanicikartlariList[0].nesneadi.Equals("Kagit"))
            {
                NesneBox1.Image = kartImageList.Images[1];
            }
            if (Program.kullanicikartlariList[0].nesneadi.Equals("Makas"))
            {
                NesneBox1.Image = kartImageList.Images[2];
            }


            // Nesne Box 2 için
            if (Program.kullanicikartlariList[1].nesneadi.Equals("Tas"))
            {
                NesneBox2.Image = kartImageList.Images[0];
            }
            if (Program.kullanicikartlariList[1].nesneadi.Equals("Kagit"))
            {
                NesneBox2.Image = kartImageList.Images[1];
            }
            if (Program.kullanicikartlariList[1].nesneadi.Equals("Makas"))
            {
                NesneBox2.Image = kartImageList.Images[2];
            }


            // Nesne Box 3 için
            if (Program.kullanicikartlariList[2].nesneadi.Equals("Tas"))
            {
                NesneBox3.Image = kartImageList.Images[0];
            }
            if (Program.kullanicikartlariList[2].nesneadi.Equals("Kagit"))
            {
                NesneBox3.Image = kartImageList.Images[1];
            }
            if (Program.kullanicikartlariList[2].nesneadi.Equals("Makas"))
            {
                NesneBox3.Image = kartImageList.Images[2];
            }


            // Nesne Box 4 için
            if (Program.kullanicikartlariList[3].nesneadi.Equals("Tas"))
            {
                NesneBox4.Image = kartImageList.Images[0];
            }
            if (Program.kullanicikartlariList[3].nesneadi.Equals("Kagit"))
            {
                NesneBox4.Image = kartImageList.Images[1];
            }
            if (Program.kullanicikartlariList[3].nesneadi.Equals("Makas"))
            {
                NesneBox4.Image = kartImageList.Images[2];
            }


            // Nesne Box 5 için
            if (Program.kullanicikartlariList[4].nesneadi.Equals("Tas"))
            {
                NesneBox5.Image = kartImageList.Images[0];
            }
            if (Program.kullanicikartlariList[4].nesneadi.Equals("Kagit"))
            {
                NesneBox5.Image = kartImageList.Images[1];
            }
            if (Program.kullanicikartlariList[4].nesneadi.Equals("Makas"))
            {
                NesneBox5.Image = kartImageList.Images[2];
            }

        }

        Nesne secilennesne;

        private void NesneBox1_Click(object sender, EventArgs e)
        {
            if (Program.kullanicikartlariList[0].dayaniklilik > 0.0)
            {
                SecilenBox.Image = NesneBox1.Image;
                hamleyapPictureBox.Visible = true;
                secilennesne = Program.kullanicikartlariList[0];
            }

        }

        private void NesneBox2_Click(object sender, EventArgs e)
        {
            if (Program.kullanicikartlariList[1].dayaniklilik > 0.0)
            {
                SecilenBox.Image = NesneBox2.Image;
                hamleyapPictureBox.Visible = true;
                secilennesne = Program.kullanicikartlariList[1];
            }
        }

        private void NesneBox3_Click(object sender, EventArgs e)
        {
            if (Program.kullanicikartlariList[2].dayaniklilik > 0.0)
            {
                SecilenBox.Image = NesneBox3.Image;
                hamleyapPictureBox.Visible = true;
                secilennesne = Program.kullanicikartlariList[2];
            }

        }

        private void NesneBox4_Click(object sender, EventArgs e)
        {
            if (Program.kullanicikartlariList[3].dayaniklilik > 0.0)
            {
                SecilenBox.Image = NesneBox4.Image;
                hamleyapPictureBox.Visible = true;
                secilennesne = Program.kullanicikartlariList[3];
            }

        }

        private void NesneBox5_Click(object sender, EventArgs e)
        {
            if (Program.kullanicikartlariList[4].dayaniklilik > 0.0)
            {
                SecilenBox.Image = NesneBox5.Image;
                hamleyapPictureBox.Visible = true;
                secilennesne = Program.kullanicikartlariList[4];
            }

        }

        private void hamleyapPictureBox_Click(object sender, EventArgs e)
        {
            //secilennesne.dayaniklilik = 10.0;
            Console.WriteLine("Pressed Button --- > Hamleyap");
            //Console.WriteLine(secilennesne.ToString());
            Console.WriteLine("Program.kullanicikartlariList.IndexOf(secilennesne) =" + Program.kullanicikartlariList.IndexOf(secilennesne));
            Nesne rakipnesne = Program.rakipkartlariList[Program.random.Next(Program.rakipkartlariList.Count)];
            //Savaştırma
            secilennesne.dayaniklilik=secilennesne.dayaniklilik-rakipnesne.etkiHesapla(secilennesne);
            rakipnesne.dayaniklilik = rakipnesne.dayaniklilik - secilennesne.etkiHesapla(rakipnesne);
            //ölüm kontrolü
            if (secilennesne.dayaniklilik <= 0.0)
            {
                if (Program.kullanicikartlariList.IndexOf(secilennesne) == 0) // NesneBox1
                {
                    NesneBox1.Image = kartImageList.Images[6];
                }
                if (Program.kullanicikartlariList.IndexOf(secilennesne) == 1) // NesneBox2
                {
                    NesneBox2.Image = kartImageList.Images[6];
                }
                if (Program.kullanicikartlariList.IndexOf(secilennesne) == 2) // NesneBox3
                {
                    NesneBox3.Image = kartImageList.Images[6];
                }
                if (Program.kullanicikartlariList.IndexOf(secilennesne) == 3) // NesneBox4
                {
                    NesneBox4.Image = kartImageList.Images[6];
                }
                if (Program.kullanicikartlariList.IndexOf(secilennesne) == 4) // NesneBox5
                {
                    NesneBox5.Image = kartImageList.Images[6];
                }
                rakipnesne.seviyePuani = rakipnesne.seviyePuani + 20;
            }
        }
    }
}
