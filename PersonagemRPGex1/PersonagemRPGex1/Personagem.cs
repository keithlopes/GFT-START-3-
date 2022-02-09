using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonagemRPGex1
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public double Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }

        public Personagem(string nome, int Vida, int Mana, double Xp, int Inteligencia, int Forca, int Level)
        {
            this.Nome = nome;
            this.Vida = Vida;
            this.Mana = Mana;
            this.Xp = Xp;
            this.Inteligencia = Inteligencia;
            this.Forca = Forca;
            this.Level = Level;


        }
        public virtual void lvlUp()
        {

        }




    }
}
