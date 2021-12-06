using GenericController.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Models
{
    public class Funcionario : IEntity<int>
    {   
        [NotMapped]
        public int Id { get { return this.Matricula; } set { this.Matricula = value; } }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Documento { get; set; }
    }
}
