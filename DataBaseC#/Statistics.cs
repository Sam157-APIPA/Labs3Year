using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    internal class Statistics
    {
        public Sportsman SportsmanID { get; set; }
        public Tournament TournamentID  { get; set; }
        public int CurrentWins  { get; set; }
        public int CurrentLoses { get; set; }
        public int CurrentScore { get; set; }
    }
}
