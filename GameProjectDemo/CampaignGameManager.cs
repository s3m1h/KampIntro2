using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class CampaignGameManager : ICampaignGameService
    {
        public void IndirimYap(Game game)
        {
            Console.WriteLine("Yüzde 10 indirim yapıldı...");
        }
    }
}
