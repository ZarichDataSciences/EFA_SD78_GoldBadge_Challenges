using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo01
{
    public class KarKlaim : Klaim
    {
        public KarKlaim(int claimid, string desc, double claim_amt, DateTime date_incident, DateTime date_claim, bool isvalid) 
            : base(claimid, "KarKlaim", desc, claim_amt, date_incident, date_claim, isvalid)  // initialize parent
        {

        }
    }
}
