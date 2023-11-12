
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Helpers;
//using Google;
//using Google.Apis.Auth.OAuth2;
//using Google.Apis.Calendar.v3;
//using Google.Apis.Services;
//using Google.Apis.Calendar.v3.Data;
//using Google.Apis.Util.Store;
//using Google.Apis.Http;

namespace ToplantiPlanlama


{
    public partial class Toplanti : Form
    {
       /* public IConfigurableHttpClientInitializer credential { get;  set; }
        public CalendarService calendarService { get;  set; }
       */
        public Toplanti()
        {
            InitializeComponent();

        }
        private void btnAddToGoogleCalendar_Click(object sender, EventArgs e)
        {
            // Bu düğmeye tıklandığında yapılacak işlemleri burada kodlayabilirsiniz.
            // Örneğin Google Takvim API'si ile ilgili işlemleri burada gerçekleştirebilirsiniz.
        }
        public void Toplanti_Load(object sender, EventArgs e)
        {

           /* // Google API kimlik doğrulama
            string[] scopes = { CalendarService.Scope.Calendar };
            string clientId = "327674132128";
            string clientSecret = "solid-setup-403709";

            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets { ClientId = clientId, ClientSecret = clientSecret },
                scopes,
                "Akefalos",
                CancellationToken.None,
                new FileDataStore("Calendar.API.Store")).Result;

            // Google Takvim API hizmetini başlat
            calendarService = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Toplanti",
            });*/
        
        }
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string KONU = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string KISISAYISI = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string KURUCU = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string TARIH = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string SAAT = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string DONUT = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            textBox1.Text = ID;
            textBox2.Text = KONU;
            textBox3.Text = KISISAYISI;
            textBox4.Text = KURUCU;
            dateTimePicker1.Text = TARIH;
            maskedTextBox1.Text = SAAT;
            richTextBox1.Text = DONUT;

        }

        public void button1_Click(object sender, EventArgs e)
        {
            // string dosyakonum2 = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\ToplantiListesi.txt";
            string ID = textBox1.Text;
            string KONU = textBox2.Text;
            string KISISAYISI = textBox3.Text;
            string KURUCU = textBox4.Text;
            string TARIH = dateTimePicker1.Text;
            string SAAT = maskedTextBox1.Text;
            string DONUT = richTextBox1.Text;
            // File.AppendAllText(dosyakonum2, ID + "/" + KONU + "/" + KISISAYISI + "/" + KURUCU + "/" + TARIH + "/" + SAAT + "/" + DONUT + "\n");

            dataGridView1.Rows.Add(ID, KONU, KISISAYISI, KURUCU, TARIH, SAAT, DONUT);


        }

        public void button2_Click(object sender, EventArgs e)
        {




            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string KONU = textBox2.Text;
            string KISISAYISI = textBox3.Text;
            string KURUCU = textBox4.Text;
            string TARIH = dateTimePicker1.Text;
            string SAAT = maskedTextBox1.Text;
            string DONUT = richTextBox1.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(ID, KONU, KISISAYISI, KURUCU, TARIH, SAAT, DONUT);

        }

        public void button4_Click(object sender, EventArgs e)
        {
            string ID = textBox5.Text;
            string ISIM = textBox6.Text;
            string TARIH = dateTimePicker2.Text;
            string SAAT = maskedTextBox3.Text;


            dataGridView2.Rows.Add(ID, ISIM, TARIH, SAAT);
        }

        public void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        public void button6_Click(object sender, EventArgs e)
        {
            string ID = textBox5.Text;
            string ISIM = textBox6.Text;
            string TARIH = dateTimePicker2.Text;
            string SAAT = maskedTextBox3.Text;


            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(ID, ISIM, TARIH, SAAT);

        }

        public void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            string ISIM = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            string TARIH = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            string SAAT = dataGridView2.CurrentRow.Cells[3].Value.ToString();


            textBox5.Text = ID;
            textBox6.Text = ISIM;
            dateTimePicker2.Text = TARIH;
            maskedTextBox3.Text = SAAT;

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button7_Click(object sender, EventArgs e)
        {

            string dosyakonum2 = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\ToplantiListesi.txt";
            string[] data_ = File.ReadAllLines(dosyakonum2);
            string[] value;
            for (int i = 0; i < data_.Length; i++)
            {
                value = data_[i].Split('/');
                string[] row = new string[value.Length];
                for (int j = 0; j < value.Length; j++)
                {


                    row[j] = value[j].Trim();

                }

                dataGridView1.Rows.Add(row);


            }
        }




