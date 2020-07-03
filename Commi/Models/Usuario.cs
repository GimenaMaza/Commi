using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Commi.Models
{
    public class Usuario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public String NombreApellido { get; set; }

        public String NombreUsuario { get; set; }

        public Boolean EsAdmin { get; set; }

        public List<Pedido> Pedidos { get; set; }
    }
}