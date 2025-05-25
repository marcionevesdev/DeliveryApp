using DeliveryApp.Models;
using DeliveryApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.ViewModels
{
    /// <summary>
    /// ViewModel para comunicação da página com o modelo de dados
    /// </summary>
    public class RestaurantesViewModel
    {
        #region Propriedades

        /// <summary>
        /// Coleção de objetos utilizada para exibit uma lista de restaurantes (Model)
        /// dentro da página (View)
        /// </summary>
        public ObservableCollection<RestaurantesModel> Restaurantes { get; set; }
            = new ObservableCollection<RestaurantesModel> { };

        #endregion

        /// <summary>
        /// Método construtor (Inicializando quando a classe é instanciada)
        /// </summary>
        public RestaurantesViewModel()
        {
            Restaurantes = new ObservableCollection<RestaurantesModel>
                (RestaurantesService.GetRestaurantes());
        }
    }
}
