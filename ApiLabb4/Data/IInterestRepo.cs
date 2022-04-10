using ApiLabb4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLabb4.Data
{
    public interface IInterestRepo
    {
        Interest AddInterest(Interest newInterest);
    }
}
