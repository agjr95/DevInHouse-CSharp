using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedaBots.Enums;
namespace MedaBots.Models
{
    public abstract class Bot
    {
        public Bot(string nome)
        {
            Nome = nome;
            Status = EStatus.Desligado;
            Hp = 100;
        }
        public string Nome { get; private set; }
        public int Hp { get; protected set; }
        public EStatus Status { get; protected set; }

        public EStatus Iniciar()
        {
            Status = EStatus.Ligado;
            return Status;
        }
        public EStatus Parar()
        {
            Status = EStatus.Desligado;
            return Status;
        }

        public abstract int CausarDano();

        public void ReduzirHp(int dano)
        {
            Hp -= dano;
            if(Hp <= 0)
            {
                Hp = 0;
                Status = EStatus.Destruido;
            }
            
        }
    }
}
