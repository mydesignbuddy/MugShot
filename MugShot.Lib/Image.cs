using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace MugShot.Lib
{
    public class Image
    {
        public void ReadMetaData(){
            // Create an Image object. 
            System.Drawing.Image image = new Bitmap(@"G:\projects\MugShot\test_photos\ClayShoot0001.JPG");

            // Get the PropertyItems property from image.
            PropertyItem[] propItems = image.PropertyItems;

            // Set up the display.
            /*Font font = new Font("Arial", 12);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            int X = 0;
            int Y = 0;*/

            // For each PropertyItem in the array, display the ID, type, and 
            // length.
            int count = 0;
            foreach (PropertyItem propItem in propItems)
            {
                /*e.Graphics.DrawString(
                "Property Item " + count.ToString(),
                font,
                blackBrush,
                X, Y);

                Y += font.Height;

                e.Graphics.DrawString(
                   "   iD: 0x" + propItem.Id.ToString("x"),
                   font,
                   blackBrush,
                   X, Y);

                Y += font.Height;

                e.Graphics.DrawString(
                   "   type: " + propItem.Type.ToString(),
                   font,
                   blackBrush,
                   X, Y);

                Y += font.Height;

                e.Graphics.DrawString(
                   "   length: " + propItem.Len.ToString() + " bytes",
                   font,
                   blackBrush,
                   X, Y);

                Y += font.Height;*/
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

            /*e.Graphics.DrawString(
               "The equipment make is " + manufacturer + ".",
               font,
               blackBrush,
               X, Y);*/
        }
    }
}
