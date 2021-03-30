using System;
using System.Collections.Generic;

namespace Komodo01
{
    public class Repo
    {
        List<Klaim> _klaims = new List<Klaim>();

        public List<Klaim> GetListOfKlaims()
        {
            return _klaims; 
        }

        /*
           public void takeCareOfNextClaim()
        {
            throw new NotImplementedException();
        }
        */
        public void enterANewClaim(Klaim newKlaim) // can accept objects that are derived from Klaim 
        {
            _klaims.Add(newKlaim);
        }
    }
}