﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProjeto.Exercicios
{
    class Cachorro : Animal
    {
        public string Latir { get; set; }

        public override void ResumoAnimal()
        {
            base.ResumoAnimal();
            Console.WriteLine($"Tipo sonoro: {Latir}");
        }
        
        public override void TipoAnimal()
        {
            Console.WriteLine("Cachorro:");
        }
        

    }
}
