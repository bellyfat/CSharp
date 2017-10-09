using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace checkForString
{
    public class checkWithRegex
    {
        public string pattern = @"([^\""""]*)\""""? (\d{2}) (\d{5}.\d{2}) (\d{3}-\d{7})";
        public string input;
        public checkWithRegex(string input)
        {
            this.input = input;
        }
        public MatchCollection checkRegex()
        {
            return Regex.Matches(input, pattern);
        }
    }
}
