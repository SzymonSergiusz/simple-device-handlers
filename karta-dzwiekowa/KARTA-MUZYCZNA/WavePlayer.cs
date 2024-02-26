using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KARTA_MUZYCZNA
{
    class WavePlayer
    {

        [DllImport("winmm.dll")]
        public static extern int waveOutOpen(out IntPtr hWaveOut, uint uDeviceID, ref WAVEFORMATEX lpFormat, IntPtr dwCallback, IntPtr dwInstance, uint dwFlags);

        [DllImport("winmm.dll")]
        public static extern int waveOutPrepareHeader(IntPtr hWaveOut, ref WAVEHDR lpWaveOutHdr, uint uSize);

        [DllImport("winmm.dll")]
        public static extern int waveOutWrite(IntPtr hWaveOut, ref WAVEHDR lpWaveOutHdr, uint uSize);

        [DllImport("winmm.dll")]
        public static extern int waveOutReset(IntPtr hWaveOut);

        [DllImport("winmm.dll")]
        public static extern int waveOutUnprepareHeader(IntPtr hWaveOut, ref WAVEHDR lpWaveOutHdr, uint uSize);

        [DllImport("winmm.dll")]
        public static extern int waveOutPause(IntPtr hWaveOut);

        [DllImport("winmm.dll")]
        public static extern int waveOutRestart(IntPtr hWaveOut);

        //zgodnie z dokumentacją
        public struct WAVEFORMATEX
        {
            public ushort wFormatTag;
            public ushort nChannels;
            public uint nSamplesPerSec;
            public uint nAvgBytesPerSec;
            public ushort nBlockAlign;
            public ushort wBitsPerSample;
            public ushort cbSize;
        }

        public struct WAVEHDR
        {
            public IntPtr lpData;
            public uint dwBufferLength;
            public uint dwBytesRecorded;
            public IntPtr dwUser;
            public uint dwFlags;
            public uint dwLoops;
            public IntPtr lpNext;
            public IntPtr reserved;
        }

        private IntPtr hWaveOut = IntPtr.Zero;
        private WAVEHDR waveHeader;
        private byte[] audioData;

        

        public WavePlayer()
        {
            WAVEFORMATEX waveFormat = new WAVEFORMATEX
            {
                wFormatTag = 1, //PCM
                nChannels = 1, // stereo
                nSamplesPerSec = 44100,
                wBitsPerSample = 16,
                cbSize = 0
            };
            waveFormat.nBlockAlign = 
            waveFormat.nBlockAlign = (ushort)(waveFormat.nChannels * waveFormat.wBitsPerSample / 8);// channels * bits/sample / 8
            waveFormat.nAvgBytesPerSec = waveFormat.nSamplesPerSec * waveFormat.nChannels * waveFormat.wBitsPerSample / 8; //samples * channels * bits/samples/8

            int result = waveOutOpen(out hWaveOut, 0, ref waveFormat, IntPtr.Zero, IntPtr.Zero, 0);

            if (result != 0)
            {
                Debug.WriteLine("Błąd: " + result);
            }
        }

        bool isPlaying = false;
        public void play(string path)
        {

            if (isPlaying)
            {
                waveOutRestart(hWaveOut);
                isPlaying = !isPlaying;
            } else
            {

                audioData = File.ReadAllBytes(path);

                waveHeader = new WAVEHDR
                {
                    lpData = Marshal.AllocHGlobal(audioData.Length),
                    dwBufferLength = (uint)audioData.Length,
                    dwFlags = 0
                };
                //alokacja pamięci do wh.lpdata
                Marshal.Copy(audioData, 0, waveHeader.lpData, audioData.Length);

                waveOutPrepareHeader(hWaveOut, ref waveHeader, (uint)Marshal.SizeOf(typeof(WAVEHDR)));
                
                waveOutWrite(hWaveOut, ref waveHeader, (uint)Marshal.SizeOf(typeof(WAVEHDR)));
                
            }
        }

        public void pause()
        {
            isPlaying = true;
            waveOutPause(hWaveOut);
        }

        public void stop()
        {
            isPlaying = false;
            waveOutReset(hWaveOut);
            waveOutUnprepareHeader(hWaveOut, ref waveHeader, (uint)Marshal.SizeOf(typeof(WAVEHDR)));
            Marshal.FreeHGlobal(waveHeader.lpData);
            
        }

    }
}
