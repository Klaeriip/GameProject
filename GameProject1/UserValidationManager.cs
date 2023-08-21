using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject1
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if    (gamer.BirtYear == 2002 
                && gamer.FirstName == "Efekan" 
                && gamer.LastName =="ULUBAŞ" 
                && gamer.IdentityNumber == 54382823)
            {
                return true;
            }
             else 
            {
                return false; 
            }

        }
    }
}
