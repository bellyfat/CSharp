using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusLib
{
    public class Circus
    {
        private Dictionary<Artist, int> artistDictonary = new Dictionary<Artist, int>();

        public string Name { get; set; }
        public Circus(string name)
        {
            this.Name = name;
        }
        public void ArtistPerformance(Artist artist)
        {
            artistDictonary[artist] += 1;
        }
        public void Employ(Artist artist)
        {
            artistDictonary.Add(artist, 0);
        }
        private string listPerformances()
        {
            string performancesstring = "";
            for (int x = 0; x < artistDictonary.Count; x++)
            {
                string timesvar = artistDictonary.ElementAt(x).Value > 1 || artistDictonary.ElementAt(x).Value == 0 ? "gånger" : "gång";

                performancesstring += artistDictonary.ElementAt(x).Key.Name + " har uppträtt " 
                    + artistDictonary.ElementAt(x).Value.ToString() + " " + timesvar + ".";
                if (artistDictonary.Count > 0 && x != artistDictonary.Count - 1)
                {
                    performancesstring += " ";
                }
            }
            return performancesstring;
        }
        public override string ToString()
        {
            return String.Format("Cirkusen {0} har {1} artister. {2}", 
                Name, artistDictonary.Count, listPerformances());
        }
    }
}
