/* Please feel free to rename this as you like because it currently has a dumb name. 
Also code was totally borrowed from this place: https://msdn.microsoft.com/en-us/library/ezwyzy7b.aspx
and put here for ease of sharing and as a base. Cool. Also make sure to do the right things in VS2013 
so that it works before actually trying to do other things. 
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarything
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Victoria\Documents\PreClearance\students.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
        
    }
}
