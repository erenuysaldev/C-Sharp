namespace Degiskenler_4_islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpim, fark, bolum;
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);
            toplam = sayi1 + sayi2;
            carpim = sayi1 * sayi2; 
            bolum  = sayi1 / sayi2;
            fark   = sayi1 - sayi2;
            MessageBox.Show("Toplam:  " + toplam + "\n" + "Fark:  " + fark +"\n"+ "�arp�m: "+carpim+"\n"+"B�l�m: " +bolum); 
        }
    }
}
