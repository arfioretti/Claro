using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Claro.Domain.Entities
{
    public class Celular
    {
        public int CelularId { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Photo { get; set; }
        public string Date  { get; set; }
    }
}