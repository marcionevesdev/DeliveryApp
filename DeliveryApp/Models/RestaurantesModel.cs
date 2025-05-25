using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    /// <summary>
    ///     Modelo de dados  para Restaurantes.
    /// </summary>
    public class RestaurantesModel
    {
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public string? TempoDeEntrega { get; set; }
        public string? Imagem { get; set; }
        public bool Aberto { get; set; }
    }
}
