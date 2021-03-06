using ApiLabb4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Data
{
    public class InterestRepo : IInterestRepo
    {
        private ApiLabb4Context _Labb4Context;
        public InterestRepo(ApiLabb4Context labb4Context)
        {
            _Labb4Context = labb4Context;
        }
        public Interest AddInterest(Interest newInterest)
        {
            _Labb4Context.Interests.Add(newInterest);
            _Labb4Context.SaveChanges();
            return newInterest;
        }
    }
}
