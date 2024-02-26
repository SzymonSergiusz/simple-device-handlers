using System;
using System.Drawing;
using System.Windows.Forms;
using WIA;

namespace SKANER
{
    public partial class Form1 : Form
    {
        Scanner scanner = new Scanner();
        public Form1()
        {
            InitializeComponent();
            formatsList.SelectedIndex = 0;
            //scanPreview.Image = new Bitmap("D:\\Studia\\UP_L2_Skaner\\test.jpg");
            //scanPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            colorBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void scanButton_Click(object sender, EventArgs e)
        {


            var wiaImg = scanner.scan();

            Image img = Image.FromStream(new System.IO.MemoryStream((byte[])wiaImg.FileData.get_BinaryData()));

            scanPreview.Image = new Bitmap(img);
            scanPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            scanPreview.Refresh();

        }

        private void scanPreview_Click(object sender, EventArgs e)
        {

        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            var extension = formatsList.SelectedItem.ToString();
            System.Diagnostics.Debug.WriteLine("ROZSZERZENIE: " + extension);

            String filename = filenameInput.Text.ToString();
            if (String.IsNullOrEmpty(filename))
            {
                filename = "braknazwy";
            }
            else
            {
                scanner.saveImageAs(filename, extension);

            }



        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void rotateLeft_Click(object sender, EventArgs e)
        {
            scanPreview.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            scanPreview.Refresh();
        }

        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            scanPreview.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            scanPreview.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void scanPreview_Click_1(object sender, EventArgs e)
        {
            scanPreview.Refresh();
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            int bright = int.Parse(brightnessValue.Value.ToString());
            int contrast = int.Parse(contrastValue.Value.ToString());
            int height = int.Parse(heightValue.Value.ToString());

            int width = int.Parse(widthValue.Value.ToString());
            int color = 0;
            String colorInput = colorBox.Text.ToString();
            switch (colorInput)
            {
                case "Kolorowy":
                    color = 1;
                    break;
                case "Szary":
                    color = 2;
                    break;
            }


            scanner.changeSettings(bright, contrast, height, width, color);
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            scanner.connect();
        }
    }
}