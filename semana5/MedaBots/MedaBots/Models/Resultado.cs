using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaBots.Models
{
    public class Resultado<TEnity>
    {
        public bool Empate { get; set; }
        public TEnity Vencedor { get; set; }
    }
}
