using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
     
        public interface IVerificationService
        {
            bool CheckIfRealPerson(Gamer gamer);
        }
    
}
