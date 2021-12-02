using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
     class GamerManager: IGamerService
    {
        IVerificationService verificationService;
    
    
      public GamerManager(IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }
 

        public void add(Gamer gamer)
        {
            if (verificationService.CheckIfRealPerson(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "Oyuncu sisteme eklendi");

            }
            else
            {
                Console.WriteLine("Kayıt olunamadı,bilgiler yanlış");
            }

            Console.WriteLine("-----------------------------------------------------");

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "oyuncu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "Oyuncunun adı güncellendi.");

            Console.WriteLine("Oyuncunun güncel adı" + gamer.FirstName);
        
        }
      
    
    
    
    
    
    
    
    }


     











}


