using OyunGirisOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunGirisOdev.Abstract
{
    public interface IGamerCheckService
    {
        public bool GamerCheck(Gamer gamer);
    }
}
