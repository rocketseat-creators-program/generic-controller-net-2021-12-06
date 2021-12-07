using GenericController.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Models
{
    public class Veiculo : IEntity<string>
    {
        [Key]
        public string Id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
    }
}
