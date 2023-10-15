using OyunGirisOdev.Abstract;
using OyunGirisOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunGirisOdev.Concrete
{
    internal class GamerCheckManager : IGamerCheckService
    {
        public bool GamerCheck(Gamer gamer)
        {
            return true;
        }
    }
}
