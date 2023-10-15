using OyunGirisOdev.Abstract;
using OyunGirisOdev.Adapters;
using OyunGirisOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunGirisOdev.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService) 
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.GamerCheck(gamer))
            {
                Console.WriteLine(gamer.Nickname + " adlı oyuncu oyuna eklendi.");
            }
            else
            {
                Console.WriteLine("Kullanıcı geçerli değil");
            }
            
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Nickname + " adlı oyuncu oyundan silindi.");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Nickname + " adlı oyuncu güncellendi.");
        }
    }
}
