using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
     class VerificationManager:IVerificationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            int sayi = gamer.NationalityId.Length;

            if (sayi == 9) ;
            {
                return true;
           
            }
            else
            {
                return false;
            }
        
        
        }   
    }
}