        private void button8_Click_1(object sender, EventArgs e)
        {
            string dosyakonum2 = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\ToplantiListesi.txt";
            File.WriteAllText(dosyakonum2, "");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string A, B, C, D, E, F, G;

                A = dataGridView1.Rows[i].Cells[0].Value.ToString();
                B = dataGridView1.Rows[i].Cells[1].Value.ToString();
                C = dataGridView1.Rows[i].Cells[2].Value.ToString();
                D = dataGridView1.Rows[i].Cells[3].Value.ToString();
                E = dataGridView1.Rows[i].Cells[4].Value.ToString();
                F = dataGridView1.Rows[i].Cells[5].Value.ToString();
                G = dataGridView1.Rows[i].Cells[6].Value.ToString();
                string toplama = A + "/" + B + "/" + C + "/" + D + "/" + E + "/" + F + "/" + G + "/";

                File.AppendAllText(dosyakonum2, toplama + "\n");



            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

            string dosyakonum3 = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\Uygunluk.txt";
            string[] data_ = File.ReadAllLines(dosyakonum3);
            string[] value;
            for (int i = 0; i < data_.Length; i++)
            {
                value = data_[i].Split('/');
                string[] row = new string[value.Length];
                for (int j = 0; j < value.Length; j++)
                {


                    row[j] = value[j].Trim();

                }

                dataGridView2.Rows.Add(row);


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string dosyakonum3 = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\Uygunluk.txt";
            File.WriteAllText(dosyakonum3, "");

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                string A, B, C, D;

                A = dataGridView2.Rows[i].Cells[0].Value.ToString();
                B = dataGridView2.Rows[i].Cells[1].Value.ToString();
                C = dataGridView2.Rows[i].Cells[2].Value.ToString();
                D = dataGridView2.Rows[i].Cells[3].Value.ToString();

                string toplama = A + "/" + B + "/" + C + "/" + D + "/";

                File.AppendAllText(dosyakonum3, toplama + "\n");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {




            string dosyakonum4 = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\Kayit.txt";
            string[] data_ = File.ReadAllLines(dosyakonum4);
            

            for (int i = 0; i < data_.Length; i+=4)
            {

                dataGridView3.Rows.Add(data_[i] , data_[i+1]);

             }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            string dosyakonum5 = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\Mesajgiden.txt";
           


            string ADSOYAD = textBox7.Text;
            string yazilan = richTextBox3.Text;


            listBox1.Items.Add(ADSOYAD+" :"+richTextBox3.Text);
            
            File.AppendAllText(dosyakonum5, ADSOYAD +":"+ " \n" + yazilan+"\n");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string dosyakonum5 = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\Mesajgiden.txt";
            File.ReadAllLines(dosyakonum5);

            string[] mesaj= File.ReadAllLines(dosyakonum5);
            for (int i = 0;i < mesaj.Length;i++)
            {


                listBox1.Items.Add(mesaj[i]);


            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        public void button14_Click(object sender, EventArgs e)
        {
            string kayit = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\Toplantilarim.txt";
            DateTime Toplantı = dateTimePicker3.Value;
            
         

            
            File.AppendAllText(kayit,Toplantı+" :"+richTextBox2.Text+"\n");

        }

      
        public void button15_Click(object sender, EventArgs e)
        {
            string kayit = @"C:\Users\akeph\Documents\GitHub\ToplantiPlanlama\Toplantilarim.txt";
            File.ReadAllLines(kayit);

            string[] mesaj = File.ReadAllLines(kayit);
            for (int i = 1; i < mesaj.Length; i++)
            {


                listBox2.Items.Add(mesaj[i]);


            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

      /*  public void button16_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string eventTitle = row.Cells["Title"].Value.ToString();
                DateTime eventDate = Convert.ToDateTime(row.Cells["Date"].Value);

                Event newEvent = new Event()
                {
                    Summary = eventTitle,
                   
                };

                EventsResource.InsertRequest request = calendarService.Events.Insert(newEvent, "primary");
                Event createdEvent = request.Execute();

               
                string eventLink = createdEvent.HtmlLink;
                
            }

        }*/
    }
}


