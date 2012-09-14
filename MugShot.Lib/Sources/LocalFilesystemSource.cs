using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using MugShot.Lib.MetaData;

namespace MugShot.Lib.Sources
{
    public class LocalFilesystemSource
    {
        // How much deep to scan. (of course you can also pass it to the method)
        public string[] FileTypes = new string[7];

        public int TotalFilesFound = 0;
        public int TotalValidFilesFound = 0;
        public int TotalDirectoriesFound = 0;
        public int RecursiveLevel { get; set; }

        public LocalFilesystemSource()
        {
            //init set of types
            FileTypes[0] = ".jpg";
            FileTypes[1] = ".jpeg";
            FileTypes[2] = ".png";
            FileTypes[3] = ".gif";
            FileTypes[4] = ".tif";
            FileTypes[5] = ".tiff";
            FileTypes[6] = ".bmp";
        }


        public void Scan(string sourceDir)
        {
            TraverseDirectory(sourceDir, 0);
            Console.WriteLine("Total Folders: {0}, Total Files: {1} Total Valid Files: {2}",
                TotalDirectoriesFound, TotalFilesFound, TotalValidFilesFound
            );
        }

        private void TraverseDirectory(string sourceDir, int level)
        {
            if (level <= RecursiveLevel)
            {
                // Process the list of files found in the directory. 
                string[] fileEntries = Directory.GetFiles(sourceDir);
                foreach (string filePath in fileEntries)
                {
                    // do something with fileName
                    string fileType = Path.GetExtension(filePath);
                    fileType = fileType.ToLower();
                    if (FileTypes.Contains(fileType))
                    {
                        string fileName = Path.GetFileNameWithoutExtension(filePath);

                        try
                        {
                            Bitmap image = new Bitmap(filePath);
                            int w = image.Width;
                            int h = image.Height;
                            float hr = image.HorizontalResolution;
                            float vr = image.VerticalResolution;

                            // Get the PropertyItems property from image.
                            PropertyItem[] propItems = image.PropertyItems;

                            // Convert the value of the second property to a string, and display it.
                            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                            string manufacturer = encoding.GetString(propItems[1].Value);

                            ImageParser parser = new ImageParser();
                            Object bmpObj = (object) image;
                            foreach (var s in parser.Parse(ref bmpObj))
                            {
                                KeyValuePair<string, string> kvp = (KeyValuePair<string, string>) s;
                                Console.WriteLine(kvp.Key + " = " + kvp.Value);
                            }


                            Console.WriteLine("------------------\nFile Type: {0} Name: {1} \nImage Size: {3}x{4}\n Res: {5}x{6}\nFull Path: {2}",
                                fileType, fileName, filePath, w, h, vr, hr
                            );
                        } catch {
                            //do something on error
                        }
                        TotalValidFilesFound++;
                    }
                    TotalFilesFound++;
                }

                // Recurse into subdirectories of this directory.
                string[] subdirEntries = Directory.GetDirectories(sourceDir);
                foreach (string subdir in subdirEntries)
                {
                    // Do not iterate through reparse points (directory junction points)
                    if ((File.GetAttributes(subdir) & FileAttributes.ReparsePoint)
                        != FileAttributes.ReparsePoint)
                    {
                        TotalDirectoriesFound++;
                        TraverseDirectory(subdir, level + 1);
                    }
                }
            }
        }
    }
}
