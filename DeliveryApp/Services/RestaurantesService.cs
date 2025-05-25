using DeliveryApp.Models;

namespace DeliveryApp.Services
{
    public class RestaurantesService
    {
        public static List<RestaurantesModel> GetRestaurantes() => new()
        {
            new RestaurantesModel
            {
                Nome = "Pizza Hut",
                Categoria = "Pizza • Massas artesanais e borda recheada",
                TempoDeEntrega = "30-40 min",
                Imagem = "pizza.jpg",
                Aberto = true
            },
            new RestaurantesModel
            {
                Nome = "Sushi Now",
                Categoria = "Comida Japonesa • Temakis, sushis e combinados frescos",
                TempoDeEntrega = "45-60 min",
                Imagem = "sushi.jpg",
                Aberto = true
            },
            new RestaurantesModel
            {
                Nome = "Burger Town",
                Categoria = "Hambúrguer Gourmet • Smash burgers e batatas crocantes",
                TempoDeEntrega = "25-35 min",
                Imagem = "burger.jpg",
                Aberto = false
            },
            new RestaurantesModel
            {
                Nome = "Viva Fit",
                Categoria = "Comida Saudável • Saladas, grelhados e pratos leves",
                TempoDeEntrega = "20-30 min",
                Imagem = "salada.jpg",
                Aberto = true
            },
            new RestaurantesModel
            {
                Nome = "La Pasta",
                Categoria = "Italiana • Massas frescas e molhos caseiros",
                TempoDeEntrega = "30-45 min",
                Imagem = "italian.jpg",
                Aberto = true
            },
            new RestaurantesModel
            {
                Nome = "Padoca da Vila",
                Categoria = "Padaria • Pães artesanais, cafés e bolos",
                TempoDeEntrega = "15-25 min",
                Imagem = "padaria.jpg",
                Aberto = true
            },
        };

    }
}
