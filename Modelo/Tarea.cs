﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Tareas")]
    public class Tarea
    {
        public Tarea()
        {
            PEDIDOS = new HashSet<Pedido>();
        }
        [Key]
        public Int32 CODIGO_TAREA { get; set; }
        public string NOMBRE { get; set; }
        public ICollection<Pedido> PEDIDOS {get;set;}
        public override string ToString()
        {
            return NOMBRE;
        }
    }
}
