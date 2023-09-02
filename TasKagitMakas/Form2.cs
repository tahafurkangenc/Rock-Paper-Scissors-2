using System;
using System.Collections;
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
    public partial class kullaniciForm : Form
    {
        int kackartsecildi = 0;

        public kullaniciForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void pictureBoxTas_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click Command --> Tas Button");
            if (Program.kullanicikartlariList.Count < 5)
            {
                Program.kullanicikartlariList.Add(new KagitClass());
                label3.Text = "Seçilen karakter sayısı = " + Program.kullanicikartlariList.Count;
                if (Program.kullanicikartlariList.Count == 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(Program.kullanicikartlariList[i].ToString() + "\n------------------\n");

                    }
                }
            }

        }

        private void pictureBoxKagit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click Command --> Kagit Button");
            if (Program.kullanicikartlariList.Count < 5)
            {
                Program.kullanicikartlariList.Add(new KagitClass());
                label3.Text = "Seçilen karakter sayısı = " + Program.kullanicikartlariList.Count;
                if (Program.kullanicikartlariList.Count == 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(Program.kullanicikartlariList[i].ToString() + "\n------------------\n");

                    }
                }
            }
        }

        private void pictureBoxMakas_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click Command --> Makas Button");
            if (Program.kullanicikartlariList.Count < 5)
            {
                Program.kullanicikartlariList.Add(new KagitClass());
                label3.Text = "Seçilen karakter sayısı = " + Program.kullanicikartlariList.Count;
                if (Program.kullanicikartlariList.Count == 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(Program.kullanicikartlariList[i].ToString() + "\n------------------\n");

                    }
                }
            }
        }
    }
}
