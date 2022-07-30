using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedaBots.Enums;

namespace MedaBots.Interface
{
    public interface IBot
    {
        public string Nome { get;  }
        public int Hp { get;  }
        public EStatus Status { get;  }

        public void Iniciar();
        public void Parar();
        public abstract int CausarDano();
        public void ReduzirHp(int dano);
    }
}
