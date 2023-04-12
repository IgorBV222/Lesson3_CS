using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.GetFolderPath
                (Environment.SpecialFolder.MyDocuments);
            
            path += "\\" + "file.txt";
            Console.WriteLine(path);
            var streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("TEST");
            streamWriter.Close();

            var streamReader = new StreamReader(path);
            Console.WriteLine(streamReader.ReadLine());
            streamReader.Close();
            Console.ReadKey();
        }
    }
}
