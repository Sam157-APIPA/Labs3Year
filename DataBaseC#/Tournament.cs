using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    internal class Tournament
    {
        public int TournamentID { get; set; }
        public Refery ReferyID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Year  { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public ICollection<Sportsman> SportsmanID { get; set; }
        public ICollection<Sponsor> SponsorID { get; set; }
        public ICollection<Statistics> FighterID { get; set; }
        public Tournament()
        {
            SportsmanID = new List<Sportsman>();
            SponsorID = new List<Sponsor>();
            FighterID = new List<Statistics>();
        }
    }
}
