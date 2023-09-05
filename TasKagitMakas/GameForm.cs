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


        private void NesneBox3_Click(object sender, EventArgs e)
        {
            SecilenBox.Image = NesneBox3.Image; 
        }
    }
}
