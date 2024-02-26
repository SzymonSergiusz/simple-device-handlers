using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PCSC;

namespace czytnik_kart_gsm
{
    class CzytnikPSCS
    {

     
        //komendy

        // GSM, SELECT, P1,P2, 7F -> DF, 
        byte[] wyborTelecom = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x7F, 0x10 };
        byte[] odpowiedz = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x0F };

        // GSM, SELECT, P1,P2, 6F -> EF, 
        byte[] wyborSMS = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x6F, 0x3C };

        // GSM, SELECT, P1,P2, 6F -> EF, 
        byte[] wyborADN = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x6F, 0x3A };


        //GSM, READ RECORD, NUMER REKORDU, MODE, DŁUGOŚĆ
        byte[] odczytajRekord = new byte[] { 0xA0, 0xB2, 0x01, 0x04, 0xB0 };



        public List<string> znajdzUrzadzenia()
        {
            var contextFactory = ContextFactory.Instance;

            var list = new List<string>();
            using (var context = contextFactory.Establish(SCardScope.System))
            {
                Console.WriteLine("Currently connected readers: ");
                var readerNames = context.GetReaders();
                foreach (var readerName in readerNames)
                {
                    Console.WriteLine("\t" + readerName);
                    list.Add(readerName);

                }
            }
            return list;

        }

        //ICardReader reader;
        public void polacz(string device)
        {
            var contextFactory = ContextFactory.Instance;
            using (var ctx = contextFactory.Establish(SCardScope.System))
            {

                var reader = ctx.ConnectReader(device, SCardShareMode.Shared, SCardProtocol.Any);
 
            }
        }

        public void wejdzDoTelecom()
        {
            wyslijKomende(wyborTelecom);
            wyslijKomende(odpowiedz);
        }

        public void odczytajKontakty()
        {
            wejdzDoTelecom();
            wyslijKomende(wyborADN);
            wyslijKomende(odpowiedz);

            wyslijKomende(odczytajRekord);
            wyslijKomende(odpowiedz);

        }

        public void odczytajSmsy()
        {
            wejdzDoTelecom();
            wyslijKomende(wyborSMS);
            wyslijKomende(odpowiedz);

            wyslijKomende(odczytajRekord);
            wyslijKomende(odpowiedz);
        }

        public void odkodujDane()
        {

        }

        struct CmdBytes
        {

            byte bCla;   // the instruction class
            byte bIns;   // the instruction code 
            byte bP1;    // parameter to the instruction
            byte bP2;    // parameter to the instruction
            byte bP3;    // size of I/O transfer

            public CmdBytes(byte bCla, byte bIns, byte bP1, byte bP2, byte bP3)
            {
                this.bCla = bCla;
                this.bIns = bIns;
                this.bP1 = bP1;
                this.bP2 = bP2;
                this.bP3 = bP3;
            }
        };

        public void wyslijKomende(byte[] cmd)
        {
            var contextFactory = ContextFactory.Instance;
            using (var ctx = contextFactory.Establish(SCardScope.System))
            {
                using (var reader = ctx.ConnectReader("OMNIKEY CardMan 5x21 0", SCardShareMode.Shared, SCardProtocol.Any))
                {
                    var responseBuffer = new byte[32];
                    var response = reader.Transmit(cmd, responseBuffer);

                    foreach (byte b in responseBuffer)
                    {
                        //Debug.Write($"{b:X2} ");
                        Debug.Write( (Char) b);
                    }
                    Debug.WriteLine("");
                }
            }
        }
    }
}
