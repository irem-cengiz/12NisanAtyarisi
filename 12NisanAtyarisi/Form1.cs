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

            // en �ndeki at�n bulunmas�
            PictureBox ondeki = at1;
            if (at2.Left > ondeki.Left)
                ondeki = at2;
            if (at3.Left > ondeki.Left)
                ondeki = at3;
            //ondeki at�n numaras�
            string no = (string)ondeki.Tag;

            //yar�� bitti mi?
            if (ondeki.Right > pnlBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show($"Yar�� Bitti. {no} nolu at yar��� kazand�");
                btnBaslat.Text = "YEN� YARI�";
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (btnBaslat.Text == "YARI�I BA�LAT" && !timer1.Enabled)
            {
                timer1.Start();
                sound.Play();

            }
            else if (btnBaslat.Text == "YEN� YARI�")
            {
                at1.Left = at2.Left = at3.Left = 0;
                btnBaslat.Text = "YARI�I BA�LAT";
            }

        }
    }
}