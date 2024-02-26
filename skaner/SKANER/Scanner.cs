using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using static System.Windows.Forms.DataFormats;

namespace SKANER
{
    class Scanner
    {
        const String PATH = @"C:\Users\lab\Desktop\UP_L2-skaner\nowy\SKANY\";
        DeviceInfo scannerInfo = null;
        Device scanner = null;
        ImageFile actualImage;
        Item item;
        public void connect()
        {
            var deviceManager = new DeviceManager();

            foreach (DeviceInfo deviceInfo in deviceManager.DeviceInfos)
            {
                if (deviceInfo.Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }
                else
                {
                    scannerInfo = deviceInfo;
                    System.Diagnostics.Debug.WriteLine(scannerInfo.Properties["Name"].get_Value().ToString());
                    scanner = scannerInfo.Connect();
                    item = scanner.Items[1];
                    //break;
                }
            }

            
        }

        public ImageFile scan()
        {

            if (item == null)
            {
                return new ImageFile();
            }
            else
            {


                actualImage = (ImageFile)item.Transfer(FormatID.wiaFormatPNG);
                return actualImage;

            }
        }

        public void saveImageAs(String name, String extension)
        {

            var path = PATH + name + "." + extension;
            String format = "";
            switch (extension)
            {
                case "png":
                    format = FormatID.wiaFormatPNG;
                    break;
                case "jpg":
                    format = FormatID.wiaFormatJPEG;
                    break;
                case "bmp":
                    format = FormatID.wiaFormatBMP;
                    break;
                case "tiff":
                    format = FormatID.wiaFormatTIFF;
                    break;
                // case "rle":
                //format = FormatID.wiaformatRle; // nie ma wiaformatrle
                //   break;
                default:
                    format = FormatID.wiaFormatPNG; // by default
                    break;
            }


            actualImage = (ImageFile)item.Transfer(format);
            if (actualImage != null)
            {
                if (File.Exists(path))
                {
                    Random rand = new Random();
                    path = PATH + name + rand.Next(0, 500) + "." + extension;
                    actualImage.SaveFile(path);
                }
                else
                {
                    actualImage.SaveFile(path);
                }

            }
            else
            {
                MessageBox.Show("Najpierw należy wykonać skan");
            }


        }

        internal void changeSettings(int bright, int contrast, int height, int width, int isColor)
        {

            /*
             * const HorizontalResolution = 6147
             * const VerticalResolution = 6148
             * const Contrast = 6155
             * const Brightness = 6154
             */
            Property propertyBrightness = item.Properties["6154"];
            Property propertyContrast = item.Properties["6155"];
            Property propertyHorizontalResolution = item.Properties["6147"];
            Property propertyVerticalResolution = item.Properties["6148"];
            Property propertyCurrentIntent = item.Properties["6146"];
            propertyBrightness.set_Value(bright);
            propertyContrast.set_Value(contrast);
            propertyHorizontalResolution.set_Value(height);
            propertyVerticalResolution.set_Value(width);
            propertyCurrentIntent.set_Value(isColor);
        }
    }
}