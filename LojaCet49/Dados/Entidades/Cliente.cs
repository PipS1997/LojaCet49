using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaCet49.Dados.Entidades
{
    public class Cliente
    {

        public int Id { get; set; }


        public string Nome { get; set; }


        public string Morada { get; set; }


        public string Telemóvel { get; set; }



        public string Email { get; set; }

        
        
        [Display(Name = "Data de Nascimento")]
        public DateTime DNasc { get; set; }



        [Display(Name = "NIF") ]
        public int NIF { get; set; }


        [Display(Name = "Última Compra")]
        public DateTime UltimaCompra { get; set; }


        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Display(Name = "Valor em Divida")]
        public double ValorDivida { get; set; }

    }
}
