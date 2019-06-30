using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TomarCampApp.Models
{
    public class Atividades
    {

        public Atividades()
        {
            ListaDeObjetosDeConcretizacao = new HashSet<Concretizacao>();

        }


        public int Id { get; set; }

        public DateTime dataCriacao { get; set; }

        public string materiais { get; set; }

        public string descricao { get; set; }


        public virtual ICollection<Concretizacao> ListaDeObjetosDeConcretizacao { get; set; }

        
    }
}