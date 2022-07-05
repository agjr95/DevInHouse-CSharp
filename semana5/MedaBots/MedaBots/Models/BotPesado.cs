using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedaBots.Enums;
namespace MedaBots.Models
{
    public class BotPesado : Bot
    {
        public BotPesado(string nome) : base(nome)
        {

        }
        public override int CausarDano()
        {
            if(Status == EStatus.Aguardando)
            {
                Console.WriteLine("Medabot is  recharging!");
                return 0;
            }
            Status = EStatus.Aguardando;
            return  20;
        }
    }
}
