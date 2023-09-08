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

        int tursayisi = 0;

        private void GameForm_Load(object sender, EventArgs e)
        {
            tursayisilabel.Text = "Tur Sayisi = " + tursayisi;
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

            if (secilennesne.dayaniklilik  > 0.0) {
                //Console.WriteLine(secilennesne.ToString());
                Console.WriteLine("Program.kullanicikartlariList.IndexOf(secilennesne) =" + Program.kullanicikartlariList.IndexOf(secilennesne));
                Nesne rakipnesne = Program.rakipkartlariList[Program.random.Next(Program.rakipkartlariList.Count)];

                /*----- RAKİPBOX FOTOĞRAF YERLEŞTİRME -----*/
                if (rakipnesne.nesneadi.Equals("Tas"))
                {
                    RakipBox.Image = kartImageList.Images[0];
                }
                if (rakipnesne.nesneadi.Equals("Kagit"))
                {
                    RakipBox.Image = kartImageList.Images[1];
                }
                if (rakipnesne.nesneadi.Equals("Makas"))
                {
                    RakipBox.Image = kartImageList.Images[2];
                }
                if (rakipnesne.nesneadi.Equals("Agir Tas"))
                {
                    RakipBox.Image = kartImageList.Images[3];
                }
                if (rakipnesne.nesneadi.Equals("Ozel Kagit"))
                {
                    RakipBox.Image = kartImageList.Images[4];
                }
                if (rakipnesne.nesneadi.Equals("Usta Makas"))
                {
                    RakipBox.Image = kartImageList.Images[5];
                }

                //Savaştırma
                secilennesne.dayaniklilik = secilennesne.dayaniklilik - rakipnesne.etkiHesapla(secilennesne);
                rakipnesne.dayaniklilik = rakipnesne.dayaniklilik - secilennesne.etkiHesapla(rakipnesne);
                //ölüm kontrolü
                if (secilennesne.dayaniklilik <= 0.0) // rakip nesne , seçilen nesneyi öldürürse
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
                    SecilenBox.Image = kartImageList.Images[6];
                    rakipnesne.seviyePuani = rakipnesne.seviyePuani + 20;
                    if (rakipnesne.seviyePuani > 30) // rakip nesne level atlarsa
                    {
                        //rakip nesne level atlarsa ekle
                    }
                }
                if (rakipnesne.dayaniklilik <= 0.0) // seçilen nesne , rakip nesneyi öldürürse
                {
                    secilennesne.seviyePuani = secilennesne.seviyePuani + 20;
                    if (secilennesne.seviyePuani > 30)
                    {
                        //seçilen nesne level atlarsa ekle
                    }
                    Program.rakipkartlariList.Remove(rakipnesne);
                    RakipBox.Image = kartImageList.Images[6];
                }
                /*--------------- YAZI GÜNCELLEMELERİ ---------------*/
                //Kullanıcının kartları:
                if (Program.kullanicikartlariList.IndexOf(secilennesne) == 0) // Label1
                {
                    dayanikliliklabel1.Text = "Dayanıklılık = " + secilennesne.dayaniklilik;
                    seviyepuanilabel1.Text = "Seviye Puanı = " + secilennesne.seviyePuani;
                }
                if (Program.kullanicikartlariList.IndexOf(secilennesne) == 1) // Label2
                {
                    dayanikliliklabel2.Text = "Dayanıklılık = " + secilennesne.dayaniklilik;
                    seviyepuanilabel2.Text = "Seviye Puanı = " + secilennesne.seviyePuani;
                }
                if (Program.kullanicikartlariList.IndexOf(secilennesne) == 2) // Label3
                {
                    dayanikliliklabel3.Text = "Dayanıklılık = " + secilennesne.dayaniklilik;
                    seviyepuanilabel3.Text = "Seviye Puanı = " + secilennesne.seviyePuani;
                }
                if (Program.kullanicikartlariList.IndexOf(secilennesne) == 3) // Label4
                {
                    dayanikliliklabel4.Text = "Dayanıklılık = " + secilennesne.dayaniklilik;
                    seviyepuanilabel4.Text = "Seviye Puanı = " + secilennesne.seviyePuani;
                }
                if (Program.kullanicikartlariList.IndexOf(secilennesne) == 4) // Label5
                {
                    dayanikliliklabel5.Text = "Dayanıklılık = " + secilennesne.dayaniklilik;
                    seviyepuanilabel5.Text = "Seviye Puanı = " + secilennesne.seviyePuani;
                }
                //Rakibin kartları:
                rakipdayanikliliklabel.Text = "Dayanıklılık = " + rakipnesne.dayaniklilik;
                rakipseviyepuanilabel.Text = "Seviye Puanı = " + rakipnesne.seviyePuani;
                /*----- Tur Sayısı Label Güncelleme -----*/
                tursayisi++;
                tursayisilabel.Text = "Tur Sayısı = " + tursayisi;
                double kullanicikartlaritoplamskor = 0;
                for (int i = 0; i < Program.kullanicikartlariList.Count; i++)
                {
                    kullanicikartlaritoplamskor = kullanicikartlaritoplamskor + Program.kullanicikartlariList[i].dayaniklilik;
                }
                if (Program.rakipkartlariList.Count <= 0 && kullanicikartlaritoplamskor <= 0)
                {
                    Console.WriteLine("OYUN BİTTİ ---> Berabere");
                }
                else if (Program.rakipkartlariList.Count <= 0)
                {
                    Console.WriteLine("OYUN BİTTİ ---> Kullanici kazandi");
                }
                else if (kullanicikartlaritoplamskor <= 0)
                {
                    Console.WriteLine("OYUN BİTTİ ---> Rakip kazandi");
                }
            }

        }
    }
}
