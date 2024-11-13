using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    class Refery : Person
    {
        public ICollection<Tournament> TournamentID {  get; set; }
        public Refery()
        {
            TournamentID = new List<Tournament>();
        }
    }
}
