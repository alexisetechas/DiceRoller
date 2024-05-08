using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Models
{
    
    public class Dice
    {
        //construção da classe Dice
        public int lados { get; set; }
        public int NumeroSorteado { get; set; }

        Dice(int quantidadeLados)
        {
            lados = quantidadeLados;
        }

        public void Rolar()
        {
            Random random = new Random();
            NumeroSorteado = random.Next(lados) + 1;
        }
    }
}
