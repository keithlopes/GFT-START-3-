﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonagemRPGex1
{
  public class Mago : Personagem 

    {
        public Mago(string nome, int Vida, int Mana, double Xp, int Inteligencia, int Forca, int Level) : base(nome, Vida, Mana, Xp, Inteligencia, Forca, Level)
        {
        }

        public class Magia : List<String>
        {

        }
        public  override void  lvlUp()
        {

        }
        public void Attack()
        {

        }
        public string AprenderMagia()
        {
            return string.Empty;
        }


    }
}
