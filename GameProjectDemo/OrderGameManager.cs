using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class OrderGameManager : IOrderGameService
    {
        ICampaignGameService _campaignGameService;

        public OrderGameManager(ICampaignGameService campaignGameService)
        {
            _campaignGameService = campaignGameService;
        }

        public void Siparis(Game game)
        {
            _campaignGameService.IndirimYap(game);
            Console.WriteLine("Satın Alındı..");
            
            
        }
    }
}
