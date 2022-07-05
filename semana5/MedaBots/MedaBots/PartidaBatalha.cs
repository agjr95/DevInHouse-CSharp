using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedaBots.Enums;
using MedaBots.Models;
namespace MedaBots
{
    public  class PartidaBatalha
    {
        
        public Bot Batalhar(Bot robo1, Bot robo2, int nroPartidas = 15)
        {
            for(int i = 0; i < nroPartidas; i++)
            {
            Console.WriteLine($"MedaBot: {robo1.Nome} HP: {robo1.Hp}  VS  MedaBot: {robo2.Nome} HP: {robo2.Hp} ");

                robo1.ReduzirHp(robo2.CausarDano());
                if (robo1.Status == EStatus.Destruido)
                    return robo2;

                robo2.ReduzirHp(robo1.CausarDano());
                if (robo2.Status == EStatus.Destruido)
                    return robo1;
            }
            Bot winner = DefinirVencedorPorHP(robo1,robo2);
            
            return winner;

        }
        private static Bot DefinirVencedorPorHP(Bot robo1, Bot robo2)
        {
            Bot winner;

            if (robo1.Hp > robo2.Hp)
                winner = robo1;
            
            else
              winner = robo2;

            return winner;
        }
    }
}
