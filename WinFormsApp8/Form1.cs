namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label4.Text = sonuc.ToString();
            MessageBox.Show("Toplama iþlemi sonucu: " + label4.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label4.Text = sonuc.ToString();
            MessageBox.Show("Çýkarma Ýþlemi Sonucu: " + label4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 / sayi2;
            label4.Text = sonuc.ToString();
            MessageBox.Show("Bölme iþlemi sonucu: " + label4.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label4.Text = sonuc.ToString();
            MessageBox.Show("Çarpma iþlemi sonucu: " + label4.Text);
        }
    }
}