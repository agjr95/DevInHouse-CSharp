using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedaBots.Enums;
namespace MedaBots.Models
{
    public class PartidaBatalha
    {

        public Resultado<Bot> Batalhar(Bot robo1, Bot robo2, int nroPartidas = 15)
        {
            

            for (int i = 0; i < nroPartidas; i++)
            {
                Console.WriteLine($"MedaBot: {robo1.Nome} HP: {robo1.Hp}  VS  MedaBot: {robo2.Nome} HP: {robo2.Hp} ");

                AtaqueIniciativa(robo1, robo2);

                if (robo1.Status == EStatus.Destruido)
                   return DefinirResultado(robo2);
                    
                if (robo2.Status == EStatus.Destruido)
                    return DefinirResultado(robo1);
            }
            Bot winner = DefinirVencedorPorHP(robo1, robo2);

            return DefinirResultado(winner);

        }
        private static void AtaqueIniciativa(params Bot[] robos)
        {
            Random random = new Random();
            int indice = random.Next(1, 2);
            Bot primeiroAtacante = robos[indice];
            Bot segundoAtacante = robos[Math.Abs(indice - 1)];

            segundoAtacante.ReduzirHp(primeiroAtacante.CausarDano());
        }

        private static Resultado<Bot> DefinirResultado(Bot winner)
        {
            var resultado = new Resultado<Bot>();
            resultado.Empate = false;
            resultado.Vencedor = winner;
            return resultado;
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
