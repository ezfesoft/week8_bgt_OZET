using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8_bgt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nesnelerin özelliklerini ve olaylarını etkili şekilde kullanbilir. ");

            MessageBox.Show("İstenilen Kullanıcı Arayünü, Form üzerinde tasarlayabilir.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Değişken

            // Değişken türlerini bilir.
            string ad;
            int sayi;
            bool yetki;
            double ortalama;

            // Değişken isimlendirme
            // Doğru          string ogrenciSoyadi; 
            // Yanlış         string ogr soyadi;
            // Yanlış         string 1ogrSoyadi;
            // Yanlış         string ogr.Soyadi;

            // Değişkene atama yapma
            int s1 = 15;
            int s2;
            s2 = s1 + 3;
            s2++;
            s1 *= 3;
            s1 = s1 + 3; //  -> s+=3;
            s2 = s2 / 4; //  -> s2/=4
            string isim;
            isim = "Ali";
            isim += " Veli";
            isim = "Ahmet";

            MessageBox.Show("Değişken Türlerini Bilir");
            MessageBox.Show("Değişken İsimlendirme kurallarını bilir ve dogru şekilde isimlendirir");
            MessageBox.Show("Değişken atamaları yapar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kullanicidan Bilgi Alma
            string gelenBilgi;
            gelenBilgi = textBox1.Text;
            MessageBox.Show("(String Ifade) Merhaba " + gelenBilgi);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Değişken Dönüşümü
            int dogumTarihi;
            int yas;
            dogumTarihi = Convert.ToInt32(textBox2.Text);
            yas = 2023 - dogumTarihi;
            MessageBox.Show("(Int Ifade) Yaşınız" + yas.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koşul cümlesini uygun bir şekilde yazabilir.");
            MessageBox.Show("Mantık hatası olmadan koşul ifadesi doğru çalışır.");
            MessageBox.Show("Eğer koşulunu doğru kurar IF");
            MessageBox.Show("Değilse koşulu doğru kurar ELSE");
            MessageBox.Show("Bağlaçları doğru kullanır. VE VEYA");
            MessageBox.Show("Mantıksal oparatörleri bilir");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.=>"+ (15 < 4).ToString() );
            int a = 10;
            int b = 10;
            bool c;
            c = a == b;
            MessageBox.Show("2.=>"+c.ToString());
            // == , != , && , || , > , < , >= , <=
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // IF Koşul İfadesi
            int a, b;
            a = 3;
            b = 2;

            if (a > b)
            {
                MessageBox.Show("a sayısı büyüktür.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // IF ELSE Koşul İfadesi
            int a, b;
            a = 10;
            b = 70;

            if (a > b)
            {
                MessageBox.Show("a sayısı büyüktür.");
            }
            else
            {
                MessageBox.Show("a sayısı büyük değildir.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // IF ELSE IF Koşul İfadesi
            int a, b;
            a = 10;
            b = 70;

            if (a > b)
            {
                MessageBox.Show("a sayısı büyüktür.");
            }
            else if (a == b)
            {
                MessageBox.Show("a sayısı eşittir b'ye.");
            }
            else
            {
                MessageBox.Show("b sayısı büyüktür");
            }
        }
    }
}
