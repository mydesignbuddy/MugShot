using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;

namespace MugShot.Lib.Media
{
    public class ImageMedia : BaseMedia, IMedia
    {

        public new Boolean ExtractMetaData()
        {
            // Create an Image object. 
            System.Drawing.Image image = new Bitmap(@"G:\projects\MugShot\test_photos\ClayShoot0001.JPG");

            // Get the PropertyItems property from image.
            PropertyItem[] propItems = image.PropertyItems;

            // For each PropertyItem in the array, display the ID, type, and 
            // length.
            int count = 0;
            foreach (PropertyItem propItem in propItems)
            {
               
                Console.WriteLine(propItem.Id.ToString("x"));
                Console.WriteLine(propItem.Type.ToString());
                Console.WriteLine(propItem.Len.ToString());
                Console.WriteLine("-----------------------");

                count++;
            }
            // Convert the value of the second property to a string, and display 
            // it.
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            string manufacturer = encoding.GetString(propItems[1].Value);


            Console.WriteLine("Manufacturer: {0}", manufacturer.ToString());

            //need to fill this in with real metadata
            MetaData = new ArrayList();

            return true;
        }
    }
}
