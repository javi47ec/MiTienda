﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiTienda.Models
{
    public class Distrito
    {
        public string IdDistrito { get; set; }
        public string Descripcion { get; set; }
        public string IdProvincia { get; set; }
        public string IdDepartamento { get; set; }
    }
}