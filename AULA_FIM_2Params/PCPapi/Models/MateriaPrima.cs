using GenericController.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Models
{
    public class MateriaPrima : IEntity<int>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Custo { get; set; }
        public int Quantidade { get; set; }
    }
}
