using System;

namespace Komodo01
{
    public class Klaim
    {
        public int ClaimID;
        public string ClaimType;
        public string Description;
        public double ClaimAmount;
        public DateTime DateOfIncident;
        public DateTime DateOfClaim;
        public bool IsValid;

        public Klaim (int claimid, string type, string desc, double claim_amt, DateTime date_incident, DateTime date_claim, bool isvalid)
        {
            ClaimID = claimid;
            ClaimType = type;
            Description = desc;
            ClaimAmount = claim_amt;
            DateOfIncident = date_incident;
            DateOfClaim = date_claim;
            IsValid = isvalid;
        }
    }
}