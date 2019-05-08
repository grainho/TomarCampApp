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
            ListaDeObjetosDeActCri = new HashSet<ActCri>();
            ListaDeObjetosDeActFun = new HashSet<ActFun>();
        }

        public int ID { get; set; }

        public DateTime dataComeco { get; set; }

        public DateTime dataFim { get; set; }

        public string materiais { get; set; }

        public string descricao { get; set; }



        public virtual ICollection<ActCri> ListaDeObjetosDeActCri { get; set; }

        public virtual ICollection<ActFun> ListaDeObjetosDeActFun { get; set; }
    }
}