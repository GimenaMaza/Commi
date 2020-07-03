using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Commi.Models
{
    public class Pedido
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Estado Estado { get; set; }

        public  List <Plato> Platos { get; set; }
    }
    public enum Estado
    {
        CONFIRMADO, EN_PROCESO, ENTREGADO
    }
}