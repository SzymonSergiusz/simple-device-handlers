using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KARTA_MUZYCZNA
{
    public partial class Form1 : Form
    {

        MciHandler mci = new MciHandler();
        public Form1()
        {
            InitializeComponent();
            axWMP.CreateControl();
            pathInput.Text = @"C:\Users\lab\Downloads\StarWars60_1min.wav";
            recordedFile.Text = "test";
            
        }

        private void browseFilesButton_Click(object sender, EventArgs e)
        {
            var filePath = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "wave files (*.wav) |";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                }
            }

            pathInput.Text = filePath;
        }

        SoundPlayer soundplayer;
        private void playPlaysound_Click(object sender, EventArgs e)
        {
            soundplayer = new SoundPlayer(pathInput.Text);
            soundplayer.Play();
        }

        private void pausePlaysound_Click(object sender, EventArgs e)
        {
        }

        private void stopPlaysound_Click(object sender, EventArgs e)
        {
            soundplayer.Stop();
        }



        private void axWMP_Enter(object sender, EventArgs e)
        {

        }

        double currPosition = 0;
        private void wmpPlay_Click(object sender, EventArgs e)
        {
            axWMP.URL = pathInput.Text;
            axWMP.Ctlcontrols.currentPosition = currPosition;
            axWMP.Ctlcontrols.play();
           
        }

        private void wmpStop_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.stop();
            currPosition = 0;
        }

        private void wmpPause_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause();
            currPosition = axWMP.Ctlcontrols.currentPosition;
        }

        private void mciPlay_Click(object sender, EventArgs e)
        {
            mci.play(pathInput.Text);

        }

        private void mciPause_Click(object sender, EventArgs e)
        {
            mci.pause();
        }

        private void mciStop_Click(object sender, EventArgs e)
        {
            mci.stop();
        }

        bool isRecording = false;
        private void recordButton_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\lab\source\repos\KARTA-MUZYCZNA\KARTA-MUZYCZNA\records\" + recordedFile.Text;

            if (isRecording)
            {
                mci.stopRecord(path);
                recordButton.Text = "Nagrywaj";
                isRecording = !isRecording;
            } else
            {
                recordButton.Text = "Zakończ nagrywać";
                mci.startRecord();
                isRecording = !isRecording;
            }
        }
        WavePlayer wavePlayer = new WavePlayer();
        private void playWOW_Click(object sender, EventArgs e)
        {
            wavePlayer.play(pathInput.Text);
        }

        private void pauseWOW_Click(object sender, EventArgs e)
        {
            wavePlayer.pause();
        }

        private void stopWOW_Click(object sender, EventArgs e)
        {
            wavePlayer.stop();
        }
    }
}
