using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted.");
        }

        public void Save(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Gamer Saved. "+ gamer.FirstName);
            }
            else
            {
                throw new Exception("Doğrulama Basarisiz...Kayıt Basarisiz..");
            }
            
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated.");
        }
    }
}
