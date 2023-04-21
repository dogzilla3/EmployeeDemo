namespace FormCodeGenerator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileReader fr = new FileReader(@"testIn.txt");
            FileWriter fw = new FileWriter(@"testOut.txt", fileContentsToWrite: fr.FileContents);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}