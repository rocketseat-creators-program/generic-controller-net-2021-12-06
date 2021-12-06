using GenericController.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Models
{
    public class Veiculo :IEntity<string>
    {   
        [NotMapped]
        public string Id { get { return this.Placa; } set { this.Placa = value; } }
        [Key]
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
    }
}
