using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourPicker
{
    class SaveToFile
    {
        public static List<string> lines = new List<string>();

        public static void saveLines()
        {
            try
            {
                foreach (string value in lines)
                {
                    File.AppendAllText("E:\\hexcodes.txt", value + Environment.NewLine);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
