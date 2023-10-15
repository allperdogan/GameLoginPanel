using MernisServiceReference;
using OyunGirisOdev.Abstract;
using OyunGirisOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunGirisOdev.Adapters
{
    internal class MernisServiceAdapter : IGamerCheckService
    {
        public bool GamerCheck(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.YearOfBirth);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
