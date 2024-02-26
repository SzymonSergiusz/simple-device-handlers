using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace czytnik_kart_magnetycznych
{
    public partial class Form1 : Form
    {
        Czytnik czytnik = new Czytnik();
        public Form1()
        {
            InitializeComponent();
            czytnik.connect(isConnected);
            

        }



        private void readButton_Click(object sender, EventArgs e)
        {
            string odczyt = czytnik.odczytajKarte();
            odczytLista.Items.Add(odczyt);
            
        }

        private void trybKarty_Click(object sender, EventArgs e)
        {
            string odczyt = czytnik.wybierzModulCzytnika();
            wyslaneLista.Items.Add(odczyt);
        }

        private void trybKlawiatury_Click(object sender, EventArgs e)
        {
            czytnik.wybierzModulKlawiatury();
            wyslaneLista.Refresh();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            string odczyt = czytnik.zaswiecDiodeRed();
            wyslaneLista.Items.Add(odczyt);
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            string odczyt = czytnik.zaswiecDiodeGreen();
            wyslaneLista.Items.Add(odczyt);
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            string odczyt = czytnik.zaswiecDiodeYellow();
            wyslaneLista.Items.Add(odczyt);
        }

        private void odczytKarty_Click(object sender, EventArgs e)
        {
        
            string odczyt = czytnik.odczytajKarte();
            odczytLista.Items.Add(odczyt);

            var str = odczyt.Split('-');
            string kodWydzialu = str[2].ElementAt(1).ToString() + str[3].ElementAt(1).ToString();
            string kodKarty = str[4].ElementAt(1).ToString() + str[5].ElementAt(1).ToString() + str[6].ElementAt(1).ToString() + str[7].ElementAt(1).ToString() + str[8].ElementAt(1).ToString();
            kodWydzialuText.Text = kodWydzialu;
            kodKartyText.Text = kodKarty;


        }

        private void odczytKlawiatura_Click(object sender, EventArgs e)
        {

            string odczyt = czytnik.odczytajKarte();
            odczytLista.Items.Add(odczyt);

            var str = odczyt.Split('-');
            string pin = str[2].ElementAt(1).ToString() + str[3].ElementAt(1).ToString()+ str[4].ElementAt(1).ToString() + str[5].ElementAt(1).ToString();
            pinText.Text = pin;
        }
    }
}
