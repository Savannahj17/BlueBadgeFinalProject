using KomodoClaimsClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoClaimsUnitTest
{
    [TestClass]
    public class ClaimsUnitTest1
    {
        ClaimsRepo _claimsRepo;
        Claims _claim;

        [TestInitialize]
        public void Arrange()
        {
            _claimsRepo = new ClaimsRepo();
            _claim = new Claims(12345, ClaimType.Home, "House Fire", 5000, 1103, 1103, true);
        }

        [TestMethod]
        public void AddClaimToDirectory_Test()
        {
            Claims claim = new Claims();
            bool value = _claimsRepo.AddClaimToDirectory(claim);
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void GetAllContents_Test()
        {
            List<Claims> list =_claimsRepo.GetAllContents();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void GetClaimById_Test()
        {
            Claims claim = _claimsRepo.GetClaimById(_claim.ClaimId);
            Assert.IsNotNull(claim);
        }

        [TestMethod]
        public void UpdateExistingClaim_Test()
        {
            _claim2 = new Claims(678910, ClaimType.Car, "Flat Tire", 200, 1115, 1116, false);
            bool wasFound = _claimsRepo.UpdateExistingClaim(_claim.ClaimId, _claim2);
            Assert.IsTrue(wasFound);
        }
    }
}
//Where does my method exist ? - arrange 
//what argument does it take? - arrange