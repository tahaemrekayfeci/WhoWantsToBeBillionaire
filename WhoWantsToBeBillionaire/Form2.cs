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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Random Atadım
        Random rastgele = new Random();
        // Değişkenler
        int randomatma , tel=1 , yariyariya=1,seyirci=1;
        // Dizi
        // Bir Sürü Form Açmak Yerine Diziye Atadım
        int[] sayilar = new int[11];
        
        private void Form2_Load(object sender, EventArgs e)
        {
            //Picture Boxlara Resim Ekledim
            pictureBox1.Image = Image.FromFile("KimMilyonerOlmakIsterTelefon.png");
            pictureBox2.Image = Image.FromFile("KimMilyonerOlmakIsterSeyirciHakki.png");
            pictureBox3.Image = Image.FromFile("KimMilyonerOlmakIsterYariSans.png");
            // Picture Boxların Boyutlarını Ayarladım
            pictureBox1.Size = new System.Drawing.Size(65, 45);
            pictureBox2.Size = new System.Drawing.Size(65, 45);
            pictureBox3.Size = new System.Drawing.Size(68, 45);
            // Picture Boxların Yerlerini Ayarladım
            pictureBox1.Location = new System.Drawing.Point(10, 10);
            pictureBox2.Location = new System.Drawing.Point(100, 10);
            pictureBox3.Location = new System.Drawing.Point(190, 10);
            // Random Atadım (1. Soru Veya 2. Soruyu Sorsun Diye)
            randomatma = rastgele.Next(1, 3);
            // Labelların Arka Plan Renklerini Ayarladım
            lbl_soru.BackColor = Color.MidnightBlue;
            lbl_soru_a.BackColor = Color.MidnightBlue;
            lbl_soru_b.BackColor = Color.MidnightBlue;
            lbl_soru_c.BackColor = Color.MidnightBlue;
            lbl_soru_d.BackColor = Color.MidnightBlue;
            // Labelların Yazı Renklerini Ayarladım
            lbl_soru.ForeColor = Color.White;
            lbl_soru_a.ForeColor = Color.White;
            lbl_soru_b.ForeColor = Color.White;
            lbl_soru_c.ForeColor = Color.White;
            lbl_soru_d.ForeColor = Color.White;
            // 1. Ve 2. Soruyu Ayarladım ( Rastgele )
            // Ve Sorularını Sordum
            if (randomatma == 1)
            {
                lbl_soru.Text = "Klasik bir çengel bulmacada, bir kutucukta en fazla kaç farklı soru sorulur?";
                lbl_soru_a.Text = "a) 1";
                lbl_soru_b.Text = "b) 2";
                lbl_soru_c.Text = "c) 3";
                lbl_soru_d.Text = "d) 4";
            }
            else if (randomatma == 2)
            {
                lbl_soru.Text = "İnce yapılı ve güçlü kişileri tanımlamak için hangi ifade kullanılır ? ";
                lbl_soru_a.Text = "a) Sicim gibi";
                lbl_soru_b.Text = "b) Sırım gibi";
                lbl_soru_c.Text = "c) Sırma gibi";
                lbl_soru_d.Text = "d) Sırça gibi";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // A Şıkkı
            // 1. Soru
            if (sayilar[0]==0)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if  (randomatma == 2)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 3. Soruyu Soruyor 
                    lbl_soru.Text = "Biri tanıtılırken hangisi söylenirse 'bu kişi benim gelecekte evleneceğim kişi' denmiş olur?";
                    lbl_soru_a.Text = "a) Müstakbel eşim";
                    lbl_soru_b.Text = "b) Müstakil evim";
                    lbl_soru_c.Text = "c) Müteşebbis ortağım";
                    lbl_soru_d.Text = "d) Mükellef sofram";
                }

            }
            // 2. Soru
            else if (sayilar[0]==1)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 3. Soru
            else if (sayilar[0]==2)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 4. Soruyu Soruyor
                    lbl_soru.Text = "'Bundan sonra herhangi bir sıkıntıyla karşılaşma ihtimali yok' anlamındaki atasözü hangisidir?";
                    lbl_soru_a.Text = "a) Okyanusta ölüm yok";
                    lbl_soru_b.Text = "b) Karada ölüm yok";
                    lbl_soru_c.Text = "c) Magmada ölüm yok";
                    lbl_soru_d.Text = "d) Stratosferde ölüm yok";
                    // Cevap B
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 4. Soru
            else if (sayilar[0]==3)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 5. Soruyu Soruyor
                    lbl_soru.Text = "Siparişinizi getiren kurye, 'Temassız alabilir miyim ? ' diye bir soru soruyorsa, ödemenizi muhtemelen hangisini kullanarak yapıyorsunuzdur?";
                    lbl_soru_a.Text = "a) Madeni para";
                    lbl_soru_b.Text = "b) Kağıt para";
                    lbl_soru_c.Text = "c) Çek";
                    lbl_soru_d.Text = "d) Kredi kartı";
                    // Cevap  D
                }
            }
            // 5. Soru
            else if (sayilar[0]==4)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 6. Soru
            else if (sayilar[0]==5)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 7. Soruyu Soruyor
                    lbl_soru.Text = "Kuruluşların internet sitelerinde, sosyal medya hesaplarının paylaşıldığı sayfanın başlığı genellikle hangisi olur?";
                    lbl_soru_a.Text = "a) Bizi idare edin";
                    lbl_soru_b.Text = "b) Bizi merak edin";
                    lbl_soru_c.Text = "c) Bizi ihbar edin";
                    lbl_soru_d.Text = "d) Bizi takip edin";
                    // Cevap D
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 7. Soru
            else if (sayilar[0]==6)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 8. Soru
            else if (sayilar[0] == 7)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 9. Soru
            else if (sayilar[0] == 8)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 10. Soru
            else if (sayilar[0] == 9)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    // Bitiş
                    MessageBox.Show("1 Milyon Lira Kazandınız TEBRİKLER!");
                    sayilar[0]++;
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            lbl_soru_a.Show();
            lbl_soru_b.Show();
            lbl_soru_c.Show();
            lbl_soru_d.Show();
            // A Şıkkı
        }

        private void lbl_soru_b_Click(object sender, EventArgs e)
        {
            // B Şıkkı
            // 1. Soru
            if (sayilar[0] == 0)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 2. Soruyu Soruyor
                    lbl_soru.Text = "Bilim insanları hangisine çıplak gözle direkt bakmamızı tavsiye ederler?";
                    lbl_soru_a.Text = "a) Motosiklet sürücülerine";
                    lbl_soru_b.Text = "b) Mağaza indirim yazılarına";
                    lbl_soru_c.Text = "c) Trafik ışıklarına";
                    lbl_soru_d.Text = "d) Güneşe";
                }
                else if (randomatma == 2)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 2. Soruyu Soruyor
                    lbl_soru.Text = "Elektronik cihazların ekranlarının ayar menüsünde karşılaşılan, Türkçeye Fransızcadan geçen ve 'karşıtlık' anlamına gelen kelime hangisidir?";
                    lbl_soru_a.Text = "a) Kontrast";
                    lbl_soru_b.Text = "b) Ton";
                    lbl_soru_c.Text = "c) Diyafram";
                    lbl_soru_d.Text = "d) Enstantene";
                }
            }
            // 2. Soru
            else if (sayilar[0] == 1)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 3. Soru
            else if (sayilar[0]==2)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 4. Soru
            else if (sayilar[0]==3)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 5. Soruyu Soruyor
                    lbl_soru.Text = "Kapuska, mücver ve karnıyarık yapmak için, pazardan ana malzeme olarak sırasıyla hangi üçünü almak gerekir?";
                    lbl_soru_a.Text = "a) Domates, biber, salatalık";
                    lbl_soru_b.Text = "b) Marul, pırasa, ıspanak";
                    lbl_soru_c.Text = "c) Lahana, kabak, ıspanak";
                    lbl_soru_d.Text = "d) Patates, soğan, pancar";
                    // Cevap C
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 5. Soru
            else if (sayilar[0]==4)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 6. Soru
            else if (sayilar[0]==5)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 7. Soru
            else if (sayilar[0] == 6)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 8. Soru
            else if (sayilar[0] == 7)
            {
                if (sayilar[0] == 0)
                {
                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        // Yeni Soru Hazırlıyor
                        MessageBox.Show("Doğru Cevap!");
                        sayilar[0]++;
                        // 9. Soruyu Soruyor
                        lbl_soru.Text = "'Dal sarkar kartal kalkar' şeklinde biten tekerlemenin başı nasıldır?";
                        lbl_soru_a.Text = "a) Kartal uçar dal sarkar";
                        lbl_soru_b.Text = "b) Kartal kalkar dal düşer";
                        lbl_soru_c.Text = "c) Kartal kalkar dal sarkar";
                        lbl_soru_d.Text = "d) Kartal uçar dal düşer";
                        // Cevap C
                    }
                    else if (randomatma == 2)
                    {
                        // Yeni Soru Hazırlıyor
                        MessageBox.Show("Doğru Cevap!");
                        sayilar[0]++;
                        // 9. Soruyu Soruyor
                        lbl_soru.Text = "Bir dönem Galatasaray Spor Kulübü'ne koruyucu başkanlık eden ve 'Servet - i Fünun' edebiyat akımının da öncülerinden olan şair kimdir?";
                        lbl_soru_a.Text = "a) Hüseyin Cahit Yalçın";
                        lbl_soru_b.Text = "b) Cenap Şahabettin";
                        lbl_soru_c.Text = "c) Tevfik Fikret";
                        lbl_soru_d.Text = "d) Mehmet Rauf";
                        // Cevap C
                    }
                }
            }
            // 9. Soru
            else if (sayilar[0] == 8)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 10. Soru
            else if (sayilar[0] == 8)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    // Bitiş
                    MessageBox.Show("1 Milyon Lira Kazandınız TEBRİKLER!");
                    sayilar[0]++;
                }
            }
            lbl_soru_a.Show();
            lbl_soru_b.Show();
            lbl_soru_c.Show();
            lbl_soru_d.Show();
            // B Şıkkı
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (seyirci==1)
            {
                MessageBox.Show("Sınıfa Sorabilirsiniz.");
                seyirci--;
            }
            else
            {
                MessageBox.Show("Seyirci Hakkınız Bitmiştir");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (yariyariya==1)
            {
                // 1. Soru
                if (sayilar[0] == 0)
                {

                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        lbl_soru_a.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }
                    else if (randomatma == 2)
                    {
                        lbl_soru_a.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }

                }
                // 2. Soru
                else if (sayilar[0] == 1)
                {
                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        lbl_soru_a.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }
                    else if (randomatma == 2)
                    {
                        lbl_soru_b.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }

                }
                // 3. Soru
                else if (sayilar[0] == 2)
                {
                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        lbl_soru_b.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }
                    else if (randomatma == 2)
                    {
                        lbl_soru_a.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }

                }
                // 4. Soru
                else if (sayilar[0] == 3)
                {
                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        lbl_soru_b.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }
                    else if (randomatma == 2)
                    {
                        lbl_soru_a.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }

                }
                // 5. Soru
                else if (sayilar[0] == 4)
                {
                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        lbl_soru_d.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }
                    else if (randomatma == 2)
                    {
                        lbl_soru_b.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }

                }
                // 6. Soru
                else if (sayilar[0] == 4)
                {
                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        lbl_soru_d.Hide();
                        lbl_soru_a.Hide();
                        yariyariya--;
                    }
                    else if (randomatma == 2)
                    {
                        lbl_soru_b.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }

                }
                // 7. Soru
                else if (sayilar[0] == 4)
                {
                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        lbl_soru_d.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }
                    else if (randomatma == 2)
                    {
                        lbl_soru_b.Hide();
                        lbl_soru_a.Hide();
                        yariyariya--;
                    }

                }
                // 8. Soru
                else if (sayilar[0] == 4)
                {
                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        lbl_soru_a.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }
                    else if (randomatma == 2)
                    {
                        lbl_soru_b.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }

                }
                // 9. Soru
                else if (sayilar[0] == 4)
                {
                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        lbl_soru_d.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }
                    else if (randomatma == 2)
                    {
                        lbl_soru_d.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }

                }
                // 10. Soru
                else if (sayilar[0] == 4)
                {
                    // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                    if (randomatma == 1)
                    {
                        lbl_soru_d.Hide();
                        lbl_soru_a.Hide();
                        yariyariya--;
                    }
                    else if (randomatma == 2)
                    {
                        lbl_soru_d.Hide();
                        lbl_soru_c.Hide();
                        yariyariya--;
                    }

                }
               
            }
            else
            {
                MessageBox.Show("Yarı Yarıya Hakkınızı Bitirmişsiniz");
            }
            
        }

        private void lbl_soru_c_Click(object sender, EventArgs e)
        {
            // C Şıkkı
            // 1. Soru
            if (sayilar[0] == 0)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }

            }
            // 2. Soru
            else if (sayilar[0]==1)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 3. Soru
            else if (sayilar[0]==2)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 4. Soru
            else if (sayilar[0]==3)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 5. Soru
            else if (sayilar[0] == 4)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 6. Soru
            else if (sayilar[0] == 5)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 7. Soruyu Soruyor (!!! DÜZELT !!!) 
                    lbl_soru.Text = "Hangisi 'gelecekteki' anlamına gelir?";
                    lbl_soru_a.Text = "a) Mukabil";
                    lbl_soru_b.Text = "b) Muntazam";
                    lbl_soru_c.Text = "c) Müstakil";
                    lbl_soru_d.Text = "d) Müstakbel";
                    // D
                }
            }
            // 7. Soru
            else if (sayilar[0] == 6)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 8. Soru
            else if (sayilar[0] == 7)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 9. Soru
            else if (sayilar[0] == 8)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 10. Soruyu Soruyor (!!! DÜZELT !!!) 
                    lbl_soru.Text = "999.999.999.999.999'a 1 eklersek hangi sayıya ulaşırız?";
                    lbl_soru_a.Text = "a) 1 trilyar";
                    lbl_soru_b.Text = "b) 1 katrilyon";
                    lbl_soru_c.Text = "c) 1 sentilyon";
                    lbl_soru_d.Text = "d) 1 oktilyon";
                    // B
                }
            }
            // 10. Soru
            if (sayilar[0] == 9)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }

            }
            lbl_soru_a.Show();
            lbl_soru_b.Show();
            lbl_soru_c.Show();
            lbl_soru_d.Show();
            // C Şıkkı
        }

        private void lbl_soru_d_Click(object sender, EventArgs e)
        {
            // D Şıkkı
            // 1. Soru
            if (sayilar[0] == 0)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                // 2. Soru
            }
            else if (sayilar[0] == 1)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 3. Soruyu Soruyor (!!! DÜZELT !!!) 
                    lbl_soru.Text = "'Tatar yayı' olarak da bilinen ve Orta Çağ'da yaygın olarak kullanılan uzak mesafe silahı hangisidir?";
                    lbl_soru_a.Text = "a) Topuz";
                    lbl_soru_b.Text = "b) Kama";
                    lbl_soru_c.Text = "c) Tüfek";
                    lbl_soru_d.Text = "d) Arbalet";
                    // D
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 3. Soru
            else if (sayilar[0] == 2)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 3. Soruyu Soruyor 
                    lbl_soru.Text = " 'Kanka, sence bana bakar mı?' diye sorup arkadaşının fikrini almak isteyen biri, muhtemelen hangisinden bahsediyordur?";
                    lbl_soru_a.Text = "a) Hoşlandığı kişiden";
                    lbl_soru_b.Text = "b) Sahipleneceği kediden";
                    lbl_soru_c.Text = "c) Güvenlik kamerasından";
                    lbl_soru_d.Text = "d) Yağlı boya potreden";
                    // Cevap A
                }
            }
            // 4. Soru
            else if (sayilar[0] == 3)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 5. Soru
            else if (sayilar[0] == 4)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 6. Soruyu Soruyor (!!! DÜZELT !!!) 
                    lbl_soru.Text = " Hangi börek, adını malzemelerin içine konduğu hamurun şeklinden almaz?";
                    lbl_soru_a.Text = "a) Gül böreği";
                    lbl_soru_b.Text = "b) Muska böreği";
                    lbl_soru_c.Text = "c) Su böreği";
                    lbl_soru_d.Text = "d) Bohça böreği";
                    // Cevap C
                }
            }
            // 6. Soru
            else if (sayilar[0] == 5)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 7. Soru
            else if (sayilar[0] == 6)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 8. Soruyu Soruyor (!!! DÜZELT !!!) 
                    lbl_soru.Text = "Kötü hazırlanmış, tadı tuzu olmayan sulu yiyecek ve içeçekler için yapılan benzetme hangisidir?";
                    lbl_soru_a.Text = "a) Vişne suyu gibi";
                    lbl_soru_b.Text = "b) Bulaşık suyu gibi";
                    lbl_soru_c.Text = "c) Kibrit suyu gibi";
                    lbl_soru_d.Text = "d) Kar suyu gibi";
                    // B
                }
                else if (randomatma == 2)
                {
                    // Yeni Soru Hazırlıyor
                    MessageBox.Show("Doğru Cevap!");
                    sayilar[0]++;
                    // 8. Soruyu Soruyor (!!! DÜZELT !!!) 
                    lbl_soru.Text = "Hangisi, Güney Amerika tatiline çıktığınızda görebileceğiniz sıradağlardır?";
                    lbl_soru_a.Text = "a) Kilimanjaro";
                    lbl_soru_b.Text = "b) And";
                    lbl_soru_c.Text = "c) Mauna Kea";
                    lbl_soru_d.Text = "d) Fuji";
                    // B
                }
            }
            // 8. Soru
            else if (sayilar[0] == 7)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 9. Soru
            else if (sayilar[0] == 8)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
            }
            // 10. Soru
            if (sayilar[0] == 9)
            {
                // Random Attığımız Sayıyı Kontrol Ediyor ve Cevabı
                if (randomatma == 1)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }
                else if (randomatma == 2)
                {
                    MessageBox.Show("Yanlış Cevap!");
                    this.Close();
                }

            }
            lbl_soru_a.Show();
            lbl_soru_b.Show();
            lbl_soru_c.Show();
            lbl_soru_d.Show();

            // D Şıkkı
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tel ==1)
            {
                MessageBox.Show("Nilay Hocaya Sorabilirsiniz");
                tel--;
            }
            else
            {
                MessageBox.Show("Telefon Hakkı Bitmiştir.");
            }
        }
    }
}
