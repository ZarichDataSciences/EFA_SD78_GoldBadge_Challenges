using Komodo01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Instantiate Klaims Repo

            Repo repo = new Repo();

            //Klaim (int claimid, string type, string desc, double claim_amt, DateTime date_incident, DateTime date_claim, bool isvalid)

            //KarKlaim(int claimid, string desc, double claim_amt, DateTime date_incident, DateTime date_claim, bool isvalid)
            //KHomeKlaim(int claimid, string desc, double claim_amt, DateTime date_incident, DateTime date_claim, bool isvalid)
            //KTheftKlaim(int claimid, string desc, double claim_amt, DateTime date_incident, DateTime date_claim, bool isvalid)


            // make a (or several) test items 
            DateTime expected_date_incident = DateTime.Now; 
            DateTime expected_date_claim = DateTime.Now;

            KarKlaim kar = new KarKlaim(1, "description1", 1000, expected_date_incident, expected_date_claim, true);
            KHomeKlaim home = new KHomeKlaim(2, "description2", 1001, expected_date_incident, expected_date_claim, true);
            KTheftKlaim theft = new KTheftKlaim(3, "description3", 1002, expected_date_incident, expected_date_claim, true);


            // and insert them into the repo
            repo.enterANewClaim(kar);
            repo.enterANewClaim(home);
            repo.enterANewClaim(theft);

            // test that they exist, that you can retrieve them, and that they have the values you want

            Assert.IsTrue(repo.GetListOfKlaims().Count == 3);

            // [object 1 (index 0)| object 2 (index 1) | object 3 (index 2)]
            Assert.AreEqual(repo.GetListOfKlaims()[0].ClaimID, 1);
            Assert.AreEqual(repo.GetListOfKlaims()[1].ClaimID, 2);
            Assert.AreEqual(repo.GetListOfKlaims()[2].ClaimID, 3);
            
            Assert.AreEqual(repo.GetListOfKlaims()[0].ClaimAmount, 1000);
            Assert.AreEqual(repo.GetListOfKlaims()[1].ClaimAmount, 1001);
            Assert.AreEqual(repo.GetListOfKlaims()[2].ClaimAmount, 1002);

            Assert.AreEqual(repo.GetListOfKlaims()[0].ClaimType, "KarKlaim");
            Assert.AreEqual(repo.GetListOfKlaims()[1].ClaimType, "KHome");
            Assert.AreEqual(repo.GetListOfKlaims()[2].ClaimType, "KTheft");

            Assert.AreEqual(repo.GetListOfKlaims()[0].DateOfClaim, expected_date_claim);
            Assert.AreEqual(repo.GetListOfKlaims()[1].DateOfClaim, expected_date_claim);
            Assert.AreEqual(repo.GetListOfKlaims()[2].DateOfClaim, expected_date_claim);

            Assert.AreEqual(repo.GetListOfKlaims()[0].DateOfIncident, expected_date_incident);
            Assert.AreEqual(repo.GetListOfKlaims()[1].DateOfIncident, expected_date_incident);
            Assert.AreEqual(repo.GetListOfKlaims()[2].DateOfIncident, expected_date_incident);

            Assert.AreEqual(repo.GetListOfKlaims()[0].Description, "description1");
            Assert.AreEqual(repo.GetListOfKlaims()[1].Description, "description2");
            Assert.AreEqual(repo.GetListOfKlaims()[2].Description, "description3");

            Assert.IsTrue(repo.GetListOfKlaims()[0].IsValid);
            Assert.IsTrue(repo.GetListOfKlaims()[1].IsValid);
            Assert.IsTrue(repo.GetListOfKlaims()[2].IsValid);
        }
    }
}
