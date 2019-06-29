using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[,] Tum_Calisanlar = new string[11, 4];
        public string[,] Tum_Urunler = new string[18, 2];
        public string[,] Tum_Subeler = new string[1, 2];

        private void Form1_Load(object sender, EventArgs e)
        {

            // 1. Şubenin çalışanlarının oluşturulması

            Tum_Calisanlar[0, 0] = "John";
            Tum_Calisanlar[0, 1] = "Smith";
            Tum_Calisanlar[0, 2] = "0001";
            Tum_Calisanlar[0, 3] = "Yönetici";

            Tum_Calisanlar[1, 0] = "Frank";
            Tum_Calisanlar[1, 1] = "Moore";
            Tum_Calisanlar[1, 2] = "0002";
            Tum_Calisanlar[1, 3] = "Usta";

            Tum_Calisanlar[2, 0] = "Nilson";
            Tum_Calisanlar[2, 1] = "Cliff";
            Tum_Calisanlar[2, 2] = "0003";
            Tum_Calisanlar[2, 3] = "Usta";

            Tum_Calisanlar[3, 0] = "Kate";
            Tum_Calisanlar[3, 1] = "Angle";
            Tum_Calisanlar[3, 2] = "0004";
            Tum_Calisanlar[3, 3] = "Garson";

            Tum_Calisanlar[4, 0] = "David";
            Tum_Calisanlar[4, 1] = "Hanks";
            Tum_Calisanlar[4, 2] = "0005";
            Tum_Calisanlar[4, 3] = "Garson";

            Tum_Calisanlar[5, 0] = "Chuck";
            Tum_Calisanlar[5, 1] = "Moore";
            Tum_Calisanlar[5, 2] = "0006";
            Tum_Calisanlar[5, 3] = "Garson";

            Tum_Calisanlar[6, 0] = "Terry";
            Tum_Calisanlar[6, 1] = "Carpenter";
            Tum_Calisanlar[6, 2] = "0007";
            Tum_Calisanlar[6, 3] = "Garson";

            Tum_Calisanlar[7, 0] = "Linda";
            Tum_Calisanlar[7, 1] = "Angle";
            Tum_Calisanlar[7, 2] = "0008";
            Tum_Calisanlar[7, 3] = "Kasiyer";

            Tum_Calisanlar[8, 0] = "Denis";
            Tum_Calisanlar[8, 1] = "Reyes";
            Tum_Calisanlar[8, 2] = "0009";
            Tum_Calisanlar[8, 3] = "Kurye";

            Tum_Calisanlar[9, 0] = "Leonardo";
            Tum_Calisanlar[9, 1] = "Price";
            Tum_Calisanlar[9, 2] = "0010";
            Tum_Calisanlar[9, 3] = "Kurye";

            Tum_Calisanlar[10, 0] = "Jason";
            Tum_Calisanlar[10, 1] = "Nolan";
            Tum_Calisanlar[10, 2] = "0011";
            Tum_Calisanlar[10, 3] = "Temizlikçi";

            // Urunlerin oluşturulması

            Tum_Urunler[0, 0] = "Mercimek Çorbası";
            Tum_Urunler[0, 1] = "137 kcal";

            Tum_Urunler[1, 0] = "Mantar Çorbası";
            Tum_Urunler[1, 1] = "139 kcal";

            Tum_Urunler[2, 0] = "Tavuk Çorbası";
            Tum_Urunler[2, 1] = "132 kcal";

            Tum_Urunler[3, 0] = "Spagetti";
            Tum_Urunler[3, 1] = "382 kcal";

            Tum_Urunler[4, 0] = "Burger";
            Tum_Urunler[4, 1] = "634 kcal";

            Tum_Urunler[5, 0] = "Lazanya";
            Tum_Urunler[5, 1] = "692 kcal";

            Tum_Urunler[6, 0] = "Chicken Pane";
            Tum_Urunler[6, 1] = "540 kcal";

            Tum_Urunler[7, 0] = "Napoli Pizza";
            Tum_Urunler[7, 1] = "630 kcal";

            Tum_Urunler[8, 0] = "Patates Tabağı";
            Tum_Urunler[8, 1] = "500 kcal";

            Tum_Urunler[9, 0] = "Soğan Halkası";
            Tum_Urunler[9, 1] = "380 kcal";

            Tum_Urunler[10, 0] = "Caesar Salad";
            Tum_Urunler[10, 1] = "98 kcal";

            Tum_Urunler[11, 0] = "Diet Cola";
            Tum_Urunler[11, 1] = "0 kcal";

            Tum_Urunler[12, 0] = "Cola";
            Tum_Urunler[12, 1] = "149 kcal";

            Tum_Urunler[13, 0] = "Ice Tea";
            Tum_Urunler[13, 1] = "99 kcal";

            Tum_Urunler[14, 0] = "Lemonade";
            Tum_Urunler[14, 1] = "125 kcal";

            Tum_Urunler[15, 0] = "Brownie";
            Tum_Urunler[15, 1] = "414 kcal";

            Tum_Urunler[16, 0] = "Tiramisu";
            Tum_Urunler[16, 1] = "452 kcal";

            Tum_Urunler[17, 0] = "Profiterol";
            Tum_Urunler[17, 1] = "633 kcal";

            // Şubelerin oluşturulması

            Tum_Subeler[0, 0] = "İzmir Şubesi";
            Tum_Subeler[0, 1] = "001";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            for (int i = 0; i < Tum_Calisanlar.GetLength(0); i++)
            {
                for (int j = 0; j < Tum_Calisanlar.GetLength(1); j++)
                {
                    listView1.Items.Add(Tum_Calisanlar[i, j]);                                 
                }

                listView1.Items.Add(""); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            for (int i = 0; i < Tum_Urunler.GetLength(0); i++)
            {
                for (int j = 0; j < Tum_Urunler.GetLength(1); j++)
                {
                    listView2.Items.Add(Tum_Urunler[i, j]);
                }

                listView2.Items.Add("");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            for (int i = 0; i < Tum_Subeler.GetLength(0); i++)
            {
                for (int j = 0; j < Tum_Subeler.GetLength(1); j++)
                {
                    listView2.Items.Add(Tum_Subeler[i, j]);
                }

                listView2.Items.Add("");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
