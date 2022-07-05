using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedaBots.Enums;
namespace MedaBots.Models
{
    public class BotLeve : Bot
    {
        public BotLeve(string nome ): base( nome )
        {

        }
        public override int CausarDano()
        {

            if (Status == EStatus.Ligado)
            {
                return 10;
            }
            else
            {
                Console.WriteLine("Medabot is sleeping");
                return 0;
            }
        }
    }
}
