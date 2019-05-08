﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TomarCampApp.Models
{
    public class ActCri
    {

        public int Id { get; set; }

        // atributos específicos do relacionamento
        public int AtributoDoRelacionamento1 { get; set; }
        public string AtributoDoRelacionamento2 { get; set; }

        //***********************************************************************
        // definição da chave forasteira (FK) que referencia a classe Atividades
        //***********************************************************************
        [ForeignKey("Atividadesfk")]
        public Atividades Act { get; set; }
        public int Atividadesfk { get; set; }


        //***********************************************************************
        // definição da chave forasteira (FK) que referencia a classe Criancas
        //***********************************************************************
        [ForeignKey("Criancasfk")]
        public Criancas Cri { get; set; }
        public int Criancasfk { get; set; }
    }
}