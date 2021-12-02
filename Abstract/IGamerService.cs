using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
     public interface IGamerService
    {
        void add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);

    }
    

    
}
