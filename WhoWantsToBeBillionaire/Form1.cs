using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeBillionaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun Bilgilendiricisine Hoşgeldin !");
            MessageBox.Show("Bir Soru Cevap Oyunu'dur.");
            MessageBox.Show("Doğru Cevap Yaptıkça Para Kazanırsın Fakat");
            MessageBox.Show("Eğer 1 Tane Yanlış Yaparsan Kaybedersin Ve Bütün Kazandığın Paranı Kaybedersin.");
            MessageBox.Show("3 Joker Hakkı Vardır. Bunlar ; ");
            MessageBox.Show("1.si Telefon Hakkı -> Nilay Hocaya Bu Soruyu Sorabilirsin.");
            MessageBox.Show("2.si Seyirci Hakkı -> Sınıfa Olduğu Soruyu Sorabilirsin.");
            MessageBox.Show("3.sü %50 Hakkı -> 2 Tane Şık Elenir.");
            MessageBox.Show("İyi Şanslar :)");
        }
    }
}
