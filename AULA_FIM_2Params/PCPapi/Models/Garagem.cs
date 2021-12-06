using GenericController.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Models
{
    public class Garagem : IEntity<int>
    {
        public int Id { get; set; }
        public string Bloco { get; set; }
        public string Tipo { get; set; }
        public bool Ocupado { get; set; }
    }
}
