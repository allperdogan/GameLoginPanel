using OyunGirisOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunGirisOdev.Abstract
{
    internal interface ISaleService
    {
        void Sale(Product product, Gamer gamer, Campaign campaign = null); 
    }
}
