using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    public interface IGameSaleService
    {
        void Sale(Gamer gamer,Game game,Campaign campaign);

    }
}
