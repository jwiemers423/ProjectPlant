using System.Drawing;
using System.IO;

namespace FormUI
{
    public class ImageConverter
    {
        public static Image byteArrayToImage(byte[] byteArrayIn)
        //Converts a Byte Array to image for display
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            //Converts an image stored in SQL to Byte Array for display
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
    }
}
