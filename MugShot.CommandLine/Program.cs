using System;
using System.Text;
using MugShot.Lib.SourcesTypes;

namespace MugShot.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {

            var fs = new DirectoryScanner {RecursiveLevel = 3};

            //fs.Scan(@"C:\web\php");
            fs.Scan(@"G:\projects\MugShot\MugShot.CommandLine\test_photos");

            Console.ReadLine();
        }
    }
}
