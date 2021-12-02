using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
     class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "Oyun eklendi");
            Console.WriteLine("------------------------------------------");
        
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "Oyun silindi");

        }
        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "Oyun güncellendi");
            Console.WriteLine("Güncel oyun ismi" + game.GameName);
        }

    }
}
