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
            kullaniciForm form2 = new kullaniciForm();
            form2.Visible = true;
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kullaniciForm form2 = new kullaniciForm();
            form2.Visible = true;
            this.Visible = false;
        }
    }
}