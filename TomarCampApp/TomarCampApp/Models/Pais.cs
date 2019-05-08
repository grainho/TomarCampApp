using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TomarCampApp.Models
{
    public class Pais
    {

        public int ID { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string NumCC { get; set; }

        public string NIF { get; set; }

        public string Telemovel { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        [ForeignKey("Funcionariosfk")]
        public Funcionarios Funcionarios { get; set; }
        public int Funcionariosfk { get; set; }
        

        public virtual ICollection<Criancas> CriancasAtribuidas { get; set; }

    }
}