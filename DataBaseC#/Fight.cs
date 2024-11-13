using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    internal class Fight
    {
        public Tournament TournamentID {  get; set; }
        public ICollection<Sportsman> SportsmanID { get; set; }
        public int DateOfBattle { get; set; }
        public Sportsman BattleResult { get; set; }
        public int WinnerScore { get; set; }
        public Fight() 
        {
        SportsmanID = new List<Sportsman>();
        }
    }
}
