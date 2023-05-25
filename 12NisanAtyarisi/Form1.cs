using System.Media;

namespace _12NisanAtyarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        SoundPlayer sound = new SoundPlayer("Resources\\ses.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            at1.Left += rnd.Next(1, 10);
            at2.Left += rnd.Next(1, 10);
            at3.Left += rnd.Next(1, 10);

            // en öndeki atýn bulunmasý
            PictureBox ondeki = at1;
            if (at2.Left > ondeki.Left)
                ondeki = at2;
            if (at3.Left > ondeki.Left)
                ondeki = at3;
            //ondeki atýn numarasý
            string no = (string)ondeki.Tag;

            //yarýþ bitti mi?
            if (ondeki.Right > pnlBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show($"Yarýþ Bitti. {no} nolu at yarýþý kazandý");
                btnBaslat.Text = "YENÝ YARIÞ";
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (btnBaslat.Text == "YARIÞI BAÞLAT" && !timer1.Enabled)
            {
                timer1.Start();
                sound.Play();

            }
            else if (btnBaslat.Text == "YENÝ YARIÞ")
            {
                at1.Left = at2.Left = at3.Left = 0;
                btnBaslat.Text = "YARIÞI BAÞLAT";
            }

        }
    }
}