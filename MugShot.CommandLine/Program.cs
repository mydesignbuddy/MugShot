using System;
using System.Text;
using Args;
using MugShot.Lib.Sources;

namespace MugShot.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {

            var fs = new LocalFilesystemSource {RecursiveLevel = 3};

            //fs.Scan(@"C:\web\php");
            fs.Scan(@"G:\projects\MugShot\MugShot.CommandLine\test_photos");

            Console.ReadLine();
        }
    }
}
