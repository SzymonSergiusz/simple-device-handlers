using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace czytnik_kart_gsm
{
    public partial class Form1 : Form
    {

        CzytnikPSCS czytnik = new CzytnikPSCS();
        public Form1()
        {
            InitializeComponent();

            var list = czytnik.znajdzUrzadzenia();

            devicesList.DataSource = list;
            czytnik.polacz("OMNIKEY CardMan 5x21 0");
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string nazwa = devicesList.SelectedValue.ToString();
            czytnik.polacz(nazwa);

        }

        private void showContacts_Click(object sender, EventArgs e)
        {
            //GSM, SELECT, P1,P2, 7F -> DF, 
            //CLA INS P1 	P2 	P3 	Data
            byte[] wyborTelecom = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x7F, 0x10 };

            //czytnik.wyslijKomende(wyborTelecom);

            czytnik.odczytajKontakty();
        }
    }
}
