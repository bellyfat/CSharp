using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SIEImportLib
{
    public class RegexMatchCounter
    {
        public int CountMatchingLines()
        {
            return 0;
        }

        public int CountMatchingLines(string content, string pattern)
        {
            StreamReader streamreader;
            int rows = 0;
            try
            {
                streamreader = File.OpenText(content);
                while(true)
                {
                    
                   string line = streamreader.ReadLine();
                   
                    if (line == null)
                    break;

                    Match match = Regex.Match(line, pattern);
                    if (match.Success)
                    {
                        rows++;
                    }
                }
                return rows;
            }
            catch(IOException ioe)
            {
                Debug.WriteLine(ioe.StackTrace);
            }
            return rows;
        }
    }
}
