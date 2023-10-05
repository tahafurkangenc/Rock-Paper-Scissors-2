using Microsoft.VisualBasic;

namespace TasKagitMakas
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            if (Program.kullanicikartlariList.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    int randomsayi = Program.random.Next(3);
                    if (randomsayi == 0)// TAŞ 
                    {
                        Program.kullanicikartlariList.Add(new TasClass());
                    }
                    else if (randomsayi == 1) //KAĞIT
                    {
                        Program.kullanicikartlariList.Add(new KagitClass());
                    }
                    else if (randomsayi == 2) //MAKAS
                    {
                        Program.kullanicikartlariList.Add(new MakasClass());
                    }

                }
                if (Program.kullanicikartlariList.Count == 5)
                {
                    Console.WriteLine("Kullanici Bilgisayar Rastgele Seçimleri");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(Program.kullanicikartlariList[i].ToString() + "\n------------------\n");

                    }
                }
                else
                {
                    Console.WriteLine("HATA : kullanicikartlariList boyutu 5 değil.\n Program.kullanicikartlariList.Count =" + Program.kullanicikartlariList.Count);
                }

            }
            else
            {
                Console.WriteLine("HATA : kullanicikartlariList boyutu 0 değil.\n Program.kullanicikartlariList.Count =" + Program.kullanicikartlariList.Count);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kullaniciForm form2 = new kullaniciForm();
            form2.Visible = true;
            this.Visible = false;

        }
    }
}