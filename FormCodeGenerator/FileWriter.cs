using System.IO;
using System;

namespace FormCodeGenerator
{
    public class FileWriter
    {
        String line;
        FileReader fr;
        StreamWriter sw;

        public FileWriter(String outputFileName, String fileContentsToWrite)
        {
            Console.WriteLine("???????????????????????????????");
            try
            {
                sw = new StreamWriter("C:\\Users\\Will\\Documents\\Visual Studio 2022\\Projects\\Github\\EmployeeDemo\\FormCodeGenerator\\" + outputFileName);
                sw.WriteLine(fileContentsToWrite);
            
                sw.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.ToString());
            }
            finally // Incase we need this.
            {
                Console.WriteLine("StringWriter: " + sw.ToString()); 
                Console.ReadLine();
            }
        }
    }
}
