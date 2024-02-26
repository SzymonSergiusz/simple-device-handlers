using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace czytnik_kart_magnetycznych
{
    internal class Czytnik
    {
        public List<String> odpowiedzi = new List<String>();
        public List<String> zapytania = new List<String>();
        //Parametry transmisji realizowanej przez klawiaturowy czytnik kart magnetycznych wynoszą - 2400,E,8,1
        SerialPort serialPort =
            new SerialPort("COM1", 2400, Parity.Odd, 8, StopBits.One);



        public void connect(Label label)
        {
            serialPort.Open();
            if (serialPort.IsOpen)
            {
                Debug.Write("Nawiązano połączenie");
                label.Text = "Nawiązano połączenie";
                //System.Console.WriteLine("Nawiązano połączenie");

            }
            else
            {

                label.Text = "Nie nawiązano połączenia";
                Debug.Write("Nie połączono");
                //System.Console.WriteLine("Nie połączono");
            }
        }

        public void disconnect() {
            serialPort.Close();
        }
        public void odczytajJeden()
        {
            byte[] buffer = new byte[1];

            //serialPort.Read(buffer, 0, ile);
        }
        private string odczytaj(int ile)
        {
            
            byte[] buffer = new byte[ile];
            serialPort.Read(buffer, 0, ile);
            Debug.WriteLine(BitConverter.ToString(buffer));
            odpowiedzi.Add(BitConverter.ToString(buffer));
            return BitConverter.ToString(buffer);
        }
        public string odczytajKarte()
        {
            //odczytaj(21);
            return odczytaj(19);
        }

        public void odczytajOdpowiedz()
        {
            odczytaj(2);
        }
        //komendy
        /*
            168 (0A8H) - wybierz moduł klawiatury
            170 (0AAH) - wybierz moduł czytnika karty
            161 (0A1H) - zaświeć diodę czerwoną
            162 (0A2H) - zaświeć diodę żółtą
            164 (0A4H) - zaświeć diodę zieloną
        FF F8 kod realizacji
         */


        //byte terminator = 0x0FF;
        byte terminator = 255;

        byte klawiatura = 0x0A8;
        byte czytnik = 0x0AA;
        //byte red = 0x0A1;
        byte red = 161;
        byte yellow = 0x0A2;
        byte green = 0x0A4;

        public string wyslij(byte komenda)
        {

            byte[] b = { komenda, terminator };
            serialPort.Write(b, 0, 2);
            
            
            //byte[] r = new byte[2];
            //serialPort.Read(r, 0, 2);
            odczytaj(2);
            return BitConverter.ToString(b);
        }
        public void wybierzModulKlawiatury()
        {
            wyslij(klawiatura);
        }

        public string wybierzModulCzytnika()
        {
           return wyslij(czytnik);
        }

        public string zaswiecDiodeRed()
        {
            return wyslij(red);
        }
        public string zaswiecDiodeYellow()
        {
            return wyslij(yellow);
        }
        public string zaswiecDiodeGreen()
        {
            return wyslij(green);
        }
    }
}
