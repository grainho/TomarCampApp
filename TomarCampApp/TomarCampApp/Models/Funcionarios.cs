using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TomarCampApp.Models
{
    public class Funcionarios
    {

        public Funcionarios()
        {
            ListaDeObjetosDeActFun = new HashSet<ActFun>();
        }

        public int ID { get; set; }

        public string Nome { get; set; }

        public string Password { get; set; }

        public string Foto { get; set; }

        public virtual ICollection<Pais> PaisInscritos { get; set; }

        public virtual ICollection<ActFun> ListaDeObjetosDeActFun { get; set; }
    }
}