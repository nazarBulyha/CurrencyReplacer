using CurrencyReplacer;
using System.IO;

namespace DeleteDestinationDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            MainForm currencyReplacer = new MainForm();

            if (Directory.Exists(currencyReplacer.DestinationPath))
                Directory.Delete(currencyReplacer.DestinationPath, true);
        }
    }
}
