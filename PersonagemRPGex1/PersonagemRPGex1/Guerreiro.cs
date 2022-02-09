using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonagemRPGex1
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome, int Vida, int Mana, double Xp, int Inteligencia, int Forca, int Level) : base(nome, Vida, Mana, Xp, Inteligencia, Forca, Level)
        {

        }

        public class Habilidade : List<String>
        {

        }
        public override void lvlUp()
        {

        }
        public void Attack()
        {
        }
        public string AprenderHabilidade()
        {
            return string.Empty;
        }
    }
}
