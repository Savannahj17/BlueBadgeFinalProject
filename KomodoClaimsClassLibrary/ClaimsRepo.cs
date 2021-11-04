using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsClassLibrary
{
    public class ClaimsRepo
    {


        protected readonly List<Claims> _claim = new List<Claims>();

        public bool AddClaimToDirectory(Claims claim)
        {
            int startingCount = _claim.Count;
            _claim.Add(claim);

            bool wasAdded = _claim.Count > startingCount ? true : false;
            return wasAdded;

        }

        public List<Claims> GetAllContents()
        {
            return _claim;
        }

        public Claims GetClaimById(int claimId)
        {

            foreach (Claims claim in _claim)
            {
                if (claim.ClaimId == claimId)
                {
                    return claim;
                }
            }
            return null;
        }

        public bool UpdateExistingClaim(int claimId, Claims newClaim)
        {
            Claims oldClaim = GetClaimById(claimId);
            if (oldClaim != null)
            {
                oldClaim.ClaimId = newClaim.ClaimId;
                oldClaim.ClaimAmount = newClaim.ClaimAmount;
                oldClaim.DateOfClaim = newClaim.DateOfClaim;
                oldClaim.DateOfIncident = newClaim.DateOfIncident;
               
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingClaim(Claims existingClaim)
        {
            bool deleteResult = _claim.Remove(existingClaim);
            return deleteResult;
        }
    }
}
