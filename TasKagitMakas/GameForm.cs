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

            if (secilennesne.dayaniklilik > 0.0)
            {
                //Console.WriteLine(secilennesne.ToString());
                Console.WriteLine("Program.kullanicikartlariList.IndexOf(secilennesne) =" + Program.kullanicikartlariList.IndexOf(secilennesne));
                Nesne rakipnesne = Program.rakipkartlariList[Program.random.Next(Program.rakipkartlariList.Count)];



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
                        if (rakipnesne.nesneadi.Equals("Tas"))
                        {
                            int rakipnesneindex = Program.rakipkartlariList.IndexOf(rakipnesne);
                            Program.rakipkartlariList[rakipnesneindex] = new AgirTasClass();
                            Program.rakipkartlariList[rakipnesneindex].dayaniklilik = rakipnesne.dayaniklilik;
                            Program.rakipkartlariList[rakipnesneindex].seviyePuani = rakipnesne.seviyePuani;
                            rakipnesne = Program.rakipkartlariList[rakipnesneindex];
                        }
                        if (rakipnesne.nesneadi.Equals("Kagit"))
                        {
                            int rakipnesneindex = Program.rakipkartlariList.IndexOf(rakipnesne);
                            Program.rakipkartlariList[rakipnesneindex] = new OzelKagitClass();
                            Program.rakipkartlariList[rakipnesneindex].dayaniklilik = rakipnesne.dayaniklilik;
                            Program.rakipkartlariList[rakipnesneindex].seviyePuani = rakipnesne.seviyePuani;
                            rakipnesne = Program.rakipkartlariList[rakipnesneindex];
                        }
                        if (rakipnesne.nesneadi.Equals("Makas"))
                        {
                            int rakipnesneindex = Program.rakipkartlariList.IndexOf(rakipnesne);
                            Program.rakipkartlariList[rakipnesneindex] = new UstaMakasClass();
                            Program.rakipkartlariList[rakipnesneindex].dayaniklilik = rakipnesne.dayaniklilik;
                            Program.rakipkartlariList[rakipnesneindex].seviyePuani = rakipnesne.seviyePuani;
                            rakipnesne = Program.rakipkartlariList[rakipnesneindex];
                        }

                    }
                }
                if (rakipnesne.dayaniklilik <= 0.0) // seçilen nesne , rakip nesneyi öldürürse
                {
                    secilennesne.seviyePuani = secilennesne.seviyePuani + 20;
                    if (secilennesne.seviyePuani > 30)
                    {
                        //Kart evrim geçirtme
                        if (secilennesne.nesneadi.Equals("Tas"))
                        {
                            int secilennesneindex = Program.kullanicikartlariList.IndexOf(secilennesne);
                            Program.kullanicikartlariList[secilennesneindex] = new AgirTasClass();
                            Program.kullanicikartlariList[secilennesneindex].dayaniklilik = secilennesne.dayaniklilik;
                            Program.kullanicikartlariList[secilennesneindex].seviyePuani = secilennesne.seviyePuani;
                            secilennesne = Program.kullanicikartlariList[secilennesneindex];
                            if (secilennesneindex == 0)
                            {
                                NesneBox1.Image = kartImageList.Images[3];
                            }
                            else if (secilennesneindex == 1)
                            {
                                NesneBox2.Image = kartImageList.Images[3];
                            }
                            else if (secilennesneindex == 2)
                            {
                                NesneBox3.Image = kartImageList.Images[3];
                            }
                            else if (secilennesneindex == 3)
                            {
                                NesneBox4.Image = kartImageList.Images[3];
                            }
                            else if (secilennesneindex == 4)
                            {
                                NesneBox5.Image = kartImageList.Images[3];
                            }
                        }
                        if (secilennesne.nesneadi.Equals("Kagit"))
                        {
                            int secilennesneindex = Program.kullanicikartlariList.IndexOf(secilennesne);
                            Program.kullanicikartlariList[secilennesneindex] = new OzelKagitClass();
                            Program.kullanicikartlariList[secilennesneindex].dayaniklilik = secilennesne.dayaniklilik;
                            Program.kullanicikartlariList[secilennesneindex].seviyePuani = secilennesne.seviyePuani;
                            secilennesne = Program.kullanicikartlariList[secilennesneindex];
                            if (secilennesneindex == 0)
                            {
                                NesneBox1.Image = kartImageList.Images[4];
                            }
                            else if (secilennesneindex == 1)
                            {
                                NesneBox2.Image = kartImageList.Images[4];
                            }
                            else if (secilennesneindex == 2)
                            {
                                NesneBox3.Image = kartImageList.Images[4];
                            }
                            else if (secilennesneindex == 3)
                            {
                                NesneBox4.Image = kartImageList.Images[4];
                            }
                            else if (secilennesneindex == 4)
                            {
                                NesneBox5.Image = kartImageList.Images[4];
                            }
                        }
                        if (secilennesne.nesneadi.Equals("Makas"))
                        {
                            int secilennesneindex = Program.kullanicikartlariList.IndexOf(secilennesne);
                            Program.kullanicikartlariList[secilennesneindex] = new UstaMakasClass();
                            Program.kullanicikartlariList[secilennesneindex].dayaniklilik = secilennesne.dayaniklilik;
                            Program.kullanicikartlariList[secilennesneindex].seviyePuani = secilennesne.seviyePuani;
                            secilennesne = Program.kullanicikartlariList[secilennesneindex];
                            if (secilennesneindex == 0)
                            {
                                NesneBox1.Image = kartImageList.Images[5];
                            }
                            else if (secilennesneindex == 1)
                            {
                                NesneBox2.Image = kartImageList.Images[5];
                            }
                            else if (secilennesneindex == 2)
                            {
                                NesneBox3.Image = kartImageList.Images[5];
                            }
                            else if (secilennesneindex == 3)
                            {
                                NesneBox4.Image = kartImageList.Images[5];
                            }
                            else if (secilennesneindex == 4)
                            {
                                NesneBox5.Image = kartImageList.Images[5];
                            }
                        }
                    }
                    Program.rakipkartlariList.Remove(rakipnesne);
                    RakipBox.Image = kartImageList.Images[6];
                }

                /*----- RAKİPBOX FOTOĞRAF YERLEŞTİRME -----*/
                if (rakipnesne.dayaniklilik > 0.0)
                {
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
                }
                else
                {
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
                tursayisilabel.Text = "Tur Sayısı = " + tursayisi + "/50";
                secilinesnenumlabel.Text = "Kart No = " + (Program.rakipkartlariList.IndexOf(rakipnesne) + 1) + "/" + Program.rakipkartlariList.Count;
                double rakiptoplamdayaniklilik = 0;
                for (int i = 0; i < Program.rakipkartlariList.Count; i++)
                {
                    rakiptoplamdayaniklilik = rakiptoplamdayaniklilik + Program.rakipkartlariList[i].dayaniklilik;
                }
                double kullanicitoplamdayaniklilik = 0;
                for (int i = 0; i < Program.kullanicikartlariList.Count; i++)
                {
                    kullanicitoplamdayaniklilik = kullanicitoplamdayaniklilik + Program.kullanicikartlariList[i].dayaniklilik;
                }
                if (Program.rakipkartlariList.Count <= 0 && kullanicitoplamdayaniklilik <= 0)
                {
                    Console.WriteLine("OYUN BİTTİ ---> Berabere");
                    sonuclabel.Text = "Berabere";
                    hamleyapPictureBox.Visible = false;
                }
                else if (Program.rakipkartlariList.Count <= 0)
                {
                    Console.WriteLine("OYUN BİTTİ ---> Kullanici kazandi");
                    sonuclabel.Text = "Kullanıcı Kazandı";
                    hamleyapPictureBox.Visible = false;
                }
                else if (kullanicitoplamdayaniklilik <= 0)
                {
                    Console.WriteLine("OYUN BİTTİ ---> Rakip kazandi");
                    sonuclabel.Text = "Bilgisayar Kazandı";
                    hamleyapPictureBox.Visible = false;
                }
                else if (tursayisi >= 50)
                {
                    if (kullanicitoplamdayaniklilik > rakiptoplamdayaniklilik)
                    {
                        Console.WriteLine("OYUN BİTTİ ---> Kullanici kazandi");
                        Console.WriteLine("Kullanıcı = " + kullanicitoplamdayaniklilik + "\n Bilgisayar = " + rakiptoplamdayaniklilik);
                        sonuclabel.Text = "Kullanıcı Kazandı";
                    }
                    else if (rakiptoplamdayaniklilik > kullanicitoplamdayaniklilik)
                    {
                        Console.WriteLine("OYUN BİTTİ ---> Rakip kazandi");
                        Console.WriteLine("Kullanıcı = " + kullanicitoplamdayaniklilik + "\n Bilgisayar = " + rakiptoplamdayaniklilik);
                        sonuclabel.Text = "Bilgisayar Kazandı";
                    }
                    else if (rakiptoplamdayaniklilik == kullanicitoplamdayaniklilik)
                    {
                        Console.WriteLine("OYUN BİTTİ ---> Berabere");
                        Console.WriteLine("Kullanıcı = " + kullanicitoplamdayaniklilik + "\n Bilgisayar = " + rakiptoplamdayaniklilik);
                        sonuclabel.Text = "Berabere";
                    }
                    hamleyapPictureBox.Visible = false;
                }
            }

        }

        private void sonuclabel_Click(object sender, EventArgs e)
        {
            //programı kapat
        }

        private void rakipseviyepuanilabel_Click(object sender, EventArgs e)
        {

        }

        private void rakipdayanikliliklabel_Click(object sender, EventArgs e)
        {

        }

        private void secilinesnenumlabel_Click(object sender, EventArgs e)
        {

        }

        private void dayanikliliklabel3_Click(object sender, EventArgs e)
        {

        }

        private void seviyepuanilabel3_Click(object sender, EventArgs e)
        {
        }
    }
}
