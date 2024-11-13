using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    internal class Sportsman : Person
    {
        public int ClubID { get; set; }
        public ICollection<Achivments> Achivmet { get; set; }
        public ICollection<AgeGroup> AgeGroup { get; set; }
        public ICollection<Weight> WeightOnDate { get; set; }
        public ICollection<Tournament> TournamentID { get; set; }
        public Statistics FightInTournamentID { get; set; }
        public Fight FightID { get; set; }
        public Sportsman() {
            WeightOnDate = new List<Weight>();
            Achivmet = new List<Achivments>();
            AgeGroup = new List<AgeGroup>();
            TournamentID = new List<Tournament>();
        }
    }
}
