using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace czytnik_kart_gsm
{
    class Czytnik
    {

        public struct SCARD_IO_REQUEST
        {
            uint dwProtocol;
            uint cbPciLength;

            public SCARD_IO_REQUEST(uint dwProtocol, uint cbPciLength)
            {
                this.dwProtocol = dwProtocol;
                this.cbPciLength = cbPciLength;
            }
        }

        [DllImport("winscard.dll", CharSet = CharSet.Auto)]
        public static extern int SCardEstablishContext(uint dwScope, IntPtr pvReserved1, IntPtr pvReserved2, out IntPtr phContext);

        [DllImport("winscard.dll", EntryPoint = "SCardListReaders", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int SCardListReaders(IntPtr hContext, byte[] mszGroups, byte[] mszReaders, ref uint pcchReaders);

        [DllImport("winscard.dll", CharSet = CharSet.Auto)]
        public static extern int SCardConnect(IntPtr hContext, string szReader, uint dwShareMode, uint dwPreferredProtocols, out IntPtr phCard, out uint pdwActiveProtocol);

        [DllImport("winscard.dll", CharSet = CharSet.Auto)]
        public static extern int SCardTransmit(IntPtr hCard, uint pioSendPci, byte[] pbSendBuffer, uint cbSendLength, IntPtr pioRecvPci, byte[] pbRecvBuffer, ref uint pcbRecvLength);

        [DllImport("winscard.dll", CharSet = CharSet.Auto)]
        public static extern int SCardDisconnect(IntPtr hCard, uint dwDisposition);

        [DllImport("winscard.dll", CharSet = CharSet.Auto)]
        public static extern int SCardReleaseContext(IntPtr hContext);

        IntPtr hContext = IntPtr.Zero;
        IntPtr hCard = IntPtr.Zero;
        uint dwReaders = 0;
        uint dwActiveProtocol = 0;
        uint dwRecvLength = 1000;
        int result = -1;

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



        public string znajdzUrzadzenia()
        {
            result = SCardEstablishContext(2, IntPtr.Zero, IntPtr.Zero, out hContext);

            uint pcchReaders = 0;
            result = SCardListReaders(hContext, null, null, ref pcchReaders);

            byte[] mszGroups = new byte[pcchReaders];
            result = SCardListReaders(hContext, null, mszGroups, ref pcchReaders);

            string sBuffer = Encoding.ASCII.GetString(mszGroups);

            int end;
     
            int len = (int)pcchReaders;

            var readers = "";

            while (sBuffer[0] != (char)0)
            {
                end = sBuffer.IndexOf((char)0);
                string reader = sBuffer.Substring(0, end);
                readers += reader;
                len -= (reader.Length + 1);
                sBuffer = sBuffer.Substring(end + 1, len);
            }

            Debug.WriteLine(readers);
            //List<string> list = new List<string>;
            //list.Add(readers);
            return readers;


        }
        uint SCARD_PROTOCOL_T0 = 0x01;


        SCARD_IO_REQUEST T0 = new SCARD_IO_REQUEST(0x01, 8);
        SCARD_IO_REQUEST T1 = new SCARD_IO_REQUEST(0x02, 8);

        public void polacz(string device)
        {
            IntPtr hContext = IntPtr.Zero;
            IntPtr hCard = IntPtr.Zero;
            uint dwActiveProtocol = 0;


            result = SCardEstablishContext(2, IntPtr.Zero, IntPtr.Zero, out hContext);

            Debug.WriteLine("czy ustanowiono context: " + result);
            result = SCardConnect(hContext, device, 2, 0x03, out hCard, out dwActiveProtocol);

            Debug.WriteLine("czy połączono: " + result);
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
            byte[] responseBuffer = new byte[1000];

            //cmdByte cm = new { 0xA0, 0xA4, 0x02, 0x7F, 0x10 };

            //CmdBytes cmdB = new CmdBytes(0xA0, 0xA4, 0x02, 0x7F, 0x10);

            result = SCardTransmit(hCard, 0x03, cmd, (uint)cmd.Length, IntPtr.Zero, responseBuffer, ref dwRecvLength);
            Debug.WriteLine("kod błędu: " + result);
            if (result != 0)
            {
                Debug.WriteLine("nie wysłało komendy");
                //SCardDisconnect(hCard, 0);
                //SCardReleaseContext(hContext);
            }
            else
            {
                Debug.WriteLine("Odpowiedź w hex");
                foreach (byte b in responseBuffer)
                {
                    Debug.WriteLine($"{b:X2} ");
                }
            }




        }
    }
}
