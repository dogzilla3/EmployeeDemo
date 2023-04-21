using System.IO;
using System;

namespace FormCodeGenerator
{
    public class FileReader
    {
        private String? line;
        private StreamReader? sr;
        private String? fileContents;

        public FileReader(String inputFileName)
        {
            Console.WriteLine("???????????????????????????????");
            try
            {
                sr = new StreamReader("C:\\Users\\Will\\Documents\\Visual Studio 2022\\Projects\\Github\\EmployeeDemo\\FormCodeGenerator\\" + inputFileName);
                line = sr.ReadLine();
                while (line != null)
                {
                    fileContents = fileContents + '\n' + line;
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.ToString());
            }
            finally // Incase we need this.
            {
            }
        }
        
        public string? FileContents { get { return fileContents; } }    

    }
}
