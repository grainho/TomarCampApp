using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TomarCampApp.Models
{
    public class Criancas
    {

        public Criancas()
        {
            ListaDeObjetosDeActCri = new HashSet<ActCri>();
        }

        public int ID { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string NumCC { get; set; }

        public string NIF { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Doencas { get; set; }


        [ForeignKey("Paisfk")]
        public Pais Pais { get; set; }
        public int Paisfk { get; set; }
        

        public virtual ICollection<ActCri> ListaDeObjetosDeActCri { get; set; }
    }
}