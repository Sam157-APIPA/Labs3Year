using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    internal class Sponsor
    {
        public int SponsorID { get; set; }
        public string SponsorName { get; set; }
        public int MoneyCapasity { get; set; }
        public int DateOfPayment { get; set; }
        public ICollection<Tournament> TournamentID { get; set; }
        public Sponsor()
        {
            TournamentID = new List<Tournament>();
        }
    }
}
