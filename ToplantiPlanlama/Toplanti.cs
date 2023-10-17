using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToplantiPlanlama.Class;

namespace ToplantiPlanlama
{
    public partial class Toplanti : Form
    { SMS sms = new SMS();

        public Toplanti()
        {
            InitializeComponent();
        }

        private void Toplanti_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          string ID=  dataGridView1.CurrentRow.Cells[0].Value.ToString();
          string KONU = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string KISISAYISI = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string KURUCU = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string TARIH = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string SAAT= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string DONUT = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            textBox1.Text = ID;
            textBox2.Text = KONU;
            textBox3.Text = KISISAYISI;
            textBox4.Text = KURUCU;
            dateTimePicker1.Text = TARIH;
            maskedTextBox1.Text = SAAT;
            richTextBox1.Text = DONUT;

        }

        private void button1_Click(object sender, EventArgs e)
        {string ID = textBox1.Text;
            string KONU = textBox2.Text;
            string KISISAYISI= textBox3.Text;
            string KURUCU = textBox4.Text;  
            string TARIH = dateTimePicker1.Text;
            string SAAT =maskedTextBox1.Text;
            string DONUT = richTextBox1.Text;

            dataGridView1.Rows.Add(ID, KONU, KISISAYISI, KURUCU, TARIH,SAAT,DONUT);
            
        }

        private void button2_Click(object sender, EventArgs e)
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
            dataGridView1.Rows.Add(ID, KONU, KISISAYISI, KURUCU, TARIH, SAAT,DONUT);

        }
    }
}
