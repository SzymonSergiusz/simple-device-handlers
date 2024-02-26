using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARTA_MUZYCZNA
{
    class MciHandler
    {
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern long mciSendString(string command, string buffer, int bufferSize, IntPtr hwndCallback);

        bool resumeMCI = false;
        public void play(string path)
        {
            if (resumeMCI == true)
            {
                mciSendString("resume wavplayer", null, 0, IntPtr.Zero);

            }
            else
            {
                string openCommand = "open " + path + " type waveaudio alias wavplayer";
                long result = mciSendString(openCommand, null, 0, IntPtr.Zero);
                mciSendString("play wavplayer from 0", null, 0, IntPtr.Zero);
            }
        }

        public void pause()
        {
            resumeMCI = true;
            mciSendString("pause wavplayer", null, 0, IntPtr.Zero);
        }

        public void stop()
        {
            mciSendString("stop wavplayer", null, 0, IntPtr.Zero);
            resumeMCI = false;
        }

        public void startRecord()
        {
            mciSendString("open new type waveaudio alias recorder", null, 0, IntPtr.Zero);
            mciSendString("record recorder", null, 0, IntPtr.Zero);
        }

        public void stopRecord(string path)
        {

            mciSendString("save recorder " + path + ".wav", null, 0, IntPtr.Zero);
            mciSendString("close recorder ", null, 0, IntPtr.Zero);
        }
    }
}
