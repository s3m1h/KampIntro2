using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    internal class MernisUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.NationaltyId == "123123123")
            {
                Console.WriteLine("Mernis Doğrulaması Yapılıyor..");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
