﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Aula
    {
        private String idAula;
        private int edificio;

        public string IdAula { get => idAula; set => idAula = value; }
        public int Edificio { get => edificio; set => edificio = value; }
    }
}
