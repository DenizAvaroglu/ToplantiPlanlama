using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToplantiPlanlama.Class;

namespace ToplantiPlanlama
{
    public partial class Form1 : Form
    {
        Giris grs = new Giris();


        public Form1()
        {

            InitializeComponent();
            Giris grs = new Giris();


        }

        public void button2_Click(object sender, EventArgs e)
        {
            string dosyakonum = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\Kayit.txt";
           
            


                string Ad = textBox3.Text;
                string Soyad = textBox4.Text;
                string Kullaniciadi = textBox5.Text;
                string Sifre = textBox6.Text;
          

            File.WriteAllText(dosyakonum, Ad + "\n" + Soyad + "\n" + Kullaniciadi + "\n" + Sifre+"\n");
           

            //  grs.setAd(Ad);
            // grs.setSoyad(Soyad);
            // grs.setKullaniciAdi(Kullaniciadi);
            // grs.setSifre(Sifre);


            MessageBox.Show("Kaydınız Yapılmıştır");
            
        }

        

        public void button1_Click(object sender, EventArgs e)
        {

            string dosyakonum = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\Kayit.txt";
            string[] data_= File.ReadAllLines(dosyakonum);
            

           string kullaniciadi=textBox1.Text;
            string sifre = textBox2.Text;

           
            for(int i=2; i<data_.Length;i+=4)
            {
                if (data_[i] ==kullaniciadi && data_[i+1] ==sifre)
                {

                    Toplanti toplanti = new Toplanti();
                     toplanti.Show();




                }






            }


           







            // string KADI = grs.GetKullaniciAdi();
            //string SFRE = grs.GetSifre();


            //if(KADI==textBox1.Text && SFRE == textBox2.Text)
            //{
            // Toplanti toplanti = new Toplanti();
            // toplanti.Show();


            // }


            // else
            // {
            // MessageBox.Show("Hatalı Giriş Tekrar Deneyiniz");


            // }






        }

        public void tabPage2_Click(object sender, EventArgs e)
        {
            tabPage1 = new TabPage();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
