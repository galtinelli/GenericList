using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //List<> içerisine <T> verilen tipe bürünerek, o tipte bir koleksiyon oluşturmamıza imkan sağlar. Daha öncek dizilerdeki gibi boyutu artırma işlemine gerk kalmadan, eleman ekleyebildiğimiz ve Array sınıfını kullanmamıza gerek kalmadan üzerinde işlem yapabildiğimiz gelişmiş bir sınıftır.
        private void btnElemanEkle_Click(object sender, EventArgs e)
        {
            //Generic List Oluşturma
            List<int> sayilar = new List<int>(); //new sonrasında yazılan List constructor yapıcı


            //Listeye ekleme  //Listenin sonuna ekler.

            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(6);
            sayilar.Add(7);

        }

        private void btnDongu_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Bursa");
            sehirler.Add("Malatya");
            sehirler.Add("Kocaeli");
            sehirler.Add("İzmir");

            foreach (string item in sehirler)
            {
                MessageBox.Show(item);
            }

            //Linq sınıfını kullanarak list içerisinde gelişmiş metodlar kullanılabilir.


            sehirler.ForEach(item => MessageBox.Show(item));

            foreach (string str in sehirler)
            {
                MessageBox.Show(str);
            }
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Bursa");
            sehirler.Add("Malatya");
            sehirler.Add("Kocaeli");
            sehirler.Add("İzmir");

            MessageBox.Show(sehirler.Contains("Eskişehir") ? "Eskişehir bulunmaktadır." : "Eskişehir dahil değildir");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Bursa");
            sehirler.Add("Malatya");
            sehirler.Add("Kocaeli");
            sehirler.Add("İzmir");

            //Sort() dizinin elemanlarını küçükten büyüğe sıralar yada A-Z ye

            sehirler.Sort();
            foreach (string item in sehirler)
            {
                MessageBox.Show(item);
            }
        }
    }
}
