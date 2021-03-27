using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo01
{
    class KHomeKlaim : Klaim
    {
        public KHomeKlaim(int claimid, string desc, double claim_amt, DateTime date_incident, DateTime date_claim, bool isvalid)
            : base(claimid, "KHome", desc, claim_amt, date_incident, date_claim, isvalid) // initialize parent
        {

        }
    }
}
