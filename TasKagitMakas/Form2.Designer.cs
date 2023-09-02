namespace TasKagitMakas
{
    partial class kullaniciForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciForm));
            label1 = new Label();
            pictureBoxKagit = new PictureBox();
            pictureBoxMakas = new PictureBox();
            pictureBoxTas = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKagit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMakas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(359, 449);
            label1.Name = "label1";
            label1.Size = new Size(142, 22);
            label1.TabIndex = 0;
            label1.Text = "MAIN MENU!";
            label1.Click += label1_Click;
            // 
            // pictureBoxKagit
            // 
            pictureBoxKagit.BackColor = Color.Transparent;
            pictureBoxKagit.BackgroundImage = Properties.Resources._1689333264804;
            pictureBoxKagit.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxKagit.Location = new Point(307, 12);
            pictureBoxKagit.Name = "pictureBoxKagit";
            pictureBoxKagit.Size = new Size(240, 240);
            pictureBoxKagit.TabIndex = 1;
            pictureBoxKagit.TabStop = false;
            pictureBoxKagit.Click += pictureBoxKagit_Click;
            // 
            // pictureBoxMakas
            // 
            pictureBoxMakas.BackColor = Color.Transparent;
            pictureBoxMakas.BackgroundImage = (Image)resources.GetObject("pictureBoxMakas.BackgroundImage");
            pictureBoxMakas.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxMakas.Location = new Point(553, 12);
            pictureBoxMakas.Name = "pictureBoxMakas";
            pictureBoxMakas.Size = new Size(240, 240);
            pictureBoxMakas.TabIndex = 2;
            pictureBoxMakas.TabStop = false;
            pictureBoxMakas.Click += pictureBoxMakas_Click;
            // 
            // pictureBoxTas
            // 
            pictureBoxTas.BackColor = Color.Transparent;
            pictureBoxTas.BackgroundImage = (Image)resources.GetObject("pictureBoxTas.BackgroundImage");
            pictureBoxTas.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxTas.Location = new Point(61, 12);
            pictureBoxTas.Name = "pictureBoxTas";
            pictureBoxTas.Size = new Size(240, 240);
            pictureBoxTas.TabIndex = 3;
            pictureBoxTas.TabStop = false;
            pictureBoxTas.Click += pictureBoxTas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gill Sans MT Ext Condensed Bold", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(72, 269);
            label2.Name = "label2";
            label2.Size = new Size(705, 59);
            label2.TabIndex = 4;
            label2.Text = "Oyun içerisinde kullanmak istediginiz 5 karakteri sırasıyla seçiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Gill Sans MT Ext Condensed Bold", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(269, 348);
            label3.Name = "label3";
            label3.Size = new Size(315, 59);
            label3.TabIndex = 5;
            label3.Text = "Seçilen karakter sayısı = 0";
            // 
            // kullaniciForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.coin__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(854, 480);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBoxTas);
            Controls.Add(pictureBoxMakas);
            Controls.Add(pictureBoxKagit);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "kullaniciForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxKagit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMakas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBoxKagit;
        private PictureBox pictureBoxMakas;
        private PictureBox pictureBoxTas;
        private Label label2;
        private Label label3;
    }
}