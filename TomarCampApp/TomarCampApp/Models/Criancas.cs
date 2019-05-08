using System;
using System.Collections.Generic;
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

        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Doencas { get; set; }

        public virtual ICollection<ActCri> ListaDeObjetosDeActCri { get; set; }
    }
}